/*
Selection sort
Description

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

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
--
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

namespace P07.Selection_sort
{
    class SelectionSort
    {
        public static void SwapIndexes(int[] arr, int currIx, int minIx)
        {
            int savedVal = arr[currIx];
            arr[currIx] = arr[minIx];
            arr[minIx] = savedVal;
             
            //return arr;
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());            
            int[] nums = new int[N];

            //Fill out array
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }


            //Selection sort
            
            for (int i = 0; i < nums.Length - 1; i++)            {
                int minIx = i;

                //From min index to the rest, check for new minIx
                for (int mIx = i + 1; mIx < nums.Length; mIx++)
                {
                    if (nums[mIx] < nums[minIx])
                    {
                        minIx = mIx;
                    }
                }
                //Swap curret index with min Ix
                if (i != minIx)
                {
                    SwapIndexes(nums, i, minIx);
                }
                
            }

            //Print out
            //Console.WriteLine(new string('-', 10));
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }

        }
    }
}
