/*
 * Reverse number
Description

Write a method that reverses the digits of a given decimal number.

Input

On the first line you will receive a number
Output

Print the given number with reversed digits
Constraints

Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
256	652
123.45	54.321
Submission
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.Reverse_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inLine = Console.ReadLine();
            char[] inLineRev = inLine.Select(ch => ch).ToArray();
            Array.Reverse(inLineRev);
            Console.WriteLine(inLineRev);

        }
    }
}
