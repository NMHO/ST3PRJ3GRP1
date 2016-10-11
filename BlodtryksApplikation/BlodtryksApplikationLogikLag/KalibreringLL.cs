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
        /// Opdaterer DTO'en med den det indtastede kalibreringstryk og den indlæste spændingsværdi fra DAQ'en
        /// </summary>
        /// <param name="kalTryk"></param>
        /// <param name="kalNr"></param>
        /// <returns>
        /// Returnere bool om indtastet data er godkendte
        /// </returns>
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

        /// <summary>
        /// Omregner den indlæste kalibreringsværdi fra spænding i volt til tryk i mmHg
        /// </summary>
        public void beregnKalibreringsHældning()
        {
            // Kode der skal beregne hældning for kalibreringen y = a*x .. a = (y2 - y1) / (x2 - x1)
        }

        /// <summary>
        /// Kalder metode der gemmer KDTO fra datalaget
        /// </summary>
        public void gemKalibrering()
        {
            // Skal kalde metode der gemmer KDTO fra datalaget
        }

        public KalibreringDTO hentKalibreringFraDL()
        {
            // Henter KDTO fra datalaget
            return null;
        }


    }
}
