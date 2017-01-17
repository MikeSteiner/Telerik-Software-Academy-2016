using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    Not Divisible Numbers

    Description

    Write a program that reads from the console a positive integer N and prints all the numbers from 1 to N not divisible by 3 or 7, on a single line, separated by a space.

    Input

    Will always consists of one valid integer number - the number N.
    Output

    Should always consists of the numbers from 1 to N, which are not divisible by 3 or 7, separated by a whitespace.
    Constraints

    1 < N < 1500
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
10	1 2 4 5 8 10
3	1 2

**************************************************************/
namespace P02.Not_Divisible_Numbers
{
    class NotDivisibleNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                bool isNotDivisable = (i % 3 != 0) && (i % 7 != 0);
                if (isNotDivisable)
                {
                    Console.Write("{0} ", i);
                }                
            }
            Console.WriteLine();
        }
    }
}
