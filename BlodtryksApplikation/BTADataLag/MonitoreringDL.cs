using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BTADataLag
{
    /// <summary>
    /// Indlæser datasekvenser fra DAQ'en
    /// </summary>
    public class MonitoreringDL : IndlæsFraDAQ
    {
        /// <summary>
        /// Opretter en ny monitorerings DTO
        /// </summary>
        public MonitoreringDL()
        {
           
        }

        /// <summary>
        /// Kalder metode der indlæser en datasekvens
        /// </summary>
        /// <returns>
        /// Returnerer af den indlæste datasekvens
        /// </returns>
        public List<double> indlæsBTSignal(int samples)
        {
            return ReadInput(samples);
        }
    }
}
