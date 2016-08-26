using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Write a program that reads the coordinates of a point x and y and using an expression checks if given point (x, y) is inside a circle K({0, 0}, 2) - the center has coordinates (0, 0) and the circle has radius 2. The program should then print "yes DISTANCE" if the point is inside the circle or "no DISTANCE" if the point is outside the circle.

    In place of DISTANCE print the distance from the beginning of the coordinate system - (0, 0) - to the given point.
*/

class PPointInACircle
{
    static void Main(string[] args)
    {
        //A(x, y) A is the point name
        double xA = double.Parse(Console.ReadLine());
        double yA = double.Parse(Console.ReadLine());
        double rK = 2.0d;   //Cyrcle redius

        double distA = Math.Sqrt(Math.Pow(xA, 2) + Math.Pow(yA, 2));
        bool isInsideCyrcle = (distA <= rK);

        if (isInsideCyrcle)
        {
            Console.WriteLine("yes {0:#0.00}", distA);
        }
        else
        {
            Console.WriteLine("no {0:#0.00}", distA);
        }


    }
}

