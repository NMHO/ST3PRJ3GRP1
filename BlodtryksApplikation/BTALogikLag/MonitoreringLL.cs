﻿using System;
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
    public class MonitoreringLL : Subject, IObserverLL
    {
        private MonitorerDTO MDTO;
        private ControlDataLag currentDatalag;
        public FilterLL FLL;
        public int framesize { get; set; }
        private SemaphoreSlim sem;

        public MonitoreringLL(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
            FLL = new FilterLL(currentDatalag);
            framesize = 0;
            sem = new SemaphoreSlim(1);
        }

        public void startMåling()
        {
            currentDatalag.MDL.Attach(this);
            currentDatalag.MDL.startInputAsync(100);
        }

        public void stopMåling()
        {
            currentDatalag.MDL.Detach(this);
            currentDatalag.MDL.stoptInputAsync();
        }

        public void hentBTSekvens(double KHældning, double NVærdi)
        {

            var råtSignal = MDTO.NuværendeSekvens;
            
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

        public void Update(List<double> sekvens)
        {
            MDTO.NuværendeSekvens = sekvens;
            Notify();
        }
    }

    abstract public class Subject
    {
        private List<IObserverPL> observers = new List<IObserverPL>();

        public void Attach(IObserverPL observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserverPL observer)
        {
            observers.Remove(observer);
        }

        public void Notify(/*List<double> sekvens*/)
        {
            foreach (var observer in observers)
            {
                observer.Update();//sekvens);
            }
        }
    }
}
