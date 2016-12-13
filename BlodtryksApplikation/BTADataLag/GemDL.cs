using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json;
using System.IO;

namespace BTADataLag
{
    /// <summary>
    /// Gem-klasse i Datalaget
    /// </summary>
    public class GemDL
    {
        /// <summary>
        /// DTO for gem-funktionalitet
        /// </summary>
        public GemDTO GDTO { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public GemDL()
        {
            this.GDTO = new GemDTO();
        }

        /// <summary>
        /// Gemmer valgt data i fil
        /// </summary>
        /// <param name="GDTO"></param>
        /// <returns></returns>
        public bool gemDataTilFil(GemDTO GDTO)
        {
            try
            {
                string json = JsonConvert.SerializeObject(GDTO);
                string path = Environment.CurrentDirectory +
                    @"\AppData\" + GDTO.CPR + " - " + string.Format("{0:yyyy-MM-dd_HH-mm-ss}.json", GDTO.Dato);
                File.WriteAllText(path, json);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}