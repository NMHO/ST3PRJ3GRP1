using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTAPræsentationsLag;
using BTALogikLag;
using BTADataLag;

namespace BlodtryksApplikation
{
    class Program
    {
        private ControlPræsentationsLag currentPL;
        private ControlLogikLag currentLL;
        private ControlDataLag currentDL;

        
        static void Main(string[] args)
        {            
            Program currentApp = new Program();
        }

        public Program()
        {
            //Dependensy injektion
            currentDL = new ControlDataLag();
            currentLL = new ControlLogikLag(currentDL);
            currentPL = new ControlPræsentationsLag(currentLL);
            currentPL.startGUI();
        }
    }
}
