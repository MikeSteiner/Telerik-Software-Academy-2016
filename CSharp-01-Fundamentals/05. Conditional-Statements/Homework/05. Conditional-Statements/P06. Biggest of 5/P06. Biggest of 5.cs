using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
    Biggest of 5

    Description

    Write a program that finds the biggest of 5 numbers that are read from the console, using only 5 if statements.

    Input

    On the first 5 lines you will receive the 5 numbers, each on a separate line
    Output

    On the only output line, write the biggest of the 5 numbers
    Constraints

    The 5 numbers will always be valid floating-point numbers in the range [-200, 200]
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
4
4
4
4
4	4
-0,5
-10
0
-1
-3	0 
     
********************************************************************************/

namespace P06.Biggest_of_5
{
    class BiggestOf5
    {
        static void Main(string[] args)
        {
            double biggestValue = double.MinValue;

            for (int i = 1; i <= 5; i++)
            {
                string inputStr = Console.ReadLine();
                double input = Convert.ToDouble(inputStr);

                if (input > biggestValue)
                {
                    biggestValue = input;
                }
            }
            Console.WriteLine("{0:#0.###}", biggestValue);
        }
    }
}
