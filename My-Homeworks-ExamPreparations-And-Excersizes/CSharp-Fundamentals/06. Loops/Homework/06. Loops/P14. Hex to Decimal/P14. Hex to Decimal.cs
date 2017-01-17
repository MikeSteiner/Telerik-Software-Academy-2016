using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/**************************************************************
    Hex to Decimal

    Description

    Using loops write a program that converts a hexadecimal integer number to its decimal form.

    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
    Input

    The input will consists of a single line containing a single hexadecimal number as string.
    Output

    The output should consist of a single line - the decimal representation of the number as string.
    Constraints

    All numbers will be valid 64-bit integers.
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
FE	254
1AE3	6883
4ED528CBB4	338583669684


**************************************************************/
namespace HexToDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            long[] hexArr = new long[input.Length];

            foreach (Match m in Regex.Matches(input, @"[0-9A-Fa-f]"))
            {
                long currentValue = Convert.ToInt64(m.Value, 16);
                hexArr[m.Index] = currentValue * (long)Math.Pow(16, (hexArr.Length - m.Index - 1));
            }
            Array.Reverse(hexArr);

            Console.WriteLine(hexArr.Sum());

        }
    }
}
