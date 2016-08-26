/*
Maximal sequence
Description

Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.

Input

On the first line you will receive the number N
On the next N lines the numbers of the array will be given
Output

Print the length of the maximal sequence
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input   Output
10
2
1
1
2
3
3
2
2
2
1
    */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4.Maximal_sequence
{
    class MaximalEqualSequence
    {
        public static int bestSequenceLenght = 1;
        public static int currSequenceLenght = 1;
        public static int bestSequenceStartIx = 0;
        public static int currSequenceStartIx = 0;

        public static void CheckForNewBestSequence(int curretnIndex)
        {     
            if (currSequenceLenght > bestSequenceLenght)
            {
                bestSequenceLenght = currSequenceLenght;
                bestSequenceStartIx = currSequenceStartIx;
            }
            currSequenceLenght = 1;
            currSequenceStartIx = curretnIndex;
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

            //Check for best sequence
            int previousNum = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (previousNum == nums[i])  //if current == next
                {
                    currSequenceLenght++;
                    //if last index reached
                    if (i + 1 == nums.Length)
                    {
                        CheckForNewBestSequence(i);
                    }
                }
                else
                {
                    CheckForNewBestSequence(i);
                }
                previousNum = nums[i];
            }

            //Print out
            //for (int i = bestSequenceStartIx; i < bestSequenceStartIx + bestSequenceLenght; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            Console.WriteLine(bestSequenceLenght);
        }
    }
}
