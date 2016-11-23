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
    public class ControlLogikLag
    {
        private ControlDataLag currentDatalag;
        public KalibreringLL KLL { get; private set; }
        public NulpunktsjusteringLL NPJLL { get; private set; }
        public GemLL GLL { get; private set; }


        public MonitoreringLL MLL { get; private set; }
        

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
