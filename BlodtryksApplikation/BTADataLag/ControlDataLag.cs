using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace BTADataLag
{
    /// <summary>
    /// Kontrolklasse for DataLag
    /// </summary>
    public class ControlDataLag
    {
        /// <summary>
        /// Property for Kalibrerings-klasse
        /// </summary>
        public KalibreringDL KDL { get; private set; }
        /// <summary>
        /// Property for Nulpunktsjusterings-klasse
        /// </summary>
        public NulpunktsjusteringDL NPJDL { get; private set; }
        /// <summary>
        /// Property for Monitorerings-klasse
        /// </summary>
        public MonitoreringDL MDL { get; private set; }
        /// <summary>
        /// Property for Gem-klasse
        /// </summary>
        public GemDL GDL { get; private set; }

        /// <summary>
        /// Constructor der initialiserer Datalaget
        /// </summary>
        public ControlDataLag()
        {
            KDL = new KalibreringDL();
            NPJDL = new NulpunktsjusteringDL();
            MDL = new MonitoreringDL();
            GDL = new GemDL();
        }        
        
    }
}
