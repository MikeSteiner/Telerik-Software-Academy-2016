/*
Frequent number
Description

Write a program that finds the most frequent number in an array of N elements.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the most frequent number and how many time it is repeated
Output should be REPEATING_NUMBER (REPEATED_TIMES times)
Constraints

1 <= N <= 1024
0 <= each number in the array <= 10000
There will be only one most frequent number
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
13
4
1
1
4
2
3
4
4
1
2
4
9
3	

4 (5 times)
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09.Frequent_number
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


            //Find most frequent number            
            Dictionary<int, int> numsDist = nums.Distinct().ToDictionary(p => p, p => p * 0);

            for (int i = 0; i < nums.Length; i++)
            {
                numsDist[nums[i]]++;
            }


            //Print out            
            int max = numsDist.Aggregate((last, present) => last.Value < present.Value ? present : last).Key;
            //int max;
            //foreach (var kvp in numsDist)
            //{
            //    if(kvp.Value == numsDist.Values.Max())
            //    {
            //        max = kvp.Key;
            //        break;
            //    }
            //}
            Console.WriteLine("{0} ({1} times)", max, numsDist[max]);

        }
    }
}
