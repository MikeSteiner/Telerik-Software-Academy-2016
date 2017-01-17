using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSize
{
    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
        }

        public static Size GetRotatedSize(Size size, double rotationAngleDegree)
        {
            double cos = Math.Abs(Math.Cos(rotationAngleDegree));
            double sin = Math.Abs(Math.Sin(rotationAngleDegree));

            double newWidth = (cos * size.Width) + (sin * size.Height);
            double newHeight = (sin * size.Width) + (cos * size.Height);

            return new Size(newWidth, newHeight);
        }

        public override string ToString()
        {
            string toString = string.Format("width: {0}, height: {1}", this.Width, this.Height);

            return toString;
        }
    }
}
