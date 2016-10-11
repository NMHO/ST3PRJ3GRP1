using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;
using DTO;
//using ST2Prj2LibNI_DAQ;

namespace BlodtryksApplikationDataLag
{
    public class KalibreringDL
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

        private KalibreringDTO KDTO;

        public KalibreringDL()
        {
            KDTO = new KalibreringDTO();
        }

        /// <summary>
        /// Indlæser en enkelt sample fra NI-DAQ i volt
        /// </summary>
        /// <returns></returns>
        public double indlæsKalibreringsSpænding()
        {
            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("dev1/ai0", "myAIChannel",
                AITerminalConfiguration.Differential, 0, 10, AIVoltageUnits.Volts);

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            return reader.ReadSingleSample();
        }

        public void gemKalibreringTilFil(KalibreringDTO KDTO)
        {
            // metode der gemmer kalibreringsdata til json-fil
        }

        public KalibreringDTO hentKalibreringFraFil()
        {
            // Metode der henter kalibreringsdata fra json-fil
            return null;
        }
    }
}
