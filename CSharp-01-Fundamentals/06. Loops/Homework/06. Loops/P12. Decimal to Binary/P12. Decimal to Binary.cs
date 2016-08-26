using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    Decimal to Binary

    Description

    Using loops write a program that converts an integer number to its binary representation.

    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
    Input

    On the only input line you will receive the decimal integer number.
    Output

    Output a single string - the representation of the input decimal number in it's binary representation.
    Constraints

    All numbers will always be valid 32-bit integers.
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
0	0
3	11
43691	1010101010101011
236476736	1110000110000101100101000000

**************************************************************/
namespace P12.Decimal_to_Binary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            //int binValue;
            int remindedValue = input;
            string result = "";

            while (true)
            {
                int binValue = remindedValue % 2;
                remindedValue = remindedValue / 2;
                result = binValue.ToString() + result;

                if(remindedValue <= 0)
                {
                    break;
                }
            }

            string result2 = Convert.ToString(input, 2);
            Console.WriteLine(result);
        }
    }
}
