namespace CoordinateSystem
{
    using System;

    public static class TwoPoints3D
    {
        //Problem 3. Static class
        //Write a static class with a static method to calculate the distance between two points in the 3D space.

        public static double CalculateDistance(Point3D A, Point3D B)
        {
            double r = 0.0;

            double xAB = (B.X - A.X);
            xAB *= xAB;
            double yAB = (B.Y - A.Y);
            yAB *= yAB;
            double zAB = (B.Z - A.Z);
            zAB *= zAB;

            r = Math.Sqrt(xAB + yAB + zAB);

            return r;
        }

    }
}
