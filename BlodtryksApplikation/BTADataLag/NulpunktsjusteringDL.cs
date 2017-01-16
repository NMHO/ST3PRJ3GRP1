using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;
using Newtonsoft.Json;
using System.IO;


namespace BTADataLag
{
    /// <summary>
    /// Indlæser værdi fra DAQ'en
    /// </summary>
    public class NulpunktsjusteringDL : IndlæsFraDAQ
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public NulpunktsjusteringDL()
        {            
        }

        /// <summary>
        /// Kalder metode der indlæser en datasekvens og beregner gennemsnittet
        /// </summary>
        /// <returns>
        /// Gennemsnittet af den indlæste datasekvens
        /// </returns>
        public List<double> indlæsNulpunktsSpænding(int samples)
        {
            return ReadInput(samples);
        }
    }   
}
