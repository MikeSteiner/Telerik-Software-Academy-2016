using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Quadratic Equation

    Description

    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

    Input

    On the first three lines, you will receive the coefficients a, b, and c, each on a separate line in the same order
    Output

    If two different real roots exist, print them on two separate lines
    Print the smaller root on the first line
    If only one real root exists, print it on the only output line
    If no real root exists, print the string "no real roots"
    The roots, should they exist, must be printed with precision exactly two digits after the floating point
    Constraints

    The input will always consist of valid real numbers in the range [-1000, 1000] and will follow the described format
    Time limit: 0.1s
    Memory limit: 8MB
    Sample tests

Input	Output
2
5
-3	-3,00
0,50

-1
3
0	0,00
3,00

-0,5
4
-8	4,00

5
2
8	no real roots

*********************************************************************************************/
namespace P06.Quadratic_Equation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            double D = Math.Pow(b, 2) - (4 * a * c);
            double? x1;
            double? x2;

            if (D < 0)
            {
                x1 = null;
                x2 = null;
            }
            else if (D == 0)
            {
                x1 = (-1) * b / (2 * a);
                x2 = null;
            } else
            {
                D = Math.Sqrt(D);
                x1 = ((-1) * b + D) / (2 * a);
                x2 = ((-1) * b - D) / (2 * a);
            }

            if (x1 == null && x2 == null)
            {
                Console.WriteLine("no real roots");
            }
            else if (x1 != null && x2 == null)
            {
                Console.WriteLine("{0:#0.00}", x1);
            }
            else
            {
                double xMin = Math.Min((double)x1, (double)x2);
                double xMax = Math.Max((double)x1, (double)x2);
                Console.WriteLine("{0:#0.00}", xMin);
                Console.WriteLine("{0:#0.00}", xMax);
            }            
        }
    }
}
