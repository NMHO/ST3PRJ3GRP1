﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Newtonsoft.Json;
using System.IO;

namespace BTADataLag
{
    public class GemDL
    {
        public GemDTO GDTO { get; set; }

        public GemDL()
        {
            this.GDTO = new GemDTO();
        }
    
        public bool gemDataTilFil(GemDTO GDTO)
        {
            try
            {
                string json = JsonConvert.SerializeObject(GDTO);
                string path = Environment.CurrentDirectory + @"\AppData\Gem.json";
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
