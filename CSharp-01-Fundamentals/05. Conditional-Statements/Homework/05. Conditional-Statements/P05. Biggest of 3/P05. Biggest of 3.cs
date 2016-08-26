using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
    Biggest of 3

    Description

    Write a program that finds the biggest of three numbers that are read from the console.

    Input

    On the first three lines you will receive the three numbers, each on a separate line.
    Output

    On the only output line, write the biggest of the three numbers.
    Constraints

    The three numbers will always be valid floating-point numbers in the range [-200, 200].
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests                                                         

Input	Output
4
4
4	4
-0,5
-10
0	0
     
********************************************************************************/

namespace P05.Biggest_of_3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double biggestValue = double.MinValue;

            for (int i = 1; i <= 3; i++)
            {
                string inputStr = Console.ReadLine();
                double input = Convert.ToDouble(inputStr);

                if (input > biggestValue)
                {
                    biggestValue = input;
                }
            }
            Console.WriteLine("{0:#0.###}", biggestValue );
        }
    }
}
