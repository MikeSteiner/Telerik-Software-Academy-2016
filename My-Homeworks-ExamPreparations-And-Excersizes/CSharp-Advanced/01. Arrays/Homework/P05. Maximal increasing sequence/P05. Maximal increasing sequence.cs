///*
//Maximal increasing sequence
//Description

//Write a program that finds the length of the maximal increasing sequence in an array of N integers.

//Input

//On the first line you will receive the number N
//On the next N lines the numbers of the array will be given
//Output

//Print the length of the maximal increasing sequence
//Constraints

//1 <= N <= 1024
//Time limit: 0.1s
//Memory limit: 16MB
//Sample tests

//Input	Output
//8
//7
//3
//2
//3
//4
//2
//2
//4	

//3
//*/
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace P05.Maximal_increasing_sequence
//{
//    class MaximalIncreasingSequence
//    {
//        public static int bestSequenceLenght = 0;
//        public static int currSequenceLenght = 0;
//        public static int bestSequenceStartIx = 0;
//        public static int currSequenceStartIx = 0;

//        public static void CheckForNewBestSequence(int curretnIndex)
//        {
//            if (currSequenceLenght >= bestSequenceLenght)
//            {
//                bestSequenceLenght = currSequenceLenght;
//                bestSequenceStartIx = currSequenceStartIx;
//            }
//            currSequenceLenght = 1;
//            currSequenceStartIx = curretnIndex;
//        }

//        static void Main(string[] args)
//        {
//            int N = int.Parse(Console.ReadLine());
//            int[] nums = new int[N];

//            //Fill out array
//            for (int i = 0; i < nums.Length; i++)
//            {
//                nums[i] = int.Parse(Console.ReadLine());
//            }

//            //Check for best sequence
//            int previousNum = nums[0];

//            for (int i = 1; i < nums.Length; i++)
//            {
//                if (previousNum < nums[i])  //if current == next
//                {
//                    currSequenceLenght++;
//                    //if last index reached
//                    if (i + 1 == nums.Length)
//                    {
//                        CheckForNewBestSequence(i);
//                    }
//                }
//                else
//                {
//                    CheckForNewBestSequence(i);
//                }
//                previousNum = nums[i];
//            }

//            //Print out
//            //Console.WriteLine(new string('-', 10));
//            //for (int i = bestSequenceStartIx; i < bestSequenceStartIx + bestSequenceLenght; i++)
//            //{
//            //    Console.WriteLine(nums[i]);
//            //}
//            Console.WriteLine(bestSequenceLenght);
//        }
//    }
//}

using System;

namespace LongestIncreasingSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            //Fill out array
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //string inputArrayOne = Console.ReadLine();
            //char[] delimiter = new char[] { ',', ' ' };
            //string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            //int[] arr = new int[inputOne.Length];
            //for (int i = 0; i < inputOne.Length; i++)
            //{
            //    arr[i] = int.Parse(inputOne[i]);
            //}
            int counter = 0;
            int maxSequence = 0;
            int index = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                counter = 1;
                int j = i + 1;
                int k = i;

                while (arr[k] < arr[j])
                {
                    counter++;
                    j++;
                    k++;
                    if (j >= arr.Length)
                    {
                        break;
                    }
                }
                if (counter > maxSequence)
                {
                    maxSequence = counter;
                    index = i;
                }
            }

            int finalCounter = 0;
            for (int i = index; i <= index + maxSequence - 1; i++)
            {
                //if (i != index + maxSequence - 1)
                //{
                //    Console.Write(arr[i] + ", ");
                //}
                //else
                //{
                //    Console.WriteLine(arr[i]);
                //}
                finalCounter++;
            }
            Console.WriteLine(finalCounter);
        }
    }
}

