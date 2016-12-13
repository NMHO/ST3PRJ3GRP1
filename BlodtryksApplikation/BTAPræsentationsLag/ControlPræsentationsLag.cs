using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interfaces;
using BTALogikLag;
using DTO;
using System.Threading;

namespace BTAPræsentationsLag
{
    /// <summary>
    /// Kontrolklasse for præsentationslag
    /// </summary>
    public class ControlPræsentationsLag : PL
    {
        private ControlLogikLag currentLL;
        /// <summary>
        /// Property for BTAHovedvindue
        /// </summary>
        public BTAHovedvindue BTAHovedvindue { get; private set; }

        /// <summary>
        /// Constructor der initialiserer Præsentationslaget
        /// </summary>
        /// <param name="myLL">Modtager kontrolklassen for logiklag som parameter</param>
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
