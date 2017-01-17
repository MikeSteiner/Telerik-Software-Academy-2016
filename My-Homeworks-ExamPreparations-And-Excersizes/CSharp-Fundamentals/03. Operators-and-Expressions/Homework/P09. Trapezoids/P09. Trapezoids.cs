using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Description

Write an expression that calculates trapezoid's area by given sides a and b and height h. 
The three values should be read from the console in the order shown below. All three value will be floating-point numbers.
*/

class Trapezoids
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());

        double trapezoidsArea = ((a + b) * h) / 2;
        Console.WriteLine("{0:#0.0000000}",trapezoidsArea);
    }
}

