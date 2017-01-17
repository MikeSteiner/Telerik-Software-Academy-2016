using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.MethPrintStat
{
    public class PrintStatistics
    {
        private double[] arrayToMaintain;

        public PrintStatistics(double[] arrayToMaintain)
        {
            this.arrayToMaintain = arrayToMaintain;
        }

        /// <summary>
        /// Gets the maximun value from the given array
        /// </summary>
        /// <param name="arrayToMaintain"></param>
        /// <returns>maximum value as double</returns>
        private double GetMaxArrayValue(double[] arrayToMaintain)
        {
            double max = double.MinValue;
            int count = arrayToMaintain.Length;

            for (int i = 0; i < count; i++)
            {
                if (arrayToMaintain[i] > max)
                {
                    max = arrayToMaintain[i];
                }
            }

            return max;
        }

        /// <summary>
        /// Gets the minimum value from the given array
        /// </summary>
        /// <param name="arrayToMaintain"></param>
        /// <returns>minimum value as double</returns>
        private double GetMinArrayValue(double[] arrayToMaintain)
        {
            double min = double.MaxValue;
            int count = arrayToMaintain.Length;

            for (int i = 0; i < count; i++)
            {
                if (arrayToMaintain[i] > min)
                {
                    min = arrayToMaintain[i];
                }
            }

            return min;
        }

        /// <summary>
        /// Gets the sum from the given array
        /// </summary>
        /// <param name="arrayToMaintain"></param>
        /// <returns>sum value as double</returns>
        private double GetSumOfArrayValues(double[] arrayToMaintain)
        {
            double sum = 0d;

            int count = arrayToMaintain.Length;

            for (int i = 0; i < count; i++)
            {
                sum += arrayToMaintain[i];
            }

            return sum;
        }

        /// <summary>
        /// Gets the average from the given array
        /// </summary>
        /// <param name="arrayToMaintain"></param>
        /// <returns>average value as double</returns>
        private double GetAverageArrayValue(double[] arrayToMaintain)
        {
            double sum = this.GetSumOfArrayValues(arrayToMaintain);
            int count = arrayToMaintain.Length;

            double avg = sum / count;

            return avg;
        }
    }
}
