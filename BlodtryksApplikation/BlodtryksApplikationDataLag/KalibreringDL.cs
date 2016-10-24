using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;
using DTO;
using Newtonsoft.Json;
using System.IO;
namespace BlodtryksApplikationDataLag
{
    public class KalibreringDL
    {
        private KalibreringDTO KDTO;

        public KalibreringDL(ref KalibreringDTO KDTO)
        {
            this.KDTO = KDTO;
        }

        /// <summary>
        /// Indlæser en enkelt sample fra NI-DAQ i volt
        /// </summary>
        /// <returns></returns>
        public double indlæsKalibreringsSpænding()
        {
            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "myAIChannel",
                AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            return reader.ReadSingleSample();
        }

        public void gemKalibreringTilFil(KalibreringDTO KDTO)
        {
            // metode der gemmer kalibreringsdata til json-fil
            string json = JsonConvert.SerializeObject(KDTO);

            string path = Environment.CurrentDirectory + @"\AppData\Kalibrering.json";

            File.WriteAllText(path, json);
        }

        public KalibreringDTO hentKalibreringFraFil()
        {
            // Metode der henter kalibreringsdata fra json-fil
            // budIndlæst = JsonConvert.DeserializeObject<PPT>(File.ReadAllText(@"c:\temp\bud.json"));
            try
            {
                string path = Environment.CurrentDirectory + @"\AppData\Kalibrering.json";

                KDTO = JsonConvert.DeserializeObject<KalibreringDTO>(File.ReadAllText(path));
                return KDTO;
            }
            catch (Exception)
            {
                return null;          
            }          
        }
    }
}
