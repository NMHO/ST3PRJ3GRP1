using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;
//using ST2Prj2LibNI_DAQ;

namespace BlodtryksApplikationDataLag
{
    public class Kalibrering
    {
        //NI_DAQVoltage datacollector;

        //public Kalibrering()
        //{
        //    datacollector = new NI_DAQVoltage();
        //}

        //public double indlæsKalibreringsVærdi()
        //{
        //    datacollector.samplesPerChannel = 10;
        //    datacollector.sampleRateInHz = 1000;
        //    datacollector.deviceName = "Dev1/ai0";
        //    datacollector.getVoltageSeqBlocking();            

        //    return datacollector.currentVoltageSeq.Average();
        //}

        public double KalibreringsVærdiIVolt { get; private set; }
        public Kalibrering()
        {
            KalibreringsVærdiIVolt = 0;
        }

        /// <summary>
        /// Indlæser en enkelt sample fra NI-DAQ i volt
        /// </summary>
        /// <returns></returns>
        private double indlæsKalibreringsVærdi()
        {
            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("dev1/ai0", "myAIChannel", 
                AITerminalConfiguration.Differential, 0, 10, AIVoltageUnits.Volts);

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            KalibreringsVærdiIVolt = reader.ReadSingleSample();

            return KalibreringsVærdiIVolt;
        }
    }
}
