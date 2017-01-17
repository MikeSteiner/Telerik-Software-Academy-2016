/*
Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */
namespace ExtensionsNs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class GenericCollection
    {
        public static decimal Sum(this IEnumerable<double> collection)
        {
            decimal sum = 0.0m;
            foreach (double element in collection)
            {
                sum += (decimal)element;
            }

            return sum;
        }

        public static decimal Product(this IEnumerable<double> collection)
        {
            decimal product = 1.0m;
            foreach (double element in collection)
            {
                product *= (decimal)element;
            }

            return product;
        }

        public static double Min(this IEnumerable<double> collection)
        {
            double minValue = double.MaxValue;

            foreach (double element in collection)
            {
                bool isBestMin = (element < minValue);
                if (isBestMin)
                {
                    minValue = element;
                }
            }

            return minValue;
        }

        public static double Max(this IEnumerable<double> collection)
        {
            double maxValue = double.MinValue;

            foreach (double element in collection)
            {
                bool isBestMax = (element > maxValue);
                if (isBestMax)
                {
                    maxValue = element;
                }
            }

            return maxValue;
        }

        public static double Average(this IEnumerable<double> collection)
        {
            double avg = 0.0d;
            decimal sum = collection.Sum();

            int collectionCount = 0;
            foreach (double element in collection)
            {
                collectionCount++;
            }

            avg = (double)(sum / (decimal)collectionCount);

            return avg;
        }
    }
}

