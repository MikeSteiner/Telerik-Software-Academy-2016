using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
    Multiplication sign

    Description

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.

    Use a sequence of if operators.
    Input

    On the first three lines, you will receive the three numbers, each on a separate line
    Output

    Output a single line - the sign of the product of the three numbers
    Constraints

    The input will always consist of valid floating-point numbers
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Sample tests

Input	Output
2
5
2	+
2
5
-2	-
-0,5
0
-2	0
 
********************************************************************************/

namespace P04.Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            int negativeSignsCounter = 0;
            int zeroesCounter = 0;

            for (int i = 1; i <= 3; i++)
            {
                string inputStr = Console.ReadLine();
                double input = Convert.ToDouble(inputStr);
                if (input < 0)
                {
                    negativeSignsCounter++;
                }
                if (input == 0)
                {
                    zeroesCounter++;
                }
            }

            //bool isEven = (negativeSignsCounter % 2 == 0);
            //bool iOdd = (negativeSignsCounter % 2 == 1);

            if (zeroesCounter > 0)
            {
                Console.WriteLine("0");
            }
            else if (negativeSignsCounter == 0 && zeroesCounter == 0)
            {
                Console.WriteLine("+");
            }
            else if (negativeSignsCounter == 1 && zeroesCounter == 0)
            {
                Console.WriteLine("-");
            }
            else if (negativeSignsCounter == 2 && zeroesCounter == 0)
            {
                Console.WriteLine("+");
            }
            else if (negativeSignsCounter == 3 && zeroesCounter == 0)
            {
                Console.WriteLine("-");
            }

        }
    }
}
