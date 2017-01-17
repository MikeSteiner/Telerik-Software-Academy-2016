/*
 *Appearance count
Description

Write a method that counts how many times given number appears in a given array. 
Write a test program to check if the method is working correctly.

Input

On the first line you will receive a number N - the size of the array
On the second line you will receive N numbers separated by spaces - the numbers in the array
On the third line you will receive a number X
Output

Print how many times the number X appears in the array
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
8
28 6 21 6 -7856 73 73 -56
73	2
Submission 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Appearance_count
{
    class Program
    {
        static void Main(string[] args)
        {
            int name = int.Parse(Console.ReadLine());
            List<int> nums = ReadInLineArray();
            int elementToCount = int.Parse(Console.ReadLine());

            Console.WriteLine(AppearanceCount(nums, elementToCount));
        }
        
        static List<int> ReadInLineArray()
        {
            string inLine = Console.ReadLine();
            //string inLine = "28 6 21 6 -7856 73 73 -56";

            char[] delimiters = new char[] { ' ', ',' };
            List<int> nums = inLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(d => int.Parse(d)).ToList();

            return nums;
        }

        static int AppearanceCount(List<int> nums, int element)
        {
            int counter = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == element)
                {
                    counter++;
                }
            }

            return counter;
        }
    }

}
