using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTALogikLag;
using DTO;
using Interfaces;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Media;

namespace BTAPræsentationsLag
{
    /// <summary>
    /// Blodtryk Applikationens hovedvindue
    /// </summary>
    public partial class BTAHovedvindue : Form, IObserverPL
    {
        private ControlLogikLag currentLL;
        private KalibreringDTO KDTO;
        private AlarmDTO ADTO;
        private MonitorerDTO MDTO;
        private KalibreringsVindue kalibreringsForm;
        private AlarmVindue alarmForm;
        private double nulpunktsVærdi;
        private Gemvindue gemForm;
        private List<double> GUIChartPunkter;
        private Thread thread;
        private bool alarmLydTilstand;
        private bool alarmOnOff;        
        private SoundPlayer Player;

        /// <summary>
        /// Constructor, der initialisere BTA-vinduet og opretter en kalibrerings DTO
        /// </summary>
        public BTAHovedvindue(ControlLogikLag myLL)
        {
            currentLL = myLL;
            InitializeComponent();
            KDTO = new KalibreringDTO();
            MDTO = new MonitorerDTO();
            currentLL.MLL.indstilRefTilDTO(ref MDTO);
            BTChartInit();
            alarmLydTilstand = true;
            alarmOnOff = true;
        }

        /// <summary>
        /// Åbner kaliberingsform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKalibrerSystem_Click(object sender, EventArgs e)
        {
            kalibreringsForm = new KalibreringsVindue(currentLL);
            kalibreringsForm.ShowDialog();
            this.KDTO = kalibreringsForm.KDTO;
        }



        /// <summary>
        /// Ved start af program indlæses kalibreringsdata fra kalibreringsfil, hvis den findes
        /// </summary>
        private void BTAHovedvindue_Shown(object sender, EventArgs e)
        {
            BTNGemdata.Enabled = false;
            btnStartMåling.Enabled = false;
            btnStopMåling.Enabled = false;
            BTN_FilterON.Enabled = false;
            KalibreringDTO temp = currentLL.KLL.hentKalibreringFraDL();

            if (temp != null && temp.kalibreringsHældning != 0)
            {
                this.KDTO = temp;
            }
            else
            {
                var res = MessageBox.Show("Der er ikke fundet en tidligere kalibrering. Vil du foretage en nu?",
                    "Ingen kalibrering fundet..", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    btnKalibrerSystem.PerformClick();
                }
            }

        }

        /// <summary>
        /// Henter nulpunktsspænding 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNulpunktsjusterSystem_Click(object sender, EventArgs e)
        {
            nulpunktsVærdi = currentLL.NPJLL.hentNulpunktsSpænding();
            MessageBox.Show("Nulpunktsjustering er foretaget. (" + nulpunktsVærdi + ")");
            btnStartMåling.Enabled = true;
        }

        /// <summary>
        /// Aktiverer/deaktiverer filter ved at ændre framesize.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_FilterON_Click(object sender, EventArgs e)
        {
            if (BTN_FilterON.Text == "Diagnose-tilstand")
            {
                BTN_FilterON.Text = "Monitorerings-tilstand";
                currentLL.MLL.framesize = 5;
            }
            else
            {
                BTN_FilterON.Text = "Diagnose-tilstand";
                currentLL.MLL.framesize = 0;
            }

        }

        /// <summary>
        /// Åbner alarm-vindue og starter herefter indlæsning af signal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartMåling_Click(object sender, EventArgs e)
        {
            alarmForm = new AlarmVindue();
            alarmForm.ShowDialog();
            this.ADTO = alarmForm.ADTO;

            if (alarmForm.ok == true)
            {
                Player = new SoundPlayer();
                Player.SoundLocation = Environment.CurrentDirectory + @"\AppData\beep.wav";               

                MDTO.RåBlodtrykssignal.Clear();
                MDTO.NuværendeSekvens.Clear();
                MDTO.SignalLængdeISek = 0;

                BTChartInit();

                påførChartAlarmgrænser();

                currentLL.MLL.Attach(this);
                currentLL.MLL.startMåling();


                btnStartMåling.Enabled = false;

                BTN_FilterON.Enabled = true;

                btnKalibrerSystem.Enabled = false;
                btnNulpunktsjusterSystem.Enabled = false;

                txtSystole.Text = "0";
                txtSystole.ForeColor = Color.Lime;

                txtDiastole.Text = "0";
                txtDiastole.ForeColor = Color.Lime;

            }

        }
        /// <summary>
        /// Indsætter alarmgrænser på chart
        /// </summary>
        private void påførChartAlarmgrænser()
        {
            ChartBT.ChartAreas["BTChartArea"].AxisY.StripLines.Clear();

            StripLine ØGrænse = new StripLine();
            ØGrænse.IntervalOffset = Convert.ToDouble(ADTO.ØGrænse);
            ØGrænse.StripWidth = 1;
            ØGrænse.BackColor = Color.Red;
            ØGrænse.Text = "Øvre Alarmgrænse ";

            StripLine NGrænse = new StripLine();
            NGrænse.IntervalOffset = Convert.ToDouble(ADTO.NGrænse);
            NGrænse.StripWidth = 1;
            NGrænse.BackColor = Color.Red;
            NGrænse.Text = "Nedre Alarmgrænse ";

            ChartBT.ChartAreas["BTChartArea"].AxisY.StripLines.Add(ØGrænse);
            ChartBT.ChartAreas["BTChartArea"].AxisY.StripLines.Add(NGrænse);
        }

        /// <summary>
        /// Stopper indlæsning af signal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopMåling_Click(object sender, EventArgs e)
        {
            currentLL.MLL.Detach(this);
            currentLL.MLL.stopMåling();
            
            BTNGemdata.Enabled = true;
            btnStartMåling.Enabled = true;
            btnKalibrerSystem.Enabled = true;
            btnNulpunktsjusterSystem.Enabled = true;
        }
        /// <summary>
        /// Initialiserer chart
        /// </summary>
        private void BTChartInit()
        {
            ChartBT.Series["BTSerie"].Points.Clear();
            ChartBT.ChartAreas["BTChartArea"].AxisX.Title = "Tid i sekunder";
            ChartBT.ChartAreas["BTChartArea"].AxisY.Title = "mmHg";
            ChartBT.ChartAreas["BTChartArea"].AxisY.Minimum = 0.0;
            ChartBT.ChartAreas["BTChartArea"].AxisY.Maximum = 250.0;

            ChartBT.ChartAreas["BTChartArea"].AxisX.Minimum = -10.0;
            ChartBT.ChartAreas["BTChartArea"].AxisX.Maximum = 0.0;

            ChartBT.ChartAreas["BTChartArea"].AxisX.MajorGrid.Enabled = true;
            ChartBT.ChartAreas["BTChartArea"].AxisX.MajorGrid.Interval = 1;
            ChartBT.ChartAreas["BTChartArea"].AxisX.MajorGrid.LineWidth = 1;
            ChartBT.ChartAreas["BTChartArea"].AxisX.MajorGrid.LineColor = Color.White;

            ChartBT.ChartAreas["BTChartArea"].AxisY.MajorGrid.Enabled = true;
            ChartBT.ChartAreas["BTChartArea"].AxisY.MajorGrid.Interval = 50;
            ChartBT.ChartAreas["BTChartArea"].AxisY.MajorGrid.LineWidth = 1;
            ChartBT.ChartAreas["BTChartArea"].AxisY.MajorGrid.LineColor = Color.White;


            GUIChartPunkter = new List<double>(new double[Convert.ToInt32(MDTO.midlingsFrekvens * 10)]);
            double xval = -10.0;
            double sampleTime = 1.0 / MDTO.midlingsFrekvens;

            foreach (var value in GUIChartPunkter)
            {
                xval += sampleTime;
                ChartBT.Series["BTSerie"].Points.AddXY(xval, value);
                ChartBT.Series["BTSerie"].Points.Last().Color = Color.Transparent;
            }
        }
        /// <summary>
        /// Henter BT sekvens fra DTO og kalder opdaterBTChart
        /// </summary>
        private void monitorerBTIGUI()
        {
            currentLL.MLL.hentBTSekvens(KDTO.kalibreringsHældning, nulpunktsVærdi);
            opdaterBTChart(MDTO.NuværendeSekvens);
        }
        /// <summary>
        /// Laver et nyt event, og sender et event til GUI-tråden.
        /// </summary>
        /// <param name="NuværendeSekvens">Listen med den nuværende sekvens der skal tilføjes blodtryksgrafen</param>
        private void opdaterBTChart(List<double> NuværendeSekvens)
        {
            EventArgs e = new MyEvent(NuværendeSekvens);
            object[] pList = { this, e };
            ChartBT.BeginInvoke(new MyEventsHandler(opdaterChart), pList);
        }

        private delegate void MyEventsHandler(object sender, MyEvent e);

        /// <summary>
        /// Opdaterer chart kontinuerligt og validerer grænseværdier for alarm
        /// </summary>
        private void opdaterChart(object o, MyEvent e)
        {
            double nuværendeXval = ChartBT.Series["BTSerie"].Points.Last().XValue;
            double næsteXval = 1.0 / (MDTO.NuværendeSekvens.Count * 10);

            foreach (var value in e.NuværendeSekvens)
            {
                ChartBT.Series["BTSerie"].Points.RemoveAt(0);
                ChartBT.Series["BTSerie"].Points.AddXY(nuværendeXval + næsteXval, value);
                nuværendeXval += næsteXval;

                GUIChartPunkter.RemoveAt(0);
                GUIChartPunkter.Add(value);

                if (GUIChartPunkter.Last() > this.ADTO.ØGrænse)
                {
                    ChartBT.Series["BTSerie"].Points.Last().Color = Color.Red;
                }
                else if (GUIChartPunkter.Last() < this.ADTO.NGrænse)
                {
                    ChartBT.Series["BTSerie"].Points.Last().Color = Color.Red;                    
                }
                
            }

            if (e.NuværendeSekvens.Any(item => item > ADTO.ØGrænse) && alarmLydTilstand == true)
            {
                Player.Play();

                if (alarmOnOff == true)
                {
                    alarmOnOff = false;

                    var res = MessageBox.Show("Grænseværdien for blodtrykket er overskredet, vil du slukke for alarmen?",
                                        "Alarm overskredet!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        alarmLydTilstand = false;
                        cbAlarmlyd.Checked = false;
                    }
                }

            }
            else if (e.NuværendeSekvens.Any(item => item < ADTO.NGrænse) && alarmLydTilstand == true)
            {
                Player.Play();

                if (alarmOnOff == true)
                {
                    alarmOnOff = false;

                    var res = MessageBox.Show("Grænseværdien for blodtrykket er overskredet, vil du slukke for alarmen?",
                                    "Alarm overskredet!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        alarmLydTilstand = false;
                        cbAlarmlyd.Checked = false;
                    }
                }
            }


            if (ChartBT.Series["BTSerie"].Points.Last().XValue > 2)
            {
                var temp = GUIChartPunkter;
                temp.RemoveRange(0, Convert.ToInt32(GUIChartPunkter.Count * 0.8));

                var max = Math.Round(temp.Max(), 0);
                var min = Math.Round(temp.Min(), 0);
                txtSystole.Text = max.ToString();
                txtDiastole.Text = min.ToString();

                if (max > this.ADTO.ØGrænse)
                {
                    txtSystole.ForeColor = Color.Red;
                }
                else
                {
                    txtSystole.ForeColor = Color.Lime;
                }

                if (min < this.ADTO.NGrænse)
                {
                    txtDiastole.ForeColor = Color.Red;
                }
                else
                {
                    txtDiastole.ForeColor = Color.Lime;
                }

                btnStopMåling.Enabled = true;
            }
           

            double step = (e.NuværendeSekvens.Count + currentLL.MLL.framesize) / MDTO.midlingsFrekvens;

            ChartBT.ChartAreas["BTChartArea"].AxisX.Minimum = Math.Round(ChartBT.ChartAreas["BTChartArea"].AxisX.Minimum + step, 1);
            ChartBT.ChartAreas["BTChartArea"].AxisX.Maximum = Math.Round(ChartBT.ChartAreas["BTChartArea"].AxisX.Maximum + step, 1);
        }

        /// <summary>
        /// Åbner Gem-vindue
        /// </summary>
        private void BTNGemdata_Click(object sender, EventArgs e)
        {
            gemForm = new Gemvindue(currentLL, ref MDTO);
            gemForm.ShowDialog();
        }

        /// <summary>
        /// Opretter tråd som kalder monitorerBTIGUI fra præsentationslaget.
        /// </summary>
        public new void Update()
        {
            thread = new Thread(monitorerBTIGUI);
            thread.Name = "monThread";
            thread.IsBackground = true;

            thread.Start();
        }

        /// <summary>
        /// Aktiverer/deaktiverer alarmlyd
        /// </summary>
        private void cbAlarmlyd_MouseClick(object sender, MouseEventArgs e)
        {
            if (cbAlarmlyd.Checked == true)
            {
                alarmLydTilstand = true;
                alarmOnOff = true;
            }
            else
            {
                alarmLydTilstand = false;
                alarmOnOff = false;
            }
        }
    }

    /// <summary>
    /// Klasse til event
    /// </summary>
    public class MyEvent : EventArgs
    {
        /// <summary>
        /// Listen med den nuværende sekvens
        /// </summary>
        public List<double> NuværendeSekvens { get; private set; }

        /// <summary>
        /// Constructor der sætter den medsendte sekvens-parameter til klassens property
        /// </summary>
        /// <param name="NuværendeSekvens">Listen med den nuværende sekvens</param>
        public MyEvent(List<double> NuværendeSekvens)
        {
            this.NuværendeSekvens = NuværendeSekvens;
        }
    }
}
