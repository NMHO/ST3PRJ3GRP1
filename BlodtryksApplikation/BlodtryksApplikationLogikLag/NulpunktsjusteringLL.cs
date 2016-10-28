using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlodtryksApplikationDataLag;

namespace BlodtryksApplikationLogikLag
{
    /// <summary>
    /// Klasse der henter den indlæste nulpunktsspændings fra datalaget
    /// </summary>
    public class NulpunktsjusteringLL
    {
        private double NulpunktsVærdi;
        private NulpunktsjusteringDL NPJDL;

        /// <summary>
        /// Constructor
        /// </summary>
        public NulpunktsjusteringLL()
        {       
            NPJDL = new NulpunktsjusteringDL();
            NulpunktsVærdi = 0;
        }
        /// <summary>
        /// Henter den indlæste nulpunktsspændings fra datalaget
        /// </summary>
        /// <returns>
        /// Returnerer den indlæste nulpunktsspændings
        /// </returns>
        public double hentNulpunktsSpænding()
        {
            NulpunktsVærdi = NPJDL.indlæsNulpunktsSpænding();
            return NulpunktsVærdi;
        }
    }
}
