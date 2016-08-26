/*
Get largest number
Description

Write a method GetMax() with two parameters that returns the larger of two integers. 
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

Input

On the first line you will receive 3 integers separated by spaces
Output

Print the largest of them
Constraints

Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
8 3 6	8
7 19 19	19
Submission
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Get_largest_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inLine = Console.ReadLine();
            //string inLine = "8 3 6";

            char[] delimiters = new char[] { ' ', ',' };
            List<int> nums = inLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(d => int.Parse(d)).ToList();
            Console.WriteLine(FindMaxInList(nums));

        }
        static int FindMaxInList(List<int> numbers)
        {
            int maxValue = int.MinValue;

            for (int i = 1; i < numbers.Count; i++)
            {
                int currMaxValue = GetMax(numbers[i-1], numbers[i]);
                if (currMaxValue >= maxValue)
                {
                    maxValue = currMaxValue;
                }                
            }

            return maxValue;
        }

        static int GetMax(int a, int b)
        {
            int maxValue = 0;

            if (a >= b)
            {
                maxValue = a;
            }
            else
            {
                maxValue = b;
            }

            return maxValue;
        }

    }
}
