/*
Maximal K sum
Description

Write a program that reads two integer numbers N and K and an array of N elements from the console. Find the maximal sum of K elements in the array.

Input

On the first line you will receive the number N
On the second line you will receive the number K
On the next N lines the numbers of the array will be given
Output

Print the maximal sum of K elements in the array
Constraints

1 <= N <= 1024
1 <= K <= N
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
8
3
3
2
3
-2
5
4
2
7	

16
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Maximal_K_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] nums = new int[N];

            //Fill out array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            //Sort array desc
            Array.Sort(nums);
            Array.Reverse(nums);

            //Sum of K max elements
            int sum = nums[0];
            for (int i = 1; i < K; i++)
            {
                sum += nums[i];
            }

            //Print out
            Console.WriteLine(sum);

        }
    }
}
