/*
Quick sort
Description

Write a program that sorts an array of integers using the Quick sort algorithm.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the sorted array
Each number should be on a new line
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
6
3
4
1
5
2
6	

1
2
3
4
5
6
-----------
10
36
10
1
34
28
38
31
27
30
20	

1
10
20
27
28
30
31
34
36
38 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P14.Quick_sort
{
    class QuickSort
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

            //Sort array unsing the Quick sort alghoritm
            //But not implemented yet
            Array.Sort(nums);


            //Print out
            Console.WriteLine(string.Join("\n", nums));
        }
    }
}
