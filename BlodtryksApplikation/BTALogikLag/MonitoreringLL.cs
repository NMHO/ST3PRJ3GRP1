using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BTADataLag;
using System.Threading;
using Interfaces;

namespace BTALogikLag
{
    /// <summary>
    /// Henter og håndterer data fra datalaget i forbindelse med monitorering
    /// </summary>
    public class MonitoreringLL : Subject, IObserverLL
    {
        private MonitorerDTO MDTO;
        private ControlDataLag currentDatalag;
        public FilterLL FLL;
        public int framesize { get; set; }
        private SemaphoreSlim sem;

        /// <summary>
        /// Constructor der modtager en reference til datalaget. Sætter framesize til 0.
        /// </summary>
        /// <param name="mydal"></param>
        public MonitoreringLL(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
            FLL = new FilterLL(currentDatalag);
            framesize = 0;
            sem = new SemaphoreSlim(1);
        }

        /// <summary>
        /// Attach'er klassen til MDL og kalder asynkront kald i datalaget med 100 samples.
        /// </summary>
        public void startMåling()
        {
            currentDatalag.MDL.Attach(this);
            currentDatalag.MDL.startInputAsync(100);
        }

        /// <summary>
        /// Detach'er klassen fra MDL og stopper asynkront kald.
        /// </summary>
        public void stopMåling()
        {
            currentDatalag.MDL.Detach(this);
            currentDatalag.MDL.stoptInputAsync();
        }

        /// <summary>
        /// Henter nuværende sekvens fra MDTO og ganger kalibreringshældningen på, og trækker nulpunktsjusteringen fra. 
        /// Herefter sættes den nuværende sekvens i MDTO igen, afhængigt af framesize.
        /// </summary>
        /// <param name="KHældning"></param>
        /// <param name="NVærdi"></param>
        public void hentBTSekvens(double KHældning, double NVærdi)
        {

            var råtSignal = MDTO.NuværendeSekvens;


            if (råtSignal.Average() > 5)
            {
                for (int i = 0; i < råtSignal.Count; i++)
                {
                    råtSignal[i] = 5;
                }
            }

            double temp;

            for (int i = 0; i < råtSignal.Count; i++)
            {
                temp = (råtSignal[i] * KHældning) - NVærdi;
                råtSignal[i] = temp;
            }

            
            

            if (framesize > 1)
            {
                sem.Wait();
                MDTO.NuværendeSekvens = FLL.FiltrerSignal(framesize, midlingAfIndlæstSignal(råtSignal));
            }
            else
            {
                sem.Wait();
                MDTO.NuværendeSekvens = midlingAfIndlæstSignal(råtSignal);
            }         
            MDTO.RåBlodtrykssignal.AddRange(råtSignal);
            MDTO.SignalLængdeISek = Convert.ToDouble(MDTO.RåBlodtrykssignal.Count()) / 1000.0;

            sem.Release();
        }

        /// <summary>
        /// Opretter en reference til MDTO
        /// </summary>
        /// <param name="MDTO"></param>
        public void indstilRefTilDTO(ref MonitorerDTO MDTO)
        {
            this.MDTO = MDTO;
            MDTO.midlingsFrekvens = 200;
        }

        /// <summary>
        /// Midler indlæst signal, således at der tages et gennemsnit af 5 værdier. 
        /// </summary>
        /// <param name="nSekvens"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Sætter den nuværende sekvens i MDTO lig med indlæst sekvens fra DAQ. Herefter kaldes Notify, som også ligger i MLL.
        /// </summary>
        /// <param name="sekvens"></param>
        public void Update(List<double> sekvens)
        {
            MDTO.NuværendeSekvens = sekvens;
            Notify();
        }
    }

    /// <summary>
    /// Abstrakt subjekt-klasse som MLL arver fra. Bruges til observer-pattern.
    /// </summary>
    abstract public class Subject
    {
        private List<IObserverPL> observers = new List<IObserverPL>();

        /// <summary>
        /// Attach'er alle oberservers til subjekt
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(IObserverPL observer)
        {
            observers.Add(observer);
        }

        /// <summary>
        /// Detach'er alle observers fra subjekt
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(IObserverPL observer)
        {
            observers.Remove(observer);
        }

        /// <summary>
        /// Kalder Update i alle attach'ede observerklasser
        /// </summary>
        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }
}
