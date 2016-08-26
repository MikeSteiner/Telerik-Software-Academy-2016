/*
Merge sort
Description

Write a program that sorts an array of integers using the Merge sort algorithm.

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

-----
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

namespace P13.Merge_sort
{

    class Merge
    {
        public static void sort<T>(T[] a)
            where T : IComparable<T>
        {
            sort(a, 0, a.Length);
        }

        public static void sort<T>(T[] a, int low, int high)
            where T : IComparable<T>
        {
            int N = high - low;
            if (N <= 1)
            {
                return;
            }   

            int mid = low + N / 2;

            sort(a, low, mid);
            sort(a, mid, high);

            T[] aux = new T[N];
            int l = low, m = mid;
            for (int k = 0; k < N; k++)
            {
                if (l == mid)
                {
                    aux[k] = a[m++];
                }
                else if (m == high)
                {
                    aux[k] = a[l++];
                }
                else if (a[m].CompareTo(a[l]) < 0)
                {
                    aux[k] = a[m++];
                }
                else
                {
                    aux[k] = a[l++];
                }
            }

            for (int k = 0; k < N; k++)
            {
                a[low + k] = aux[k];
            }
        }


        private static Boolean isSorted(IComparable[] a)
        {
            for (int i = 1; i < a.Length; i++)
                if (a[i].CompareTo(a[i - 1]) < 0) return false;
            return true;
        }
    }

    class MergeSort
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

            //Sort array unsing the merge sort alghoritm
            Merge.sort(nums);


            //Print out
            Console.WriteLine(string.Join("\n", nums));
        }
    }
}
