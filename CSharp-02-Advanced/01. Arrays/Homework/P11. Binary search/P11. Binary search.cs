/*
Binary search
Description

Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
On the last line you will receive the number X
Output

Print the index where X is in the array
If there is more than one occurence print the first one
If there are no occurences print -1
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
10
1
2
4
8
16
31
32
64
77
99
32	

6
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];

            //Fill out array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            //Searched item
            int X = int.Parse(Console.ReadLine());
            Array.Sort(nums);

            //Find the element using binary search
            int foundIx = Array.BinarySearch(nums, X);
            if (foundIx < 0)
            {
                foundIx = -1;
            }
            //int minIx = 0;
            //int maxIx = (nums.Length - 1);
            //int index = N / 2;
            //int foundIx = (-1);

            //while (minIx <= maxIx)
            //{
            //    index = (maxIx + minIx) / 2;
            //    int currNum = nums[index];

            //    if (X > currNum)
            //    {
            //        minIx = index + 1;
            //    }
            //    else if (X < currNum)
            //    {
            //        maxIx = index + 1;
            //    }
            //    else
            //    {
            //        foundIx = index;
            //        break;
            //    }
            //}  

            //Print out
            Console.WriteLine(foundIx);
                 
        }
    }
}
