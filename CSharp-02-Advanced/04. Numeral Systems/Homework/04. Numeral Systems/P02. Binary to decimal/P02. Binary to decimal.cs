/*
Binary to decimal
Description

Write a program that converts a binary number N to its decimal representation.

Input

On the only line you will receive a binary number - N
There will not be leading zeros
Output

Print the decimal representation of N on a single line
There should not be leading zeros
Constraints

1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
10011	19

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Binary_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string inLine = Console.ReadLine();
            NumeralSystems nS = new NumeralSystems();

            Console.WriteLine(nS.BinaryToDecimal(inLine));

        }
    }

    class NumeralSystems
    {
        public NumeralSystems()
        {

        }

        //**** Decimal to Binary
        public string DecimalToBinary(long input)
        {
            string bin = "";

            if (input == 0)
            {
                return "0";
            }
            else
            {
                while (input > 0)
                {
                    bin = input % 2 + bin;
                    input /= 2;
                }
            }

            return bin;
        }

        //public string DecimalToBinary(long input)
        //{
        //    string bin = Convert.ToString(input, 2);
        //    return bin;
        //}

        //**** Binary to Decimal
        public ulong BinaryToDecimal(string input)
        {
            ulong dec = 0L;

            if (input == "0")
            {
                return 0L;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    ulong currNum = (ulong)Char.GetNumericValue(input[input.Length - 1 - i]);
                    dec += currNum * (ulong)Math.Pow((double)2, i);
                }
            }

            return dec;
        }

        //public ulong BinaryToDecimal(string input)
        //{
        //    return Convert.ToUInt64(input, 2);
        //}
    }
}
