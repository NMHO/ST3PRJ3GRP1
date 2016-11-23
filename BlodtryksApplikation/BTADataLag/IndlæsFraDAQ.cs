using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;
using Interfaces;


namespace BTADataLag
{    

    /// <summary>
    /// Abstrakt klasse til indlæsning fra DAQ
    /// </summary>
    public abstract class IndlæsFraDAQ : IReadInput
    {

        //private NI_DAQVoltage datacollector;      

        
        private NationalInstruments.DAQmx.Task analogInTask;
        private AnalogSingleChannelReader reader;
        private int samplesPerChannel = 100;



        public IndlæsFraDAQ()
        {
            /*
            datacollector = new NI_DAQVoltage();
            datacollector.sampleRateInHz = 1000;
            datacollector.deviceName = "Dev1/ai0";
            datacollector.samplesPerChannel = 100;*/


            analogInTask = new NationalInstruments.DAQmx.Task();

            analogInTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "myAIChannel", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

            analogInTask.Timing.ConfigureSampleClock("", 1000, SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, samplesPerChannel);

            reader = new AnalogSingleChannelReader(analogInTask.Stream);

        }


        /// <summary>
        /// Indlæser en serie af samples fra NI-DAQ i volt
        /// </summary>
        /// <param name="samples">Antal ønsket datapunkter</param>
        /// <returns>Returnerer en liste af datapunkter</returns>  
        public List<double> ReadInput(int samples)
        {
            
            var seqList = new List<double>(reader.ReadMultiSample(samples));

            //analogInTask.Dispose();

            return seqList;

            //return null;

            //return testUdenDAQ();

            //datacollector.samplesPerChannel = samples;     

            //datacollector.getVoltageSeqBlocking();

            //return datacollector.currentVoltageSeq;
        }


        /*
        static Random rnd = new Random();
        private List<double> testUdenDAQ()
        {
            List<double> lst = new List<double>(100);

            for (int i = 0; i < 100; i++)
            {
                lst.Add(rnd.Next(0, 5));
            }
            return lst;
        }*/
    }
}
