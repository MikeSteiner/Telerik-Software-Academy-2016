/*
Integer calculations
Description

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. 
Use variable number of arguments. 
Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.

Input

On the first line you will receive 5 numbers separated by spaces
Output

Print their minimum, maximum, average, sum and product
Each on a new line
The average value should be printed with two digits of precision
Constraints

Each of the five numbers will be in the interval [ -1000, 1000 ]
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	
3 7 9 18 0 
Output
0
18
7.40
37
0

 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P14_IntegerCalculations
{
    class Program
    {
        enum ToReturn
        {
            Avg,
            Sum
        };

        static void Main(string[] args)
        {
            string inLine = Console.ReadLine();
            List<int> nums = ReadInLineArray(inLine);

            Console.WriteLine("{0}", GetMin(nums));         //min               
            Console.WriteLine("{0}", GetMax(nums));         //max
            Console.WriteLine("{0:#0.00}", GetAvgSum(nums, ToReturn.Avg)); //avg
            Console.WriteLine("{0:#0}", GetAvgSum(nums, ToReturn.Sum));    //sum
            Console.WriteLine("{0}", GetProduct(nums));     //prod


        }

        static List<int> ReadInLineArray(string inLine)
        {
            char[] delimiters = new char[] { ' ', ',' };
            List<int> nums = inLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(d => int.Parse(d)).ToList();

            return nums;
        }

        //minimum, maximum, average, sum and product.

        static int GetMax(List<int> array)
        {
            int maxValue = int.MinValue;


            for (int i = 0; i < array.Count; i++)
            {
                int currValue = array[i];
                if (currValue > maxValue)
                {
                    maxValue = currValue;
                }
            }

            return maxValue;
        }

        static int GetMin(List<int> array)
        {
            int minValue = int.MaxValue;


            for (int i = 0; i < array.Count; i++)
            {
                int currValue = array[i];
                if (currValue < minValue)
                {
                    minValue = currValue;
                }
            }

            return minValue;
        }

        static double GetAvgSum(List<int> array, ToReturn Rtrn)
        {
            double sum = 0.0d;
            double avg = 0.0d;


            for (int i = 0; i < array.Count; i++)
            {
                int currValue = array[i];
                sum += currValue;
            }
            avg = sum / (double)array.Count;

            //Return options
            if (Rtrn == ToReturn.Avg)
            {
                return avg;
            }            
            return sum;                       
        }

        static BigInteger GetProduct(List<int> array)
        {
            BigInteger productValue = 1;

            for (int i = 0; i < array.Count; i++)
            {
                int currValue = array[i];
                productValue *= currValue;
            }

            return productValue;
        }


    }
}
