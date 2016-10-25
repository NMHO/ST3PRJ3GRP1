using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BlodtryksApplikationDataLag;

namespace BlodtryksApplikationLogikLag
{
    /// <summary>
    /// Håndterer, beregner og opdaterer kalibreringsdata
    /// </summary>
    public class KalibreringLL
    {
        private KalibreringDTO KDTO;
        private KalibreringDL KDL;

        /// <summary>
        /// Constructor der modtager en reference til kalibreringsDTO'en oprettet i BTA-hovedvinduet
        /// </summary>
        /// <param name="KDTO">Bruges til at opbevare kalibreringsdata i</param>
        public KalibreringLL(ref KalibreringDTO KDTO)
        {
            this.KDTO = KDTO;
            KDL = new KalibreringDL(ref KDTO);
        }

        /// <summary>
        /// Opdaterer DTO'en med den det indtastede kalibreringstryk og den indlæste spændingsværdi fra DAQ'en
        /// Gemmer når programflow kalibrering 2 er udført
        /// </summary>
        /// <param name="kalTryk">Det indtastede kalibreringstryk i mmHg i kalibreringsvinduet</param>
        /// <param name="kalNr">Nummeret på igangværende kalibrering. 1 eller 2</param>
        /// <returns>
        /// Returnerer bool-værdi om indtastet data er godkendte
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
        /// <remarks>
        /// Beregne hældningen for følsomheden y = a*x .. a = (y2 - y1) / (x2 - x1)
        /// </remarks>
        /// <returns>
        /// Returnerer bool-værdi om udregningen kunne lade sig gøre
        /// </returns>
        public bool beregnKalibreringsHældning()
        {            
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
            KDL.gemKalibreringTilFil(KDTO);
        }

        /// <summary>
        /// Kalder metode der henter de indlæste kalibreringsdata fra datalaget
        /// </summary>
        /// <returns>
        /// Returnerer en KalibreringDTO med de indlæste kalibreringsdata
        /// </returns>
        public KalibreringDTO hentKalibreringFraDL()
        {            
            KDTO = KDL.hentKalibreringFraFil();
            return KDTO;
        }

    }
}
