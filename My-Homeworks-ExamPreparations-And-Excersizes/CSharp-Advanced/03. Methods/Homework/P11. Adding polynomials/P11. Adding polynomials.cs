/*
Adding polynomials
Description

Write a method that adds two polynomials. Represent them as arrays of their coefficients. Write a program that reads two polynomials and prints their sum.

Input

On the first line you will receive the number N
On the second line you will receive the first polynomial as coefficients separated by spaces
On the third line you will receive the second polynomial as coefficients separated by spaces
Output

Print the sum of the polynomials
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
/*
Adding polynomials
Description

Write a method that adds two polynomials. Represent them as arrays of their coefficients. Write a program that reads two polynomials and prints their sum.

Input

On the first line you will receive the number N
On the second line you will receive the first polynomial as coefficients separated by spaces
On the third line you will receive the second polynomial as coefficients separated by spaces
Output

Print the sum of the polynomials
Constraints

1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3
5 0 1
7 4 -3	
12 4 -2
Example explanation:

x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}

-3x2 + 4x + 7 = -3x2 + 4x + 7 => {7, 4, -3}

(x2 + 5) + (-3x2 + 4x + 7) = (-2x2 + 4x + 12) = -2x2 + 4x + 12 => {12, 4, -2}

Submission
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11.Adding_polynomials
{
    class Program
    {
        static void Main(string[] args)
        {
            string notusedLine = Console.ReadLine();

            string inLineOne = Console.ReadLine();
            string inLineTwo = Console.ReadLine();

            //5  0  1
            //7  4 -3

            //Process the arrays
            List<int> arrOne = ReadInLineArray(inLineOne);
            List<int> arrTwo = ReadInLineArray(inLineTwo);

            Console.WriteLine(string.Join(" ", SumOfArrays(arrOne, arrTwo)));
        }        

        static List<int> ReadInLineArray(string inLine)
        {
            char[] delimiters = new char[] { ' ', ',' };
            List<int> nums = inLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(d => int.Parse(d)).ToList();

            return nums;
        }

        static List<int> SumOfArrays(List<int> arrOne, List<int> arrTwo)
        {
            //5  0  1
            //7  4 -3

            List<int> sumOfArrays = new List<int>();

            for (int i = 0; i < arrOne.Count; i++)
            {
                int currSum = arrOne[i] + arrTwo[i];
                sumOfArrays.Add(currSum);
            }

            return sumOfArrays;
        }
    }
}
