using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
    Exchange numbers

    Description

    Write a program that reads two double values from the console A and B, stores them in variables and exchanges their values if the first one is greater than the second one. Use an if-statement. As a result print the values of the variables A and B, separated by a space.

    Input

    On the first line, you will receive the value of A
    On the second line, you will receive the value of B
    Output

    On the only output line, print the values of the two variables, separated by a whitespace
    Constraints

    A and B will always be valid real numbers between -100 and 100
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
5
3	3 5
2
4	2 4
3,3
3,3	3,3 3,3
     
********************************************************************************/

namespace P01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            if (a > b)
            {
                double aOld = a;
                a = b;
                b = aOld;
            }

           
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
