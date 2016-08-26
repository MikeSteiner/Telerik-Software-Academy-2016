/*
 * 
Maximal sum
Description

Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

Can you do it with only one loop (with single scan through the elements of the array)?
Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the maximal sum of consecutive numbers
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
10
2
3
-6
-1
2
-1
6
4
-8
8	
----
11
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.Maximal_sum
{
    class Program
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


            //Find max sum
            int startIx = 0;
            int maxSumLenght = 0;
            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum += nums[i];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxSumLenght++;
                }
                else if(currentSum < 0)
                {
                    startIx = i + 1;
                    currentSum = 0;
                }
            }


            //Print out
            //Console.WriteLine(new string('-', 10));
            for (int i = startIx; i < startIx + maxSumLenght; i++)
            {
                //Console.WriteLine(nums[i]);
            }

            Console.WriteLine(maxSum);
        }
    }
}
