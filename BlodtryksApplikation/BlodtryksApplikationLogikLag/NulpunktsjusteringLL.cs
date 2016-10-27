using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlodtryksApplikationDataLag;

namespace BlodtryksApplikationLogikLag
{
    /// <summary>
    /// 
    /// </summary>
    public class NulpunktsjusteringLL
    {
        private double NulpunktsVærdi;
        private NulpunktsjusteringDL NPJDL;
        /// <summary>
        /// 
        /// </summary>
        public NulpunktsjusteringLL()
        {       
            NPJDL = new NulpunktsjusteringDL();
            NulpunktsVærdi = 0;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double hentNulpunktsSpænding()
        {
            NulpunktsVærdi = NPJDL.indlæsNulpunktsSpænding();
            return NulpunktsVærdi;
        }
    }
}
