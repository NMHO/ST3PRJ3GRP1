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
        public List<double> NuværendeSekvens { get; set; }
        public double sampleFrekvens { get; set; }
        public double SignalLængdeISek { get; set; }

        public MonitorerDTO()
        {
            RåBlodtrykssignal = new List<double>();
            NuværendeSekvens = new List<double>();
            SignalLængdeISek = 0;
            sampleFrekvens = 1000;
        }
    }
}
