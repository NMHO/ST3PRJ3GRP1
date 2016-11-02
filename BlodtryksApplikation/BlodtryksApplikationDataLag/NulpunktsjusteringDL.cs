using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;
using Newtonsoft.Json;
using System.IO;


namespace BlodtryksApplikationDataLag
{
    /// <summary>
    /// Indlæser værdi fra DAQ'en
    /// </summary>
    public class NulpunktsjusteringDL
    {
        private IndlæsFraDAQ IFDAQ;

        /// <summary>
        /// Constructor
        /// </summary>
        public NulpunktsjusteringDL()
        {
            IFDAQ = new IndlæsFraDAQ();
        }

        /// <summary>
        /// Kalder metode der indlæser en datasekvens og beregner gennemsnittet
        /// </summary>
        /// <returns>
        /// Gennemsnittet af den indlæste datasekvens
        /// </returns>
        public double indlæsNulpunktsSpænding()
        {
            return IFDAQ.indlæsDataSekvens(100).Average();
        }
    }   
}
