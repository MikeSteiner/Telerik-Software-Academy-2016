using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    Calculate!

    Description

    Write a program that, for a given two integer numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x<sup>2</sup> + … + n!/x<sup>N</sup>.

    Use only one loop. Print the result with 5 digits after the decimal point.
    Input

    On the first line you will receive one number - N.
    On the second line you will receive another number - x.
    Output

    Output only one number - the sum of the sequence for the given N and x.
    Constraints

    N will always be a valid integer between 2 and 20, inclusive.
    X will always be a valid floating-point number between 0 and 100
    X * N will always be less than 50
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
3
2	2.75000
4
3	2.07407
5
-4	0.75781

**************************************************************/
namespace P05.Calculate_
{
    class CalculateFactorial
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double sum = 1d;
            int factorial = 1;

            for (int i = 1; i <= N; i++)
            {
                factorial = factorial * i;
                sum = sum + (factorial / Math.Pow(x, i));
            }

            Console.WriteLine("{0:#0.00000}", sum);

        }
    }
}
