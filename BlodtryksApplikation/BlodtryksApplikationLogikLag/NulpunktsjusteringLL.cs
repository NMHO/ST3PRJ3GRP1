using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlodtryksApplikationDataLag;

namespace BlodtryksApplikationLogikLag
{
    /// <summary>
    /// Håndterer værdien
    /// </summary>
    public class NulpunktsjusteringLL
    {
        private double NulpunktsVærdi;
        private NulpunktsjusteringDL NPJDL;
        /// <summary>
        /// constructor
        /// </summary>
        public NulpunktsjusteringLL()
        {       
           NPJDL = new NulpunktsjusteringDL();
        }
        /// <summary>
        /// Henter spændingen fra datalaget
        /// </summary>
        /// <returns>
        /// returnerer nulpunktsværdien
        /// </returns>
        public double hentNulpunktsSpænding()
        {
            NulpunktsVærdi = NPJDL.indlæsNulpunktsSpænding();
            return NulpunktsVærdi;
        }
    }
}
