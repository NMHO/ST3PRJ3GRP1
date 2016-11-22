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
    public partial class Gemvindue : Form
    {
        private ControlLogikLag currentLL;
        public GemDTO GDTO { get; private set; }

        private bool CPRvalidering;
        private bool PnummerValidering;
        private bool checkboxValidering;
        public Gemvindue(ControlLogikLag myLL)
        {
            InitializeComponent();
            //this.GDTO = currentLL;  //Mangler 

        }

        //private bool validereCPR(string CPR)
        //{
        //    char[] CPRArray = CPR.ToCharArray();
        //    int resultat = 0;
        //    int[] factor = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

        //    for (int i = 0; i < CPRArray.Length; i++)
        //    {
        //        resultat = ((CPRArray[i] - 48) * factor[i]) % 11;
        //    }
        //    if (resultat == 0)
        //        return true;
        //    else
        //        return false;
        //}
        private bool validerePersonalenr(string pnummer)
        {
            char[] PnummerArray = pnummer.ToCharArray();
            if (PnummerArray.Length == 6)
            {
                return true;
            }
            else
                return false;
        }
        private bool validereTjekboxValgt()
        {
            if (RB10sek.Checked || RB1min.Checked || RBHelesignalet.Checked)
                return true;
            else
                return false;
        }
        private void BNTGem_Click(object sender, EventArgs e)
        {
            /*bool CPR = validereCPR(TXBCPR.Text);
            bool pnummer = validerePersonalenr(TXBPersonalenummer.Text);
            bool chek = validereTjekboxValgt();
            if(CPR == true && pnummer == true && chek == true)
            {

            }
            else if (CPR == false)
            {
                MessageBox.Show("Ugyldigt CPR.");
            }
            else if (pnummer == false)
            {
                MessageBox.Show("Ugyldigt personalenummer.");
            }
            else
            {
                MessageBox.Show("Intet data valgt.");
            }
            */
        }

        private void BTNAnnuller_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
