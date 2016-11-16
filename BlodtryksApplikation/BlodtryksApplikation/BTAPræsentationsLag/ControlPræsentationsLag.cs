using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using BTALogikLag;
using DTO;

namespace BTAPræsentationsLag
{
    public class ControlPræsentationsLag : PL
    {
        private ControlLogikLag currentLL;
        public BTAHovedvindue BTAHovedvindue { get; private set; }

        public ControlPræsentationsLag(ControlLogikLag myLL)
        {
            currentLL = myLL;   
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]    
        public void startGUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            BTAHovedvindue = new BTAHovedvindue(currentLL);
            Application.Run(BTAHovedvindue);
        }
    }
}
