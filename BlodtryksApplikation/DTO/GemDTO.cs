using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Gem-DTO klasse
    /// </summary>
    public class GemDTO
    {
        /// <summary>
        /// CPR-nummer
        /// </summary>
        public string CPR { get; set; }
        /// <summary>
        /// Personalenummer
        /// </summary>
        public string Personalenummer { get; set; }
        /// <summary>
        /// Signallængde i sekunder
        /// </summary>
        public string SignalLængde { get; set; }
        /// <summary>
        /// Samplingsfrekvens i Hz
        /// </summary>
        public double SamplingsfrekvensIHz { get; set; }
        /// <summary>
        /// Dato og tid for måling
        /// </summary>
        public DateTime Dato { get; set; }
        /// <summary>
        /// Det rå signal, gemt som blobformat
        /// </summary>
        public byte[] SignalBLOB { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public GemDTO()
        {
            CPR = "0000000000";
            Personalenummer = "XXX000";
            SignalLængde = "0 s";
            SamplingsfrekvensIHz = 1000;
            Dato = new DateTime();
            SignalBLOB = null;            
        }       
    }
}
