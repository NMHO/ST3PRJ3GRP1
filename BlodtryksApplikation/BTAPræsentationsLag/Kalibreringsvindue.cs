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
using Interfaces;

namespace BTAPræsentationsLag
{
    /// <summary>
    /// Kalibreringsvindue
    /// </summary>
    public partial class KalibreringsVindue : Form
    {
        private ControlLogikLag currentLL;
        /// <summary>
        /// DTO for kalibrerings-funktionalitet
        /// </summary>
        public KalibreringDTO KDTO { get; private set; }
       
        private bool validering;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="myLL">Kontrolklassen for logiklag som parameter</param>
        public KalibreringsVindue(ControlLogikLag myLL)
        {
            this.currentLL = myLL;
            InitializeComponent();
            this.KDTO = currentLL.KLL.KDTO;
            btnKalibreringNr2.Enabled = false;
            txbKalibreringNr2.Enabled = false;
            txbKalibreringNr1.Text = (0).ToString();
            txbKalibreringNr2.Text = (0).ToString();
        }

        /// <summary>
        /// Håndterer kalibrering 1 programflow
        /// </summary>
        /// <remarks>
        /// Hvis validering er true: udskriv godkendt og aktiver Knap 2 og tekstfelt
        /// Hvis validering er false: udskriv fejlmeddelse
        /// </remarks>
        private void btnKalibreringNr1_Click(object sender, EventArgs e)
        {
            validering = currentLL.KLL.opdaterKalibreringsData(double.Parse(txbKalibreringNr1.Text), 1);
            if (validering == true)
            {
                this.KDTO = currentLL.KLL.KDTO;
                btnKalibreringNr1.Enabled = false;
                txbKalibreringNr1.Enabled = false;
                btnKalibreringNr2.Enabled = true;
                txbKalibreringNr2.Enabled = true;                
                MessageBox.Show("Kalibreringstryk 1 godkendt og opdateret!", "Godkendt");
                
            }
            else
            {               
                txbKalibreringNr1.Text = (0).ToString();
                MessageBox.Show("Fejl i indtastning. Indtastningen skal være over 0 mmHg og under 250 mmHg", " Fejl i indtastet kalibreringstryk 1");
            }
        }

        /// <summary>
        /// Håndterer kalibrering 2 programflow
        /// </summary>
        /// <remarks>
        /// Hvis validering er true: udskriv godkend, kald gem data metode og luk vindue
        /// Hvis validering er false: udskriv fejlmeddelse og gå til programflow 1 start
        /// </remarks>
        private void btnKalibreringNr2_Click(object sender, EventArgs e)
        {            
            validering = currentLL.KLL.opdaterKalibreringsData(double.Parse(txbKalibreringNr2.Text), 2);
            
            if (validering == true)
            {
                this.KDTO = currentLL.KLL.KDTO;
                currentLL.KLL.gemKalibrering(this.KDTO);
                MessageBox.Show("Kalibreringstryk 2 godkendt og systemkalibrering udført", "Godkendt");
                Close();
            }
            else
            {                
                btnKalibreringNr1.Enabled = true;
                txbKalibreringNr1.Enabled = true;
                btnKalibreringNr2.Enabled = false;
                txbKalibreringNr2.Enabled = false;
                txbKalibreringNr1.Text = (0).ToString();
                txbKalibreringNr2.Text = (0).ToString();
                MessageBox.Show("Fejl i indtastning. Indtastningen skal være over 0 mmHg og under 250 mmHg", " Fejl i indtastet kalibreringstryk 2");
            }
        }

        
    }
}
