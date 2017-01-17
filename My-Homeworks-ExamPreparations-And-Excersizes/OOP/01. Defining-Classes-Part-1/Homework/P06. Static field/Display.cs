namespace P06_StaticField
{
    using System;
    using GSM_NS;

    public class Display : GSM
    {
        private int dispSize;
        private int numberOfColors;

        //Constructor
        public Display() : this(0, 0) // Reuse the constructor
        {

        }

        public Display(int displaySize, int displayNumColors) 
        {
            this.dispSize = displaySize;
            this.numberOfColors = displayNumColors;
        }

        //Properties
        public int DisplaySize
        {
            get
            {
                return this.dispSize;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Display size should be bigger than zero");
                }

                this.dispSize = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Display numberOfColors must be bigger than zero");
                }

                this.numberOfColors = value;
            }
        }

        //Print inforamtion
        public void PrintDisplayInfo()
        {
            Console.WriteLine("------ Display information -------");
            Console.WriteLine("size: {0}", this.dispSize);
            Console.WriteLine("number of colors: {0}", this.numberOfColors);
        }

        public override string ToString()
        {
            return "Display: " + this.dispSize + "; " + this.numberOfColors;
        }
    }
}
