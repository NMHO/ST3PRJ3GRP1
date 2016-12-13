using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;
using BTADataLag;

namespace BTALogikLag
{
    /// <summary>
    /// Kontrolklasse for LogikLag
    /// </summary>
    public class ControlLogikLag
    {
        private ControlDataLag currentDatalag;
        /// <summary>
        /// Property for Kalibrerings-klasse
        /// </summary>
        public KalibreringLL KLL { get; private set; }
        /// <summary>
        /// Property for Nulpunktsjusterings-klasse
        /// </summary>
        public NulpunktsjusteringLL NPJLL { get; private set; }
        /// <summary>
        /// Property for Gem-klasse
        /// </summary>
        public GemLL GLL { get; private set; }
        /// <summary>
        /// Property for Monitorerings-klasse
        /// </summary>
        public MonitoreringLL MLL { get; private set; }

        /// <summary>
        /// Constructor der initialiserer Logiklaget
        /// </summary>
        /// <param name="mydal">Modtager kontrolklassen for datalag som parameter</param>
        public ControlLogikLag(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
            KLL = new KalibreringLL(currentDatalag);
            NPJLL = new NulpunktsjusteringLL(currentDatalag);
            MLL = new MonitoreringLL(currentDatalag);
            GLL = new GemLL(currentDatalag);
            
         }        
    }
}
