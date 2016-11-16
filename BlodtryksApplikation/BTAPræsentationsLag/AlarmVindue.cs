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
            textBox1.Text = "30";
            textBox2.Text = "250";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADTO = new AlarmDTO();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ØGrænse_ = int.Parse(textBox2.Text);
            int NGrænse_ = int.Parse(textBox1.Text);

            if (ØGrænse_ > 250 || ØGrænse_ < 150 || NGrænse_ > 140 || NGrænse_ < 30)
            {
                MessageBox.Show("Udgyldige værdier - prøv igen");
                textBox1.Clear();
                textBox2.Clear();
            }
            else
            {
                ADTO.NGrænse = NGrænse_;
                ADTO.ØGrænse = ØGrænse_;
                this.Close();

            }
        }
    }
}
