using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlodtryksApplikationLogikLag;
using DTO;

namespace BlodtryksApplikation
{
    /// <summary>
    /// Blodtryk Applikationens hovedvindue
    /// </summary>
    public partial class BTAHovedvindue : Form
    {
        private KalibreringDTO KDTO;
        private NulpunktsjusteringLL NPJLL;
        private double NulpunktsVærdi;
        /// <summary>
        /// Constructor, der initialisere BTA-vinduet og opretter en kalibrerings DTO
        /// </summary>
        public BTAHovedvindue()
        {
            InitializeComponent();
            KDTO = new KalibreringDTO();
            NPJLL = new NulpunktsjusteringLL();
        }


        private void btnToolStripKalibrerSystem_Click(object sender, EventArgs e)
        {
            btnKalibrerSystem.PerformClick();
        }        


        private void btnKalibrerSystem_Click(object sender, EventArgs e)
        {
            var kalibreringsForm = new KalibreringsVindue(ref KDTO);
            kalibreringsForm.ShowDialog();            
        }


        /// <summary>
        /// Ved start af program indlæses kalibreringsdata fra kalibreringsfil, hvis den findes
        /// </summary>
        private void BTAHovedvindue_Shown(object sender, EventArgs e)
        {
            var KLL = new KalibreringLL(ref KDTO);
            KalibreringDTO temp = KLL.hentKalibreringFraDL();

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
            NulpunktsVærdi = NPJLL.hentNulpunktsSpænding();
            MessageBox.Show("Nuljustering udført.");
        }

        private void btnToolStripNulpunktsjusterSystem_Click(object sender, EventArgs e)
        {
            btnNulpunktsjusterSystem.PerformClick();
        }
    }
}
