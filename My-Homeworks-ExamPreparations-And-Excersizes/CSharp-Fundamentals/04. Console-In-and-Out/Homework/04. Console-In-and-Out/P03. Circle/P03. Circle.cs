using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Circle

    Description

    Write a program that reads from the console the radius r of a circle and prints its perimeter and area, rounded and formatted with 2 digits after the decimal point.

    Input

    On the only line of the input you will receive the radius of the circle - r
    Output

    You should print one line only: the perimeter and the area of the circle, separated by a whitespace, and with 2 digits precision
    Constraints

    The radius r will always be a valid and positive real number
    Time limit: 0.1s
    Memory limit: 8MB
    Sample tests

    Input	Output
    2	12.57 12.57
    3.5	21.99 38.48
    Submission
*********************************************************************************************/
namespace P03.Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            //Input
            const double pi = 3.141592653589;      //3.1415 9265 3589 7932 3846 2643 3832 7950 2884 1971 6939 9375 1058 2097 4944 5923
            double circleRadius = double.Parse(Console.ReadLine());

            //Calc
            double circlePerimeter = 2 * pi * circleRadius;
            double circleArea = pi * Math.Pow(circleRadius, 2);

            //Output
            Console.WriteLine("{0:#0.00} {1:#0.00}", circlePerimeter, circleArea);
        }
    }
}
