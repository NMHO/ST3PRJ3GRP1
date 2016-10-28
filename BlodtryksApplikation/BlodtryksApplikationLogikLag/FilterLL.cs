using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlodtryksApplikationLogikLag
{
    class FilterLL
    {
        public List<double> FiltrerSignal(int frameSize, List<double> data)
        {

            double sum = 0;
            List<double> avgPoints = new List<double>(data.Count - frameSize + 1);
            for (int counter = 1; counter <= data.Count - frameSize; counter++)
            {
                int innerLoopCounter = 0;
                int index = counter;
                while (innerLoopCounter < frameSize)
                {
                    sum = sum + data[index];
                    innerLoopCounter += 1;
                    index += 1;
                }

                avgPoints.Add(sum / frameSize);
                sum = 0;
            }

            return avgPoints;
        }

    }
}
