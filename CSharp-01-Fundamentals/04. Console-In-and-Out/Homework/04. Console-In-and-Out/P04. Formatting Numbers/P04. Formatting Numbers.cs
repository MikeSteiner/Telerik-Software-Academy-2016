using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/********************************************************************************************
    Formatting Numbers

    Description

    Write a program that reads 3 numbers:
    integer a (0 <= a <= 500)
    floating-point b
    floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
    The number a should be printed in hexadecimal, left aligned
    Then the number a should be printed in binary form, padded with zeroes
    The number b should be printed with 2 digits after the decimal point, right aligned
    The number c should be printed with 3 digits after the decimal point, left aligned.

Examples:

a	b	c	result
254	11,6	0,5	FE |0011111110| 11.60|0.500 |
499	-0,5559	10000	1F3 |0111110011| -0.56|10000.000 |
0	3	-0,1234	0 |0000000000| 3.00|-0.123 |

*********************************************************************************************/
namespace P04.Formatting_Numbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            //Input  a                   
            int a = int.Parse(Console.ReadLine());
            //Input  b
            string line = Console.ReadLine();
            line = line.Replace(',', '.');
            float b = float.Parse(line);
            //Input  c  
            line = Console.ReadLine();
            line = line.Replace(',', '.');
            float c = float.Parse(line);
            
            //string aHexStr = String.Format("{0,-10:X}", a);
            string aHexStr = a.ToString("X").PadRight(10, ' ');
            string aBinStr = Convert.ToString(a, 2).PadLeft(10, '0');  
            string bBinStr = String.Format("{0,10:#0.00}", b);
            string cBinStr = String.Format("{0:#0.00}", c).PadRight(10, ' ');

            Console.WriteLine("|{0}|{1}|{2,10:#0.00}|{3,-10:#0.000}|", aHexStr, aBinStr, b, c);
            
        }
    }
}
