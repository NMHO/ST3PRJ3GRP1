using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;
using Newtonsoft.Json;
using System.IO;

namespace BlodtryksApplikationDataLag
{
    /// <summary>
    /// Indlæser værdi fra DAQ'en
    /// </summary>
    public class NulpunktsjusteringDL
    {
        private double NulpunktsVærdi;
 
        /// <summary>
        /// Constructor
        /// </summary>
        public NulpunktsjusteringDL()
        {
           
        }

        /// <summary>
        /// Indlæser en enkelt sample fra NI-DAQ i volt
        /// </summary>
        /// <returns>
        /// Returnerer den indlæste spænding
        /// </returns>
        public double indlæsNulpunktsSpænding()
        {

            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "myAIChannel",
                AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            return reader.ReadSingleSample();
        }
    }

   
}
