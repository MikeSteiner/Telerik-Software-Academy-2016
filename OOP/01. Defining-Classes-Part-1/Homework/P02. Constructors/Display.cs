namespace P02_Constructors
{
    using System;

    class Display
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
    }
}
