using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceNs
{
    class Program
    {
        static void Main(string[] args)
        {            
            double sA = double.Parse(Console.ReadLine());
            double hA = double.Parse(Console.ReadLine());

            TriangleSurface triangle = new TriangleSurface(sA, hA);
            Console.WriteLine("{0:#0.00}",triangle.Surface);

        }
    }

    public class TriangleSurface
    {
        private bool isMadeWithSideAHeightA = false;
        private bool isMadeWithThreeSides = false;
        private bool isMadeWithTwoSidesAngle = false;


        public TriangleSurface()
        {
            sideA = 2;
            heightA = 2;
            CalculateSurfaceSideAHeightA();
        }

        //Calc surface on one side na side height
        public TriangleSurface(double sideA, double heightA)
        {
            this.sideA = SideValidator(sideA);
            this.heightA = SideValidator(heightA);
            
            CalculateSurfaceSideAHeightA();

            this.isMadeWithSideAHeightA = true;
        }

        //Calc surface on three sides
        public TriangleSurface(double sideA, double sideB, double sideC)
        {
            this.sideA = SideValidator(sideA);
            this.sideB = SideValidator(sideB);
            this.sideC = SideValidator(sideC);

            CalculateSurfaceAllSides();

            this.isMadeWithThreeSides = true;
        }

        //Calc surface base on two sides and angle        
        public TriangleSurface (double sideA, double sideB, float angle)
        {
            this.sideA = SideValidator(sideA);
            this.sideB = SideValidator(sideB);
            this.angle = AngleValidator((double)angle);

            CalculateSurfaceTwoSidesAngle();

            this.isMadeWithTwoSidesAngle = true;
           
        }



        //Side A
        private double sideA;
        public double SideA
        {
            get
            {
                return this.sideA;
            }
            set
            {
                this.sideA = SideValidator(value);
            }
        }
        //Side B
        private double sideB;
        public double SideB
        {
            get
            {
                return this.sideB;
            }
            set
            {
                this.sideB = SideValidator(value);
            }
        }
        //Side C
        private double sideC;
        public double SideC
        {
            get
            {
                return this.sideC;
            }
            set
            {
                this.sideC = SideValidator(value);
            }
        }
        //Height A
        private double heightA;
        public double HeightA
        {
            get
            {
                return this.heightA;
            }
            set
            {
                this.heightA = SideValidator(value);
            }
        }
        //Angle 
        private double angle;
        public double Angle
        {
            get
            {
                return this.angle;
            }
            set
            {
                this.angle = AngleValidator(value);
            }
        }


        private double SideValidator(double side)
        {
            bool isSideValid = (side > 0.0d);
            if (isSideValid)
            {
                return side;
            }
            else
            {
                Console.WriteLine("Invalid side value.");
                return 1;
            }
        }

        private double AngleValidator(double angle)
        {
            bool isAngleValid = (angle > 0.0d) && (angle < 180.0d);
            if (isAngleValid)
            {
                return angle;
            }
            else
            {
                Console.WriteLine("Invalid angle");
                return -1;
            }
        }



        private double surface;

        private void CalculateSurfaceSideAHeightA()
        {
            this.surface = (sideA * heightA) / 2;
        }

        private void CalculateSurfaceAllSides()
        {
            double p = (sideA + sideB + sideC) / 2;
            if (p > 0.0d)
            {
                this.surface = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
            }
            
        }

        private void CalculateSurfaceTwoSidesAngle()
        {
            var sin = Math.Asin(angle * Math.PI / 180);
            this.surface = (sideA * sideB * Math.Sin(angle * Math.PI / 180)) / 2;
        }


        //Get surface
        public double Surface
        {
            get
            {
                if (this.isMadeWithSideAHeightA)
                {
                    CalculateSurfaceSideAHeightA();                    
                }
                else if (this.isMadeWithThreeSides)
                {
                    CalculateSurfaceAllSides();
                }
                else if (this.isMadeWithTwoSidesAngle)
                {
                    CalculateSurfaceTwoSidesAngle();
                }
                else
                {
                    CalculateSurfaceSideAHeightA();
                }
                return this.surface;
            }
        }

    }

}
