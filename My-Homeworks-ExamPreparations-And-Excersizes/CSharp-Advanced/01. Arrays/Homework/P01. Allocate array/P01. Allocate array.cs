/*

Allocate array
Description

Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.

Input

On the only line you will receive the number N
Output

Print the obtained array on the console.
Each number should be on a new line
Constraints

1 <= N <= 20
N will always be a valid integer number
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
5	

0
5
10
15
20
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Arrays
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i * 5;
                Console.WriteLine(nums[i]);
            }

        }
    }
}
