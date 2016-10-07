using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KalibreringDTO
    {
        public double kalibreringsTrykNr1 { get; set; }
        public double kalibreringsSpændingNr1 { get; set; }
        public double kalibreringsTrykNr2 { get; set; }
        public double kalibreringsSpændingNr2 { get; set; }
        public double kalibreringsHældning { get; set; }


        public KalibreringDTO()
        {
            kalibreringsTrykNr1 = 0;
            kalibreringsSpændingNr1 = 0;
            kalibreringsTrykNr2 = 0;
            kalibreringsSpændingNr2 = 0;
        }
    }
}
