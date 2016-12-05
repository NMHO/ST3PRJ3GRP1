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

        private AsyncCallback inputCallback;
        private NationalInstruments.DAQmx.Task runningTask;
        private int samples;
        private NationalInstruments.DAQmx.Task analogInTask;
        private AnalogSingleChannelReader reader;

        /// <summary>
        /// Indstiller DAQ til dataopsamling
        /// </summary>
        public void indstilDAQ()
        {
            try
            {
                analogInTask = new NationalInstruments.DAQmx.Task();

                analogInTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "myAIChannel", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

                analogInTask.Timing.ConfigureSampleClock("", 1000, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, 100);

                analogInTask.Control(TaskAction.Verify);

                reader = new AnalogSingleChannelReader(analogInTask.Stream);

                reader.SynchronizeCallbacks = true;
            }
            catch (Exception)
            {

                throw;
            }
        }       

        /// <summary>
        /// Starter den asynkrone indlæsning af data fra DAQ'en        
        /// </summary>
        /// <param name="samples"></param>
        public void startInputAsync(int samples)
        {
            this.samples = samples;
            indstilDAQ();            
            inputCallback = new AsyncCallback(InputRead);
            runningTask = analogInTask;
            reader.BeginReadMultiSample(samples, inputCallback, analogInTask);            
        }

        /// <summary>
        /// Stopper den asynkrone indlæsning af data fra DAQ'en
        /// </summary>
        public void stoptInputAsync()
        {
            runningTask = null;
            analogInTask.Stop();
            analogInTask.Dispose();
        }

        /// <summary>
        /// Læser data og konverterer til en liste. Kalder Notify som giver besked til de attach'ede observers
        /// </summary>
        /// <param name="ar"></param>
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
            catch (Exception)
            {
                throw;
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
