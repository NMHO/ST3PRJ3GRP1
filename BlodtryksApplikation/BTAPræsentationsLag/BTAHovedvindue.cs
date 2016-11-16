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

namespace BTAPræsentationsLag
{
    /// <summary>
    /// Blodtryk Applikationens hovedvindue
    /// </summary>
    public partial class BTAHovedvindue : Form
    {
        private ControlLogikLag currentLL;
        public KalibreringDTO KDTO { get; private set; }
        public KalibreringsVindue kalibreringsForm { get; private set; }
        // private NulpunktsjusteringLL NPJLL;
        private double NulpunktsVærdi;
        /// <summary>
        /// Constructor, der initialisere BTA-vinduet og opretter en kalibrerings DTO
        /// </summary>
        public BTAHovedvindue(ControlLogikLag myLL)
        {
            currentLL = myLL;
            InitializeComponent();
            KDTO = currentLL.KLL.KDTO;
            BTN_filterOFF.Hide();             
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

        private void BTN_filterOFF_Click(object sender, EventArgs e)
        {
            BTN_filterOFF.Hide();
            BTN_FilterON.Show();
        }

        private void BTN_FilterON_Click(object sender, EventArgs e)
        {
            BTN_FilterON.Hide();
            BTN_filterOFF.Show();
        }

        
    }
}
