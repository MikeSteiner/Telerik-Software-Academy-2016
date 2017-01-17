

namespace CoordinateSystem.IO
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using CoordinateSystem;

    // Problem 4. Path
    // Create a class Path  to hold a sequence of points in the 3D space.
    // Create a static class PathStorage  with static methods to save and load paths from a text file.
    // Use a file format of your choice.

    public static class PathStorage
    {
        private static List<Point3D> points3DFromFile;
        private static string fileName = "points.txt";

        static PathStorage()
        {
            points3DFromFile = new List<Point3D>();
        }

        public static List<Point3D> Points3DFromFile
        {
            get
            {
                return points3DFromFile;
            }
        }

        public static void ReadPath()
        {
            StreamReader streamReader = new StreamReader(fileName);
            //List<string> fLines = new List<string>();

            using (streamReader)
            {
                int lineNumber = 0;
                string fLine = string.Empty; // streamReader.ReadLine();
                while (true)
                {
                    //Read a line from the file with the path
                    fLine = streamReader.ReadLine();

                    bool isEOF = (fLine == null);
                    if (isEOF)
                    {
                        break;
                    }

                    // Convert the line in a type Point3D
                    Point3D p = ConvertFLineToPoint3D(fLine);
                    // Put it in the collection
                    points3DFromFile.Add(p);

                    lineNumber++;
                }

                streamReader.Close();
            }

            //return fLines;
        }

        private static Point3D ConvertFLineToPoint3D(string line = "")
        {
            List<double> xyz = line
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                .Select(s => double.Parse(s))
                                .ToList();

            Point3D point = new Point3D(xyz[0], xyz[1], xyz[2]);

            return point;
        }

        public static void WritePath(Path3D path)
        {
            StreamWriter streamWriter = new StreamWriter(fileName);
            using (streamWriter)
            {
                int pathCountPoints = path.CountPoints;

                for (int i = 0; i < pathCountPoints; i++)
                {
                    Point3D p = path.Points3D[i];
                    string fLine = p.X + " " + p.Y + " " + p.Z;
                    streamWriter.WriteLine(fLine);
                }

                streamWriter.Close();
            }
        }

    }
}
