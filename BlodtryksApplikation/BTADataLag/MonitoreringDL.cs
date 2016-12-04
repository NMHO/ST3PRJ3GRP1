using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;
using NationalInstruments.DAQmx;

namespace BTADataLag
{
    /// <summary>
    /// Indlæser datasekvenser fra DAQ'en
    /// </summary>
    public class MonitoreringDL : Subject
    {

        public AsyncCallback inputCallback { get; set; }
        public NationalInstruments.DAQmx.Task runningTask { get; set; }
        public int samples { get; set; }
        public NationalInstruments.DAQmx.Task analogInTask { get; set; }
        public AnalogSingleChannelReader reader { get; set; }
        public MonitoreringDL()
        {
            
        }
        
        /// <summary>
        /// 
        /// </summary>
        public void indstilDAQ()
        {
            analogInTask = new NationalInstruments.DAQmx.Task();

            analogInTask.AIChannels.CreateVoltageChannel("Dev2/ai0", "myAIChannel", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

            analogInTask.Timing.ConfigureSampleClock("", 1000, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, samples);

            analogInTask.Control(TaskAction.Verify);

            reader = new AnalogSingleChannelReader(analogInTask.Stream);

            reader.SynchronizeCallbacks = true;
        }


        /// <summary>
        /// Opretter en ny monitorerings DTO
        /// </summary>
        


        /// <summary>
        /// Kalder metode der indlæser en datasekvens
        /// </summary>
        /// <returns>
        /// Returnerer af den indlæste datasekvens
        /// </returns>
        //public List<double> indlæsBTSignal(int samples)
        //{
        //    this.samples = samples;
        //    return ReadInput(this.samples);
        //}


        public void startInputAsync(int samples)
        {
            this.samples = samples;

            indstilDAQ();            
            inputCallback = new AsyncCallback(InputRead);
            runningTask = analogInTask;
            reader.BeginReadMultiSample(samples, inputCallback, analogInTask);            
        }

        public void stoptInputAsync()
        {
            runningTask = null;
            analogInTask.Stop();
            analogInTask.Dispose();
        }

        private void InputRead(IAsyncResult ar)
        {
            try
            {
                if (runningTask != null && runningTask == ar.AsyncState)
                {
                    // Read the data
                    var temp = new List<double>(reader.EndReadMultiSample(ar));

                    Notify(temp);   

                    // Set up next callback
                    reader.BeginReadMultiSample(samples, inputCallback, analogInTask);
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }        

    }

    /// <summary>
    /// Abstrakt subjekt-klasse som MDL arver fra. Bruges til observer-pattern.
    /// </summary>
    abstract public class Subject
    {
        private List<IObserverLL> observers = new List<IObserverLL>();

        /// <summary>
        /// Attach'er alle oberservers til subjekt
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(IObserverLL observer)
        {
            observers.Add(observer);
        }
        /// <summary>
        /// Detach'er alle observers fra subjekt
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(IObserverLL observer)
        {
            observers.Remove(observer);
        }
        /// <summary>
        /// Kalder Update i alle attach'ede observerklasser
        /// </summary>
        /// <param name="sekvens"></param>
        public void Notify(List<double> sekvens)
        {
            foreach (var observer in observers)
            {
                observer.Update(sekvens);
            }
        }
    }


}
