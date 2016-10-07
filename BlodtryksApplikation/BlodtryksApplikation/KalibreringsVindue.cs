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
    public partial class KalibreringsForm : Form
    {
        KalibreringDTO KDTO;
        private KalibreringLL KLL;
        private bool validering { get; set; }
        public KalibreringsForm(ref KalibreringDTO KDTO)
        {
            InitializeComponent();
            this.KDTO = KDTO;
            KLL = new KalibreringLL();
        }

        private void btnKalibreringNr1_Click(object sender, EventArgs e)
        {
            validering = KLL.opdaterKalibreringsData(double.Parse(txbKalibreringNr1.Text), 1);
            if (validering == false)
            {
                // udskriv fejlmeddelse
            }
            else
            {
                // udskriv godkendt
            }
        }

        private void btnKalibreringNr2_Click(object sender, EventArgs e)
        {
            validering = KLL.opdaterKalibreringsData(double.Parse(txbKalibreringNr2.Text), 2);

            if (validering == false)
            {
                // udskriv fejlmeddelse
            }
            else
            {
                // udskriv godkendt
            }
        }
    }
}
