using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MonitorerDTO
    {
        public List<double> RåBlodtrykssignal { get; set; }        
        public double SignalLængdeISek { get; set; }


        public List<double> NuværendeSekvens { get; set; }
        public double midlingsFrekvens { get; set; }

        public MonitorerDTO()
        {
            RåBlodtrykssignal = new List<double>();
            
            SignalLængdeISek = 0;

            NuværendeSekvens = new List<double>();
            midlingsFrekvens = 1000;
        }

    }
}
