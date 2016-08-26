using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Sum of 3 numbers

    Description

    Write a program that reads 3 real numbers from the console and prints their sum.

    Input

    On the first line, you will receive the number a
    On the second line, you will receive the number b
    On the third line, you will receive the number c
    Output

    Your output should consist only of a single line - the sum of the three numbers.

    Constraints

    a, b and c will always be valid real numbers between -1000 and 1000, inclusive
    Time limit: 0.1s
    Memory limit: 8MB 

Sample tests

Input	Output
1
2
3	6

-2
0
3	1

5,5
4,5
20,1	30,1
 ********************************************************************************************/
namespace P04.Console_In_and_Out
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            float sum = a + b + c;
            Console.WriteLine("{0}", sum);
        }
    }
}
