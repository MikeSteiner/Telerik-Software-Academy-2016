
namespace CoordinateSystem
{
    using System.Collections.Generic;

    // Problem 4. Path
    // Create a class Path  to hold a sequence of points in the 3D space.
    // Create a static class PathStorage  with static methods to save and load paths from a text file.
    // Use a file format of your choice.

    public class Path3D
    {
        private List<Point3D> points3D;

        public Path3D()
        {
            points3D = new List<Point3D>();
        }

        public int CountPoints
        {
            get
            {
                return this.points3D.Count;
            }
        }

        public List<Point3D> Points3D
        {
            get
            {
                return this.points3D;
            }
        }

        public void AddSinglePoint(Point3D newPoint3D)
        {
            this.points3D.Add(newPoint3D);
        }

        public void AddMultiplePoints(List<Point3D> newPoints3D)
        {
            int newPoints3DCount = newPoints3D.Count;
            for (int i = 0; i < newPoints3DCount; i++)
            {
                this.points3D.Add(newPoints3D[i]);
            }

            //foreach (Point3D point in newPoints3D)
            //{
            //    this.points3D.Add(point);
            //}
        }

        public Point3D GetSinglePoint(int index)
        {
            Point3D p3D = this.points3D[index];

            return p3D;
        }

        public List<Point3D> GetAllPoints(List<Point3D> newCoppyPoints3D)
        {
            foreach (Point3D point in points3D)
            {
                newCoppyPoints3D.Add(point);
            }

            return newCoppyPoints3D;
        }

        public void RemovePoint(int index)
        {
            this.points3D.RemoveAt(index);
        }
    }
}
