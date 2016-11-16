using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTADataLag;

namespace BTALogikLag
{
    /// <summary>
    /// Klasse der henter den indlæste nulpunktsspændings fra datalaget
    /// </summary>
    public class NulpunktsjusteringLL
    {
        private double NulpunktsVærdi;
        
        private ControlDataLag currentDatalag;

        /// <summary>
        /// Constructor
        /// </summary>
        public NulpunktsjusteringLL(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
        }

        /// <summary>
        /// Henter den indlæste nulpunktsspændings fra datalaget
        /// </summary>
        /// <returns>
        /// Returnerer den indlæste nulpunktsspændings
        /// </returns>
        public double hentNulpunktsSpænding()
        {
            NulpunktsVærdi = currentDatalag.NPJDL.indlæsNulpunktsSpænding(100).Average();
            return NulpunktsVærdi;
        }
    }
}
