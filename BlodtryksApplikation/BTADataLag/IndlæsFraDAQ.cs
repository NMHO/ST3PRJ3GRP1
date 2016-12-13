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

                analogInTask.Control(TaskAction.Verify);

                reader = new AnalogSingleChannelReader(analogInTask.Stream);
            }
            catch (Exception)
            {

                throw;
            }
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
            
        }        
    }
}
