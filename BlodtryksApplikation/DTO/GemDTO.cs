using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GemDTO
    {
        public string CPR { get; set; }
        public string Personalenummer { get; set; }
        public string SignalLængde { get; set; }
        public double SamplingsfrekvensIHz { get; set; }
        public DateTime Dato { get; set; }
        public byte[] SignalBLOB { get; set; }  
            


        public GemDTO()
        {
            CPR = "0000000000";
            Personalenummer = "XXX000";
            SignalLængde = "0 s";
            SamplingsfrekvensIHz = 1000;
            Dato = new DateTime();
            SignalBLOB = null;            
        }       
    }
}
