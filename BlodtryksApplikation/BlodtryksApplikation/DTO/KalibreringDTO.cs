using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Kalibrerings-DTO, der indeholder properties til data
    /// </summary>
    public class KalibreringDTO
    {
        /// <summary>
        /// Det indtastede kalibreringstryk 1
        /// </summary>
        public double kalibreringsTrykNr1 { get; set; }
        /// <summary>
        /// Den indlæste kalibreringsspænding 1 ved det pågældende kalibreingstryk 1
        /// </summary>
        public double kalibreringsSpændingNr1 { get; set; }
        /// <summary>
        /// Det indtastede kalibreringstryk 2
        /// </summary>
        public double kalibreringsTrykNr2 { get; set; }
        /// <summary>
        /// Den indlæste kalibreringsspænding 2 ved det pågældende kalibreingstryk 2
        /// </summary>
        public double kalibreringsSpændingNr2 { get; set; }
        /// <summary>
        /// Den beregnede kalibreringshældning ud fra de fire andre properties
        /// </summary>
        public double kalibreringsHældning { get; set; }

        /// <summary>
        /// Constructor der sætter alle properties til 0
        /// </summary>
        public KalibreringDTO()
        {
            kalibreringsTrykNr1 = 0;
            kalibreringsSpændingNr1 = 0;
            kalibreringsTrykNr2 = 0;
            kalibreringsSpændingNr2 = 0;
        }
    }
}
