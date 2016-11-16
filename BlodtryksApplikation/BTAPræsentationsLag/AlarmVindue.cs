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

namespace BTAPræsentationsLag
{
    public partial class AlarmVindue : Form
    {
        public AlarmDTO ADTO { get; private set; }

        public AlarmVindue()
        {
            InitializeComponent();
            ADTO = new AlarmDTO();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < 30 || int.Parse(textBox1.Text) > 140 || int.Parse(textBox2.Text) < 150 || int.Parse(textBox2.Text) > 250)
            {
                MessageBox.Show("Ugyldige værdier indstastede - prøv igen");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                ADTO.NGrænse = int.Parse(textBox1.Text);
                ADTO.ØGrænse = int.Parse(textBox2.Text);
            }




        }
    }
}
