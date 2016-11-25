﻿using System;
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

        
        

        public int samples { get; set; }
        public NationalInstruments.DAQmx.Task analogInTask { get; set; }
        public AnalogSingleChannelReader reader { get; set; }       


        public IndlæsFraDAQ()
        {            
            
        }

        public void indstilDAQ()
        {
            analogInTask = new NationalInstruments.DAQmx.Task();

            analogInTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "myAIChannel", AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

            analogInTask.Timing.ConfigureSampleClock("", 1000, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, samples);

            analogInTask.Control(TaskAction.Verify);            

            reader = new AnalogSingleChannelReader(analogInTask.Stream);
        }       

        /// <summary>
        /// Indlæser en serie af samples fra NI-DAQ i volt
        /// </summary>
        /// <param name="samples">Antal ønsket datapunkter</param>
        /// <returns>Returnerer en liste af datapunkter</returns>  
        public List<double> ReadInput(int samples)
        {
            indstilDAQ();

            var seqList = new List<double>(reader.ReadMultiSample(samples));

            analogInTask.Dispose();

            return seqList;

            //return testUdenDAQ();
            
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
