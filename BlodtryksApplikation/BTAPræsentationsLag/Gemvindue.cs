using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BTALogikLag;

namespace BTAPræsentationsLag
{
    /// <summary>
    /// Vindue der dukker op når der trykkes på Gem
    /// </summary>
    public partial class Gemvindue : Form
    {
        private ControlLogikLag currentLL;
        /// <summary>
        /// DTO for gem-funktionalitet
        /// </summary>
        public GemDTO GDTO { get; private set; }
        private MonitorerDTO MDTO;

        private bool CPRvalidering;
        private bool PnummerValidering;
        private int valgtLængde;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="myLL">Kontrolklassen for logiklag som parameter</param>
        /// <param name="MDTO">Reference til monitorerings-DTO'en i BTAHovedvindue</param>
        public Gemvindue(ControlLogikLag myLL, ref MonitorerDTO MDTO)
        {
            this.currentLL = myLL;
            InitializeComponent();
            this.GDTO = currentLL.GLL.GDTO;
            this.MDTO = MDTO;
            LLængde.Text = (MDTO.RåBlodtrykssignal.Count/1000).ToString() + " sek"; 
        }

       /// <summary>
       /// Tjekker hvor meget af signalet der ønskes gemt
       /// </summary>
       /// <returns></returns>
        private bool validereTjekboxValgt()
        {
            if (RB10sek.Checked && MDTO.RåBlodtrykssignal.Count > 10000)
            {
                valgtLængde = 10;
                return true;
            }
            else if(RB1min.Checked && MDTO.RåBlodtrykssignal.Count > 60000)
            {
                valgtLængde = 60;
                return true;
            }
            else if(RBHelesignalet.Checked  || RB10sek.Checked || RB1min.Checked)
            {
                valgtLængde = MDTO.RåBlodtrykssignal.Count/1000;
                return true;
            }    
            else
                return false;
        }

        /// <summary>
        /// Gemmer valgt data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BNTGem_Click(object sender, EventArgs e)
        {
            CPRvalidering = currentLL.GLL.validerCPR(TXBCPR.Text);
            PnummerValidering = currentLL.GLL.validerPersonalenr(TXBPersonalenummer.Text); 
            
            bool chek = validereTjekboxValgt();
            if (CPRvalidering == true && PnummerValidering == true && chek == true)
            {
                List<double> list = MDTO.RåBlodtrykssignal;
                list.RemoveRange(0, list.Count - valgtLængde * 1000);
                GDTO.SignalBLOB = list.ToArray().SelectMany(value => BitConverter.GetBytes(value)).ToArray();
                GDTO.CPR = TXBCPR.Text;
                GDTO.Personalenummer = TXBPersonalenummer.Text;
                GDTO.Dato = DateTime.Now;
                GDTO.SignalLængde = valgtLængde.ToString() + " sekunder";

                bool b = currentLL.GLL.gemData(GDTO);
                if(b == true)
                {
                    MessageBox.Show("Data gemt i fil");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data ikke gemt i fil, prøve igen");
                    TXBCPR.Clear();
                    TXBPersonalenummer.Clear();
                    RB10sek.Checked = false;
                    RB1min.Checked = false;
                    RBHelesignalet.Checked = false;
                }
            }
            else if (CPRvalidering == false)
            {
                MessageBox.Show("Ugyldigt CPR.");
                TXBCPR.Clear();
            }
            else if (PnummerValidering == false)
            {
                MessageBox.Show("Ugyldigt personalenummer.");
                TXBPersonalenummer.Clear();
            }
            else
            {
                MessageBox.Show("Intet data valgt.");
                
            }
            

        }

        /// <summary>
        /// Lukker vindue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAnnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
