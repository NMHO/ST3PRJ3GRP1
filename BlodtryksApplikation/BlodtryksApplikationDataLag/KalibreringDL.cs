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
    /// <summary>
    /// Indlæser kalibreringsværdi fra DAQ'en og gemmer og henter fra kalibreringsfil
    /// </summary>
    public class KalibreringDL
    {
        private KalibreringDTO KDTO;

        /// <summary>
        /// Constructor der modtager en reference til kalibreringsDTO'en oprettet i BTA-hovedvinduet
        /// </summary>
        /// <param name="KDTO">Bruges til at opbevare kalibreringsdata i</param>
        public KalibreringDL(ref KalibreringDTO KDTO)
        {
            this.KDTO = KDTO;
        }

        /// <summary>
        /// Indlæser en enkelt sample fra NI-DAQ i volt
        /// </summary>
        /// <returns>
        /// Returnerer den indlæste spænding
        /// </returns>
        public double indlæsKalibreringsSpænding()
        {
            NationalInstruments.DAQmx.Task analogInTask = new NationalInstruments.DAQmx.Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel("Dev1/ai0", "myAIChannel",
                AITerminalConfiguration.Differential, 0, 5, AIVoltageUnits.Volts);

            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);

            return reader.ReadSingleSample();
        }

        /// <summary>
        /// Gemmer kalibreringsdata til json-kalibreringsfil
        /// </summary>
        /// <param name="KDTO">Bruges til at opbevare kalibreringsdata i</param>
        public void gemKalibreringTilFil(KalibreringDTO KDTO)
        {
            string json = JsonConvert.SerializeObject(KDTO);

            string path = Environment.CurrentDirectory + @"\AppData\Kalibrering.json";

            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Henter kalibreringsdata fra json-kalibreringsfil
        /// </summary>
        /// <returns>
        /// Returnerer en KalibreringDTO med de indlæste kalibreringsdata
        /// </returns>
        public KalibreringDTO hentKalibreringFraFil()
        {
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
