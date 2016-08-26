using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Description

The gravitational field of the Moon is approximately 17% of that on the Earth.

Write a program that calculates the weight of a man on the moon by a given weight W(as a floating-point number) on the Earth.
The weight W should be read from the console.

*/

class MoonGravity
{
    static void Main(string[] args)
    {
        double weightEarth = double.Parse(Console.ReadLine());
        double weightMoon = (weightEarth / 100.0d) * 17.0d;

        Console.WriteLine("{0:#0.000}", weightMoon);
    }
}

