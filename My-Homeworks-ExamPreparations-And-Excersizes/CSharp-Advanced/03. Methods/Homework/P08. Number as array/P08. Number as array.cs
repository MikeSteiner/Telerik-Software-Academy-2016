/*
 * Number as array
Description

Write a method that adds two positive integer numbers represented as arrays of digits 
(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
Write a program that reads two arrays representing positive integers and outputs their sum.

Input

On the first line you will receive two numbers separated by spaces - the size of each array
On the second line you will receive the first array
On the third line you will receive the second array
Output

Print the sum as an array of digits (as described)
Digits should be separated by spaces
Constraints

Each of the numbers that will be added could have up to 10 000 digits.
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3 4
8 3 3
6 2 4 2	

4 6 7 2

5 5
0 3 9 3 2
5 9 5 1 7	

5 2 5 5 9
Submission
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.Number_as_array
{
    class Program
    {
        static void Main(string[] args)
        {
            string notusedLine = Console.ReadLine();

            string inLineOne = Console.ReadLine();
            string inLineTwo = Console.ReadLine();

            //8 3 3
            //6 2 4 2

            //Prepare lines
            int lenghtsDifference = inLineOne.Length - inLineTwo.Length;
            if (lenghtsDifference > 0)
            {
                inLineTwo = AppendStrings(inLineTwo, lenghtsDifference);
            }
            else if (lenghtsDifference < 0)
            {
                inLineOne = AppendStrings(inLineOne, lenghtsDifference);
            }

            //Process the arrays
            List<int> arrOne = ReadInLineArray(inLineOne);
            List<int> arrTwo = ReadInLineArray(inLineTwo);

            Console.WriteLine(string.Join(" ", SumOfArrays(arrOne, arrTwo)));

        }

        static string AppendStrings(string inLineString, int appendLen)
        {
            StringBuilder sb = new StringBuilder(inLineString);

            for (int i = 0; i < Math.Abs(appendLen / 2); i++)
            {
                sb.Append(" 0");
            }
            inLineString = sb.ToString();

            return sb.ToString();
        }

        static List<int> ReadInLineArray(string inLine)
        {            
            char[] delimiters = new char[] { ' ', ',' };
            List<int> nums = inLine.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Select(d => int.Parse(d)).ToList();

            return nums;
        }

        static List<int> SumOfArrays(List<int> arrOne, List<int> arrTwo)
        {
            //8 3 3
            //6 2 4 2

            List<int> sumOfArrays = new List<int>();
            int reminder = 0;
            for (int i = 0; i < arrOne.Count; i++)
            {
                int currSum = arrOne[i] + arrTwo[i] + reminder;
                int sumToAdd = currSum % 10;
                reminder = (currSum - sumToAdd) / 10;

                sumOfArrays.Add(sumToAdd);
            }

            return sumOfArrays;
        }
    }
}
