using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlodtryksApplikationDataLag
{
    public interface IReadInput
    {
        List<double> ReadInput(int samples);
    }
}
