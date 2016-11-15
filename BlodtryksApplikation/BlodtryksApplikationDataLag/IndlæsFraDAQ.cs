using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;

namespace BlodtryksApplikationDataLag
{
    /// <summary>
    /// Abstrakt klasse til indlæsning fra DAQ
    /// </summary>
    public class IndlæsFraDAQ : IReadInput
    {

        /*
        /// <summary>
        /// Constructor
        /// </summary>
        public IndlæsFraDAQ()
        {
        }

        /// <summary>
        /// Indlæser en serie af samples fra NI-DAQ i volt
        /// </summary>
        /// <param name="dataSeq">Antal ønsket datapunkter</param>
        /// <returns>Returnerer en liste af datapunkter</returns>                             
        public List<double> indlæsDataSekvens(int dataSeq)
        {
            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "myAIChannel",
                AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            var seqList = new List<double>(reader.ReadMultiSample(dataSeq));

            return seqList;            
        }
        */

        /// <summary>
        /// Indlæser en serie af samples fra NI-DAQ i volt
        /// </summary>
        /// <param name="samples">Antal ønsket datapunkter</param>
        /// <returns>Returnerer en liste af datapunkter</returns>  
        public List<double> ReadInput(int samples)
        {
            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "myAIChannel",
                AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            var seqList = new List<double>(reader.ReadMultiSample(samples));

            return seqList;
        }
    }
}
