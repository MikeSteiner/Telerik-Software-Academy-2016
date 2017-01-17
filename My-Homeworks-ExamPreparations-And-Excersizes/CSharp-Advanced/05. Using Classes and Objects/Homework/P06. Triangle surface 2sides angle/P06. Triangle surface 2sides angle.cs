using System;

namespace P06.Triangle_surface_2sides_angle
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double sA = double.Parse(Console.ReadLine());
            double sB = double.Parse(Console.ReadLine());
            double angleAB = double.Parse(Console.ReadLine());

            double area = TriangleAreaTwoSidesAngle(sA, sB, angleAB);
            Console.WriteLine("{0:#0.00}", area);
        }

        static double TriangleAreaTwoSidesAngle(double a, double b, double angle)
        {
            double area = (a * b * Math.Sin(angle * Math.PI / 180)) / 2; //convert degrees to radians for Math.Sin
            return area;
        }
    }

    
}
