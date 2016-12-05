﻿using System;
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
        public MonitoreringDL MDL { get; private set; }
        public GemDL GDL { get; private set; }

        /// <summary>
        /// Constructor
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
