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

        private void kalibrérSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var kalibreringsForm = new KalibreringsVindue(ref KDTO);
            kalibreringsForm.Show();
        }
    }
}
