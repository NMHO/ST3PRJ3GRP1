using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// Indeholder to tal for alarmens øvre og nedre grænse
    /// </summary>
    public class AlarmDTO
    {
        /// <summary>
        /// Øvre grænse for alarmen
        /// </summary>
        public int ØGrænse {get; set; }   

        /// <summary>
        /// Nedre grænse for alarmen
        /// </summary>
        public int NGrænse { get; set; }


        public  AlarmDTO()
        {
            ØGrænse = 250;
            NGrænse = 0;
        }

    }
}
