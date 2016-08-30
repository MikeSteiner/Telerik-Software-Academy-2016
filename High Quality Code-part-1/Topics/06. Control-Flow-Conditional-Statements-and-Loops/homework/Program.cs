using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChefsAreCooking;

namespace Task02AndTask03
{
    public class Program
    {
        public static int GetX()
        {
            // TODO implement random generator
            int x = 150;

            return x;
        }

        public static int GetY()
        {
            // TODO implement random generator
            int y = 1500;

            return y;
        }

        public static void VisitCell()
        {
            // TODO implement the code here
        }

        public static void Main(string[] args)
        {
            // Task 2. Refactor the following if statements
            Potato potato = new Potato();
            Chef chefManchev = new Chef();

            // ... 
            if (potato != null)
            {
                if (!potato.HasNotBeenPeeled && !potato.IsRotten)
                {
                    chefManchev.Cook(potato);
                }
            }

            // Task 3. Refactor the following loop
            int x = GetX();
            int xMax = 200;
            int xMin = 100;
            int y = GetY();
            int yMax = 2000;
            int yMin = 1000;

            bool isValidX = (x >= xMin) && (x <= xMax);
            bool isValidY = (y >= yMin) && (y <= yMax);
            bool shouldVisitCell = true;

            if (isValidX && isValidY && shouldVisitCell)
            {
                VisitCell();
            }

            int[] arrayHoldingTheValues = new int[100];

            // Fillout the array with test values
            for (int i = 0; i < 100; i++)
            {
                arrayHoldingTheValues[i] = i + 1;
            }

            int expectedValue = 11;
            bool isFoundTheValue = false;
            
            // Traversing array and searching for the expextedValue
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(arrayHoldingTheValues[i]);
                if (i % 10 == 0)
                {                    
                    if (arrayHoldingTheValues[i] == expectedValue)
                    {
                        isFoundTheValue = true;
                        break;
                    }
                }
            }

            // More code here
            if (isFoundTheValue)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
