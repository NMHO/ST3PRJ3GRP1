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
        public KalibreringLL(ref KalibreringDTO KDTO)
        {
            this.KDTO = KDTO;
            KDL = new KalibreringDL(ref KDTO);
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
            if (kalNr == 1 && kalTryk > 0 && kalTryk < 250)
            {
                KDTO.kalibreringsTrykNr1 = kalTryk;
                KDTO.kalibreringsSpændingNr1 = KDL.indlæsKalibreringsSpænding();
            }
            else if (kalNr == 2 && kalTryk > 0 && kalTryk < 250)
            {
                KDTO.kalibreringsTrykNr2 = kalTryk;
                KDTO.kalibreringsSpændingNr2 = KDL.indlæsKalibreringsSpænding();

                bool Hældning = beregnKalibreringsHældning();

                if (Hældning != true)
                {
                    return false;
                }
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
        public bool beregnKalibreringsHældning()
        {
            // Kode der skal beregne hældning for kalibreringen y = a*x .. a = (y2 - y1) / (x2 - x1)

            if (KDTO.kalibreringsTrykNr1 < KDTO.kalibreringsTrykNr2)
            {
                KDTO.kalibreringsHældning = (KDTO.kalibreringsTrykNr2 - KDTO.kalibreringsTrykNr1) / (KDTO.kalibreringsSpændingNr2 - KDTO.kalibreringsSpændingNr1);
            }
            else if (KDTO.kalibreringsTrykNr1 > KDTO.kalibreringsTrykNr2)
            {
                KDTO.kalibreringsHældning = (KDTO.kalibreringsTrykNr1 - KDTO.kalibreringsTrykNr2) / (KDTO.kalibreringsSpændingNr1 - KDTO.kalibreringsSpændingNr2);
            }
            else
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Kalder metode der gemmer KDTO fra datalaget
        /// </summary>
        public void gemKalibrering()
        {
            // Skal kalde metode der gemmer KDTO fra datalaget
            KDL.gemKalibreringTilFil(KDTO);
        }

        public KalibreringDTO hentKalibreringFraDL()
        {
            // Skal kalde metode der henter KDTO fra datalaget
            KDTO = KDL.hentKalibreringFraFil();
            return KDTO;
        }

    }
}
