using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/**************************************************************
    Binary to Decimal

    Description

    Using loops write a program that converts a binary integer number to its decimal form.

    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
    Input

    You will receive exactly one line containing an integer number representation in binary
    Output

    On the only output line write the decimal representation of the number
    Constraints

    All input numbers will be valid 32-bit integers
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
0	0
11	3
1010101010101011	43691
1110000110000101100101000000	236476736

**************************************************************/
namespace P11.Binary_to_Decimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();//.Split();
            int[] binaryNum = new int[input.Length];
             
            foreach (Match m in Regex.Matches(input, @"[0-9]"))
            {
                binaryNum[m.Index] = int.Parse(m.Value);
            }
            Array.Reverse(binaryNum);

            long result = 0;
            for (int i = 0; i < binaryNum.Length; i++)
            {
                long element = binaryNum[i] * (long)Math.Pow(2, i);
                result = result + element;
            }

            int result2 = Convert.ToInt32(input, 2);

            Console.WriteLine(result);
            //Console.WriteLine(result2);
        }
    }
}
