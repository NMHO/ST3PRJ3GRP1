using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTADataLag;
using DTO;

namespace BTALogikLag
{
    public class GemLL
    {
        public GemDTO GDTO { get; set; }
        private ControlDataLag currentDatalag;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mydal"></param>
        public GemLL(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
            this.GDTO = currentDatalag.GDL.GDTO;
        }

        /// <summary>
        /// Validerer CPR nr
        /// </summary>
        /// <param name="CPR"></param>
        /// <returns></returns>
        public bool validerCPR(string CPR)
        {
            /*char[] CPRArray = CPR.ToCharArray();
            int resultat = 0;
            int[] factor = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

            for (int i = 0; i < CPRArray.Length; i++)
            {
                resultat = ((CPRArray[i] - 48) * factor[i]) % 11;
            }
            if (resultat == 0)
                return true;
            else
                return false;*/


            // Nedenstående virker til cpr-validering :-)

            int[] weight = { 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };

            int sum = 0;
            if (CPR.Length == 10)
            {
                for (int i = 0; i < CPR.Length; i++)
                {
                    char[] chars = CPR.ToCharArray();
                    sum += (chars[i] - 0x30) * weight[i];
                }
                int res = sum % 11;
                if (res == 0)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Validerer personalenummer
        /// </summary>
        /// <param name="pnummer"></param>
        /// <returns></returns>
        public bool validerPersonalenr(string pnummer)
        {
            char[] PnummerArray = pnummer.ToCharArray();
            if (PnummerArray.Length == 6)
            {
                return true;
            }
            else
                return false;
        }
        
        /// <summary>
        /// Kalder gem metode i GDL
        /// </summary>
        /// <param name="GDTO_"></param>
        /// <returns></returns>
        public bool gemData(GemDTO GDTO_)
        {
            bool b = currentDatalag.GDL.gemDataTilFil(GDTO_);
            return b;
        }
        
    }
}
