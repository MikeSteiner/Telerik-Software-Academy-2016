/*
Find sum in array
Description

Write a program that finds in given array of integers a sequence of given sum S (if present).

Example:

array	S	result
4, 3, 1, 4, 2, 5, 8	11	4, 2, 5
You do not have to submit anything for this problem.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.Find_sum_in_array
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            //Input
            int[] nums = Console
                        .ReadLine()
                        .Split(new Char[] {',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(p => int.Parse(p))
                        .ToArray();
            int S = int.Parse(Console.ReadLine());

            //Decalre
            int bestSum = 0;
            int currSum = 0;
            int bestSumStartIx = 0;
            int currSumStartIx = 0;
            int bestSumLenght = 1;
            int currSumLenght = 1;

            //4, 3, 1, 4, 2, 5, 8
            //S==11
            //Precessing
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i; j < nums.Length; j++)
                {
                    currSum += nums[j];
                    if (currSum >= S)
                    {
                        //assign to best
                        if(currSum == S)
                        {
                            bestSumStartIx = currSumStartIx;
                            bestSumLenght = currSumLenght;
                            bestSum = currSum;
                        }                        
                        //zeroing current
                        if (i+1 < nums.Length)
                        {
                            currSumStartIx = i+1;   //if is not the last element
                        }                        
                        currSumLenght = 1;
                        currSum = 0;
                        //break
                        break;
                    }                    
                    else
                    {
                        currSumLenght++;                        
                    }
                }

                if (bestSum == S)
                {
                    break;
                }
            }


            //Print out
            Console.WriteLine("Best sum: {0}", bestSum);            

            int[] output = Enumerable.Range(bestSumStartIx, bestSumLenght).Select(index => nums[index]).ToArray();
            Console.WriteLine(string.Join(", ", output));
            
        }
    }
}
