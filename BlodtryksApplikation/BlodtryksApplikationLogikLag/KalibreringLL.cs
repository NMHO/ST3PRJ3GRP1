using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BlodtryksApplikationDataLag;

namespace BlodtryksApplikationLogikLag
{
    public class KalibreringLL
    {
        private KalibreringDTO KDTO;
        private KalibreringDL KDL;
        public KalibreringLL()
        {
            KDTO = new KalibreringDTO();
            KDL = new KalibreringDL();
        }

        /// <summary>
        /// Omregner den indlæste kalibreringsværdi fra spænding i volt til tryk i mmHg
        /// </summary>
        /// <param name="kalNr"></param>
        /// <returns></returns>
        public bool opdaterKalibreringsData(double kalTryk, int kalNr)
        {
            if (kalNr == 1 &&  kalTryk > 0 && kalTryk < 250)
            {
                KDTO.kalibreringsTrykNr1 = kalTryk;
                KDTO.kalibreringsSpændingNr2 = KDL.indlæsKalibreringsSpænding();
            }
            else if (kalNr == 2 && kalTryk > 0 && kalTryk < 250)
            {
                KDTO.kalibreringsTrykNr2 = kalTryk;
                KDTO.kalibreringsSpændingNr2 = KDL.indlæsKalibreringsSpænding();
            }
            else
            {
                return false;
            }
            return true;
        }





    }
}
