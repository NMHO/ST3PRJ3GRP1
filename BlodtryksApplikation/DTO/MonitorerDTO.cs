using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Monitorerings-DTO-klasse
    /// </summary>
    public class MonitorerDTO
    {
        /// <summary>
        /// Det funde rå blodtrykssignal
        /// </summary>
        public List<double> RåBlodtrykssignal { get; set; }
        /// <summary>
        /// Signallængde i sekunder
        /// </summary>      
        public double SignalLængdeISek { get; set; }
        /// <summary>
        /// Den aktuelle indlæste sekvens, der behandles og vises i grafen i GUI'en
        /// </summary>
        public List<double> NuværendeSekvens { get; set; }
        /// <summary>
        /// Midlingsfrekvensen som det rå signal midles med før gemmes i NuværendeSekvens
        /// </summary>
        public double midlingsFrekvens { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public MonitorerDTO()
        {
            RåBlodtrykssignal = new List<double>();
            
            SignalLængdeISek = 0;

            NuværendeSekvens = new List<double>();
            midlingsFrekvens = 1000;
        }

    }
}
