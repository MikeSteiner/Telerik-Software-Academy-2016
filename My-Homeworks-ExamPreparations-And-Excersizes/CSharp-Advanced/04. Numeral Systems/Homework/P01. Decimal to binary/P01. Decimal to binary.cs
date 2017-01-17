/*
Decimal to binary
Description

Write a program that converts a decimal number N to its binary representation.

Input

On the only line you will receive a decimal number - N
There will not be leading zeros
Output

Print the binary representation of N on a single line
There should not be leading zeros
Constraints

1 <= N <= 1018
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input   Output
19	10011
Submission
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numeral_Systems
{
    class Program
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            NumeralSystems nS = new NumeralSystems();

            Console.WriteLine(nS.DecimalToBinary(N));

        }        
    }

    class NumeralSystems
    {
        public NumeralSystems()
        {

        }

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
    }
}
