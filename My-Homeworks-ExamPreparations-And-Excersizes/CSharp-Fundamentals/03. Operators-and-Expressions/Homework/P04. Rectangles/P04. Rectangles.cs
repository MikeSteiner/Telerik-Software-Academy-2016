using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Description

Write an expression that calculates rectangle’s area and perimeter by given width and height. The width and height should be read from the console.
*/

class Rectangles
{
    static void Main(string[] args)
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double area = width * height;
        double perimeter = width * 2 + height * 2;

        Console.WriteLine("{0:#0.00} {1:#0.00}", area, perimeter);
    }
}

