/*
Binary search
Description

Write a program, that reads from the console an array of N integers and an integer K, sorts the array and 
using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

Submission

You do not have to submit anything for this problem
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Binary_search
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 5, 7, 9 };

            //int N = int.Parse(Console.ReadLine());
            //int[] nums = new int[N];

            //for (int i = 0; i < N; i++)
            //{
            //    nums[i] = int.Parse(Console.ReadLine());

            //}

            //int K = int.Parse(Console.ReadLine());
            int K = 4;


            Console.WriteLine("Raw array: {0}", string.Join(", ", nums));
            Array.Sort(nums);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", nums));

            int indexOfK = Array.BinarySearch(nums, K);

            //{ 1, 2, 3, 5, 7, 9 };
            if (indexOfK > 0)
            {
                Console.WriteLine("The largest number in the array which is ≤ K. is: {0} with Ix={1}", nums[indexOfK-1], indexOfK-1);
            }
            else if (indexOfK == 0)
            {
                Console.WriteLine("K={0} is the smallest element in the array with Ix={1}.", K, indexOfK-1);
            }
            else
            {         
                int ix = (indexOfK * -1) - 2;       
                Console.WriteLine("K={0} is not an element of the array, but the largest number in the array which is ≤ K. is: {1} with Ix={2}", K, nums[ix], ix);
            }



        }
    }
}
