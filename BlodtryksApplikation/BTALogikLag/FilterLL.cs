using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTADataLag;

namespace BTALogikLag
{
    public class FilterLL
    {
        private ControlDataLag currentDatalag;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="mydal"></param>
        public FilterLL(ControlDataLag mydal)
        {
            this.currentDatalag = mydal;
        }
        /// <summary>
        /// Denne metode filtrerer den liste som kommer ind med et moving avg.-filter som udglatter signalet. 
        /// </summary>
        /// <param name="frameSize">Framesize diktere opløsningen af filteret (høj frameSize = meget udglattet)</param>
        /// <param name="data">Listen med data fra DAQ'en</param>
        /// <returns></returns>
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
