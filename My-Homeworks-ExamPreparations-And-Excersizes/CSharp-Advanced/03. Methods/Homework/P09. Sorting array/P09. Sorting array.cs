/*
Sorting array
Description

Write a method that returns the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order. Write a program that sorts a given array.

Input

On the first line you will receive the number N - the size of the array
On the second line you will receive N numbers separated by spaces - the array
Output

Print the sorted array
Elements must be separated by spaces
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
6
3 4 1 5 2 6	
1 2 3 4 5 6
10
36 10 1 34 28 38 31 27 30 20	
1 10 20 27 28 30 31 34 36 38
Submission

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.Sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<int> nums = ReadInLineArray();
            nums.Sort();                

            Console.WriteLine(string.Join(" ", nums));
        }

        static List<int> ReadInLineArray()
        {
            string inLine = Console.ReadLine();
            //string inLine = "3 4 1 5 2 6";

            char[] delimiters = new char[] { ' ', ',' };
            List<int> nums = inLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(d => int.Parse(d)).ToList();

            return nums;
        }
    }
}
