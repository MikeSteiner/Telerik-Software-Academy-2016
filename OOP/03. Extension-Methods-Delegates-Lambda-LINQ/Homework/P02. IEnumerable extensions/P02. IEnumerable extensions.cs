/*
Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
 */
 

namespace StartingPointNs
{
    using System;
    using System.Collections.Generic;
    using ExtensionsNs;

    public class StartingPoint
    {
        static void Main(string[] args)
        {
            List<double> listForTest = new List<double>{2.0, 3.5, 5.0, 6.0, 7.0, 9.0, 11.0, 13.7 };
            decimal sum = listForTest.Sum();
            Console.WriteLine("Sum {0}", sum);

            double min = listForTest.Min();
            Console.WriteLine("Min {0}",  min);

            double max = listForTest.Max();
            Console.WriteLine("Max {0}", max);

            decimal product = listForTest.Product();
            Console.WriteLine("Product {0}", product);

            double average = listForTest.Average();
            Console.WriteLine("Average {0}", average);
        }
    }
}
