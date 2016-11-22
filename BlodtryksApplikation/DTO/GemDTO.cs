using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GemDTO
    {
        public string CRP { get; set; }
        public string Personalenummer { get; set; }

        public GemDTO()
        {
            CRP = "0000000000";
            Personalenummer = "XXX000";
        }
    }
}
