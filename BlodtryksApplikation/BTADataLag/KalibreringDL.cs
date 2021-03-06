﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments;
using NationalInstruments.DAQmx;
using DTO;
using Newtonsoft.Json;
using System.IO;


namespace BTADataLag
{
    /// <summary>
    /// Indlæser kalibreringsværdi fra DAQ'en og gemmer og henter fra kalibreringsfil
    /// </summary>
    public class KalibreringDL : IndlæsFraDAQ
    {
        /// <summary>
        /// Bruges til at opbevare kalibreringsdata i
        /// </summary>
        public KalibreringDTO KDTO { get; private set; }  

        /// <summary>
        /// Constructor der opretter en kalibreringsDTO
        /// </summary>
        public KalibreringDL()
        {
            this.KDTO = new KalibreringDTO();
        }

        /// <summary>
        /// Kalder metode der indlæser en datasekvens
        /// </summary>
        /// <returns>
        /// Returnerer af den indlæste datasekvens
        /// </returns>
        public List<double> indlæsKalibreringsSpænding(int samples)
        {
            return ReadInput(samples);
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
