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
using BlodtryksApplikationLogikLag;

namespace BlodtryksApplikation
{
    public partial class KalibreringsVindue : Form
    {
        private KalibreringDTO KDTO;

        private KalibreringLL KLL;
        private bool validering;
        public KalibreringsVindue(ref KalibreringDTO KDTO)
        {
            InitializeComponent();
            this.KDTO = KDTO;
            KLL = new KalibreringLL(ref KDTO);
            btnKalibreringNr2.Enabled = false;
            txbKalibreringNr2.Enabled = false;
            txbKalibreringNr1.Text = (0).ToString();
            txbKalibreringNr2.Text = (0).ToString();
        }

        private void btnKalibreringNr1_Click(object sender, EventArgs e)
        {
            validering = KLL.opdaterKalibreringsData(double.Parse(txbKalibreringNr1.Text), 1);
            if (validering == true)
            {
                // udskriv godkendt
                // aktiver Knap 2 og tekstfelt
                // 
                btnKalibreringNr1.Enabled = false;
                txbKalibreringNr1.Enabled = false;
                btnKalibreringNr2.Enabled = true;
                txbKalibreringNr2.Enabled = true;
                MessageBox.Show("Kalibreringstryk 1 godkendt og opdateret!", "Godkendt");
                
            }
            else
            {
                // udskriv fejlmeddelse
                // Nulstil KDTO
                KDTO = null;
                MessageBox.Show("Fejl i indtastning. Indtastningen skal være over 0 mmHg og under 250 mmHg", " Fejl i indtastet kalibreringstryk 1");
            }
        }

        private void btnKalibreringNr2_Click(object sender, EventArgs e)
        {            
            validering = KLL.opdaterKalibreringsData(double.Parse(txbKalibreringNr2.Text), 2);

            if (validering == true)
            {
                // udskriv godkend
                // Kald gem data metode
                // Luk vindue

                KLL.gemKalibrering();
                MessageBox.Show("Kalibreringstryk 2 godkendt og systemkalibrering opdateret", "Godkendt");
                Close();
            }
            else
            {
                // udskriv fejlmeddelse 
                // Nulstil KDTO
                btnKalibreringNr1.Enabled = false;
                txbKalibreringNr1.Enabled = false;
                btnKalibreringNr2.Enabled = false;
                txbKalibreringNr2.Enabled = false;
                MessageBox.Show("Fejl i indtastning. Indtastningen skal være over 0 mmHg og under 250 mmHg", " Fejl i indtastet kalibreringstryk 2");
            }
        }

        
    }
}
