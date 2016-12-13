using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    /// <summary>
    /// AlarmDTO-klasse
    /// </summary>
    public class AlarmDTO
    {
        /// <summary>
        /// Øvre grænse
        /// </summary>
        public int ØGrænse { get; set; }
        /// <summary>
        /// Nedre grænse
        /// </summary>
        public int NGrænse { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public AlarmDTO()
        {
            ØGrænse = 0;
            NGrænse = 0;
        }

    }
}
