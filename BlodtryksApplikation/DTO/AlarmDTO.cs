using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AlarmDTO
    {
        public int ØGrænse { get; set; }
        public int NGrænse { get; set; }

        public AlarmDTO()
        {
            ØGrænse = 0;
            NGrænse = 0;
        }

    }
}
