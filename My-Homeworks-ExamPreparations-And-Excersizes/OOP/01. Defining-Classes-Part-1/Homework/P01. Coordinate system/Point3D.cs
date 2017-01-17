namespace CoordinateSystem
{
    using System;

    public struct Point3D
    {
        //Problem 1. Structure
        //Create a structure Point3D  to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
        //Implement the  ToString()  to enable printing a 3D point.

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x = 0, double y = 0, double z = 0)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }


         

    }
}
