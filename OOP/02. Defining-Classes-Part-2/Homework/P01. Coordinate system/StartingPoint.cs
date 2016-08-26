namespace PRG
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CoordinateSystem;
    using CoordinateSystem.IO;

    public class StartPoint
    {

        static void Main(string[] args)
        {
            //Problem 1. Structure
            Point3D firstPoint = new Point3D();

            firstPoint.X = 1.1;
            firstPoint.Y = 2.2;

            Console.WriteLine(new string('-', 20));
            Console.WriteLine(firstPoint.ToString());

            //Problem 2. Static read-only field
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(Point3D.ZeroPoint);

            //Problem 3. Static class
            Point3D A = new Point3D(1.1, 2.2, 3.3);
            //Point3D B = new Point3D(1.1, 2.2, 3.3);
            Point3D B = new Point3D(11.1, 12.2, 13.3);
            
            Console.WriteLine(new string('-', 20));
            Console.WriteLine("Firtst point A: {0}", A.ToString());
            Console.WriteLine("Second point B: {0}", B.ToString());

            double distanceAB = TwoPoints3D.CalculateDistance(A, B);
            Console.WriteLine(distanceAB);

            //Problem 4. Path
            Path3D pathToTheMiddleOfTheEarth = new Path3D();

            Point3D C = new Point3D(20, 21, 22);
            pathToTheMiddleOfTheEarth.AddSinglePoint(A);
            pathToTheMiddleOfTheEarth.AddSinglePoint(B);
            pathToTheMiddleOfTheEarth.AddSinglePoint(C);

            List<Point3D> pathToTheMiddle = new List<Point3D>();
            // Get alla points make a new copy, not by ref
            pathToTheMiddle = pathToTheMiddleOfTheEarth.GetAllPoints(pathToTheMiddle);
            // Add same points once again with the method AddMultipllePoints
            pathToTheMiddleOfTheEarth.AddMultiplePoints(pathToTheMiddle);

            //Check a single point
            Point3D singlePoint = pathToTheMiddleOfTheEarth.GetSinglePoint(0);

            // Check the difference in references
            pathToTheMiddle.Clear();
            pathToTheMiddle = pathToTheMiddleOfTheEarth.GetAllPoints(pathToTheMiddle);

            // Get all points once again
            List<Point3D> pathToTheMiddleUpdated = new List<Point3D>();
            pathToTheMiddleOfTheEarth.GetAllPoints(pathToTheMiddleUpdated);

            // Read/Write paths from/in txt file
            Path3D pathForIOTest = new Path3D();
            Point3D x = new Point3D(2.1, 3.2, 4.3);
            Point3D y = new Point3D(5.1, 6.2, 7.3);
            Point3D z = new Point3D(25.1, 25.2, 25.3);

            pathForIOTest.AddSinglePoint(x);
            pathForIOTest.AddSinglePoint(y);
            pathForIOTest.AddSinglePoint(z);

            PathStorage.WritePath(pathForIOTest);
            PathStorage.ReadPath();
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(string.Join("\r\n", PathStorage.Points3DFromFile.Select(p => p.ToString()))); 


        }
    }
}
