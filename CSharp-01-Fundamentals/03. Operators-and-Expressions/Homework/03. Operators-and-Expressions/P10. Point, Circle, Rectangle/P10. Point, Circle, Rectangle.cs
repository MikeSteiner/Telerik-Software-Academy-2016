using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Write a program that reads a pair of coordinates x and y and uses an expression to checks for given point (x, y) 
    if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/

class PointCircleRectangle
{
    static void Main(string[] args)
    {

        //A(x, y) A is the point name
        double xA = double.Parse(Console.ReadLine());
        double yA = double.Parse(Console.ReadLine());

        double xK = 1.0d;   //Cyrcle center X
        double yK = 1.0d;   //Cyrcle center Y
        double rK = 1.5d;   //Cyrcle redius

        double topR = 1.0d;
        double leftR = -1.0d;
        double widthR = 6.0d;
        double heightR = 2.0d;

        //Check if inside cyrcle
        double xAd = xA - xK;
        double yAd = yA - yK;

        double distA = Math.Sqrt(Math.Pow(xAd, 2) + Math.Pow(yAd, 2));
        bool isInsideCyrcle = (distA <= rK);

        if (isInsideCyrcle)
        {
            Console.Write("inside circle ");            
        }
        else
        {
            Console.Write("outside circle ");
        }

        //Check if inside rectangle
        bool isInsideRectangle = (xA >= leftR && xA <= (leftR + widthR)) &&
            (yA <= topR && yA >= (topR - heightR));

        if (isInsideRectangle)
        {
            Console.Write("inside rectangle");            
        }
        else
        {
            Console.Write("outside rectangle");
        }
        Console.WriteLine();

    }
}

