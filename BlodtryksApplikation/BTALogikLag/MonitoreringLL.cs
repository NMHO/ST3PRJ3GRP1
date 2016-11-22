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
        public FilterLL FLL;
        public int framesize { get; set; }

        public MonitoreringLL(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
            FLL = new FilterLL(currentDatalag);
            framesize = 1;
        }

        public void hentBTSekvens()
        {
            var råtSignal = currentDatalag.MDL.indlæsBTSignal(100);
            MDTO.NuværendeSekvens = FLL.FiltrerSignal(framesize, midlingAfIndlæstSignal(råtSignal));
            //MDTO.NuværendeSekvens = midlingAfIndlæstSignal(currentDatalag.MDL.indlæsBTSignal(100));           
            MDTO.RåBlodtrykssignal.AddRange(råtSignal);
            MDTO.SignalLængdeISek = Convert.ToDouble(MDTO.RåBlodtrykssignal.Count()) / 1000.0;
            Thread.Sleep(100); // simulerer DAQ-indlæsning              
        }

        public void indstilRefTilDTO(ref MonitorerDTO MDTO)
        {
            this.MDTO = MDTO;
            MDTO.midlingsFrekvens = 200;
        }

        private List<double> midlingAfIndlæstSignal(List<double> nSekvens)
        {
            int tæller = 0;
            double sum = 0;
            List<double> mSekvens = new List<double>();
            foreach (var værdi in nSekvens)
            {
                tæller++;
                sum += værdi;
                if (tæller == 5)
                {
                    mSekvens.Add(sum / 5);
                    tæller = 0;
                    sum = 0;
                }
                
            }
            return mSekvens;
        }
            

    }
}
