/*
 * Permutations of set
Description

Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].

Sample tests

N	result
3	
{1, 2, 3} 
{1, 3, 2} 
{2, 1, 3} 
{2, 3, 1} 
{3, 1, 2} 
{3, 2, 1}
Submission

You do not have to submit anything for this problem
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P19.Permutations_of_set
{
    class PermutationsOfSet
    {
        static bool IsNumberContainsDigitsFromRange(int number, int range)
        {
            bool areDigitsFromRange = true;

            //Create list of digits
            //List<int> digits = number.ToString().Select(d => int.Parse(d.ToString())).ToList();
            //Create list of unique digits
            List<int> digits = number.ToString().Select(d => int.Parse(d.ToString())).Distinct().ToList();

            //
            if (digits.Count == range)
            {
                for (int i = 0; i < digits.Count; i++)
                {
                    bool digitIsFromNumber = (1 <= digits[i]) && (digits[i] <= range);
                    if (!digitIsFromNumber)
                    {
                        areDigitsFromRange = false;
                        break;
                    }
                }
            }
            else
            {
                areDigitsFromRange = false;
            }
            

            return areDigitsFromRange;
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            // N=3 => 100 => 999
            int startIx = (int)Math.Pow((double)10, (double)(N - 1));
            int endIx = (int)Math.Pow((double)10, (double)N);
            for (int i = startIx; i < endIx; i++)
            {

                if (IsNumberContainsDigitsFromRange(i, N))
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
