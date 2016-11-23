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

namespace BTAPræsentationsLag
{
    /// <summary>
    /// Blodtryk Applikationens hovedvindue
    /// </summary>
    public partial class BTAHovedvindue : Form
    {
        private ControlLogikLag currentLL;
        private KalibreringDTO KDTO;
        private AlarmDTO ADTO;
        private MonitorerDTO MDTO;
        private KalibreringsVindue kalibreringsForm;
        private AlarmVindue alarmForm;
        private double NulpunktsVærdi;
        private static SemaphoreSlim sem = new SemaphoreSlim(1);
        private static bool monitorer;
        private Gemvindue gemForm;


        /// <summary>
        /// Constructor, der initialisere BTA-vinduet og opretter en kalibrerings DTO
        /// </summary>
        public BTAHovedvindue(ControlLogikLag myLL)
        {
            currentLL = myLL;
            InitializeComponent();
            KDTO = currentLL.KLL.KDTO;
            MDTO = new MonitorerDTO();
            currentLL.MLL.indstilRefTilDTO(ref MDTO);
            BTChartInit();
        }



        private void btnToolStripKalibrerSystem_Click(object sender, EventArgs e)
        {
            btnKalibrerSystem.PerformClick();
        }


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
            KalibreringDTO temp = currentLL.KLL.hentKalibreringFraDL();

            if (temp != null || KDTO.kalibreringsHældning != 0)
            {
                KDTO = temp;
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


        private void btnNulpunktsjusterSystem_Click(object sender, EventArgs e)
        {
            NulpunktsVærdi = currentLL.NPJLL.hentNulpunktsSpænding();
            MessageBox.Show("Nuljustering er foretaget. " + NulpunktsVærdi);
        }

        private void btnToolStripNulpunktsjusterSystem_Click(object sender, EventArgs e)
        {
            btnNulpunktsjusterSystem.PerformClick();
        }

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
                currentLL.MLL.framesize = 1;
            }

        }

        private void btnStartMåling_Click(object sender, EventArgs e)
        {
            alarmForm = new AlarmVindue();
            alarmForm.ShowDialog();
            this.ADTO = alarmForm.ADTO;

            if (alarmForm.ok == true)
            {
                MDTO.RåBlodtrykssignal.Clear();
                MDTO.NuværendeSekvens.Clear();
                MDTO.SignalLængdeISek = 0;

                BTChartInit();
                monitorer = true;
                Thread monThread = new Thread(monitorerBTIGUI);
                monThread.IsBackground = true;
                monThread.Start();
            }
        }

        private void btnStopMåling_Click(object sender, EventArgs e)
        {
            monitorer = false;
        }

        private void BTChartInit()
        {
            ChartBT.Series["BTSerie"].Points.Clear();
            ChartBT.ChartAreas["BTChartArea"].AxisX.Title = "Tid i sekunder";
            ChartBT.ChartAreas["BTChartArea"].AxisY.Title = "mmHg";
            ChartBT.ChartAreas["BTChartArea"].AxisY.Minimum = -1.0;
            ChartBT.ChartAreas["BTChartArea"].AxisY.Maximum = 6.0;

            ChartBT.ChartAreas["BTChartArea"].AxisX.Minimum = -10.0;
            ChartBT.ChartAreas["BTChartArea"].AxisX.Maximum = 0.0;

            var temp = new List<double>(new double[Convert.ToInt32(MDTO.midlingsFrekvens * 10 - 1.0)]);
            double xval = -10.0;
            double sampleTime = 1.0 / MDTO.midlingsFrekvens;

            foreach (var value in temp)
            {
                xval += sampleTime;
                ChartBT.Series["BTSerie"].Points.AddXY(xval, value);
            }
        }

        private void monitorerBTIGUI()
        {
            while (monitorer == true)
            {
                sem.Wait();
                currentLL.MLL.hentBTSekvens();
                opdaterBTChart(MDTO.NuværendeSekvens);
                sem.Release();
            }
        }

        private void opdaterBTChart(List<double> NuværendeSekvens)
        {
            EventArgs e = new MyEvent(NuværendeSekvens);
            object[] pList = { this, e };
            // Sender et event til GUI-tråden
            ChartBT.BeginInvoke(new MyEventsHandler(opdaterChart), pList);
        }

        private delegate void MyEventsHandler(object sender, MyEvent e);

        private void opdaterChart(object o, MyEvent e)
        {
            double xval = ChartBT.Series["BTSerie"].Points.Last().XValue + 1.0 / (MDTO.NuværendeSekvens.Count*10);

            foreach (var value in e.NuværendeSekvens)
            {
                ChartBT.Series["BTSerie"].Points.RemoveAt(0);
                ChartBT.Series["BTSerie"].Points.AddXY(xval, value);
                xval += (1.0) / (MDTO.NuværendeSekvens.Count*10);
            }

            double step = (e.NuværendeSekvens.Count + currentLL.MLL.framesize) / MDTO.midlingsFrekvens;

            ChartBT.ChartAreas["BTChartArea"].AxisX.Minimum = Math.Round(ChartBT.ChartAreas["BTChartArea"].AxisX.Minimum + step, 1);
            ChartBT.ChartAreas["BTChartArea"].AxisX.Maximum = Math.Round(ChartBT.ChartAreas["BTChartArea"].AxisX.Maximum + step, 1);
        }

        private void BTNGemdata_Click(object sender, EventArgs e)
        {
            gemForm = new Gemvindue(currentLL, ref MDTO);
            gemForm.ShowDialog();


            // this.KDTO = kalibreringsForm.KDTO;
        }
    }

    public class MyEvent : EventArgs
    {
        public List<double> NuværendeSekvens { get; private set; }

        public MyEvent(List<double> NuværendeSekvens)
        {
            this.NuværendeSekvens = NuværendeSekvens;
        }
    }
}
