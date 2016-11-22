using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTADataLag;
using DTO;

namespace BTALogikLag
{
    class GemLL
    {
        public GemDTO GDTO { get; set; }
        private ControlDataLag currentDatalag;

        public GemLL(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
            this.GDTO = currentDatalag.GDL.GDTO;
         }
        private bool validereCPR(string CPR)
        {
            char[] CPRArray = CPR.ToCharArray();
            int resultat = 0;
            int[] factor = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < CPRArray.Length; i++)
            {
                resultat = ((CPRArray[i] - 48) * factor[i]) % 11;
            }
            if (resultat == 0)
                return true;
            else
                return false;
        }
    }
}
