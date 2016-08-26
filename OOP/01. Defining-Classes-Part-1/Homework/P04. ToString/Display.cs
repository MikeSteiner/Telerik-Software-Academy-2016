namespace P04_ToString
{
    using System;

    public class Display
    {
        private int size;
        private int numberOfColors;

        public Display() : this(0, 0) // Reuse the constructor
        {

        }

        public Display(int displaySize, int displayNumColors) 
        {
            this.size = displaySize;
            this.numberOfColors = displayNumColors;
        }

        public void PrintInfo()
        {
            Console.WriteLine("------ Display information -------");
            Console.WriteLine("size: {0}", this.size);
            Console.WriteLine("number of colors: {0}", this.numberOfColors);
        }

        public override string ToString()
        {
            return "Display: " + this.size + "; " + this.numberOfColors;
        }
    }
}
