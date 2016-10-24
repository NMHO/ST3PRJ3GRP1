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
    public partial class BTAHovedvindue : Form
    {
        private KalibreringDTO KDTO;
        public BTAHovedvindue()
        {
            InitializeComponent();
            KDTO = new KalibreringDTO();            
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

        private void btnToolStripNulpunktsjusterSystem_Click(object sender, EventArgs e)
        {

        }

        private void btnNulpunktsjusterSystem_Click(object sender, EventArgs e)
        {

        }
    }
}
