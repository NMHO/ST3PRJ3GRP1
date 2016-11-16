using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using DTO;

namespace BTADataLag
{
    public class ControlDataLag
    {
        public KalibreringDL KDL { get; private set; }
        public NulpunktsjusteringDL NPJDL { get; private set; }
        public ControlDataLag()
        {
            KDL = new KalibreringDL();
            NPJDL = new NulpunktsjusteringDL();
        }        
        
    }
}
