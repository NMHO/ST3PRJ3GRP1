using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BTADataLag;
using System.Threading;

namespace BTALogikLag
{
    public class MonitoreringLL
    {
        public MonitorerDTO MDTO { get; set; }
        private ControlDataLag currentDatalag;

        public MonitoreringLL(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
            this.MDTO = currentDatalag.MDL.MDTO;
        }

        public void hentBTSekvens()
        {
            MDTO.NuværendeSekvens = currentDatalag.MDL.indlæsBTSignal(100);

            MDTO.RåBlodtrykssignal.AddRange(MDTO.NuværendeSekvens);
            MDTO.SignalLængdeISek = Convert.ToDouble(MDTO.RåBlodtrykssignal.Count()) / 1000.0;
            Thread.Sleep(100); // simulerer DAQ-indlæsning              
        }

    }
}
