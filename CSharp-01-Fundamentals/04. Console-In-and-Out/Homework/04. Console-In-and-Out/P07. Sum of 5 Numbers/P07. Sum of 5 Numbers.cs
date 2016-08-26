using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Sum of 5 numbers

    Description

    Write a program that reads 5 integer numbers from the console and prints their sum.

    Input

    You will receive 5 numbers on five separate lines.

    Output

    Your output should consist only of a single line - the sum of the 5 numbers.

    Constraints

    All 5 numbers will always be valid integer numbers between -1000 and 1000, inclusive
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
1
2
3
4
5	15
-1
2
-3
4
10	12
0
0
0
0
0	0

*********************************************************************************************/
namespace P07.Sum_of_5_Numbers
{
    class SumOf5Numbers
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i<5; i++)
            {
                sum = sum + int.Parse(Console.ReadLine());
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
