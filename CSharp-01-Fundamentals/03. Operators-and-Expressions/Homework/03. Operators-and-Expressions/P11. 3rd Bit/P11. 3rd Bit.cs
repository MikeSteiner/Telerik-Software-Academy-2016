using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Using bitwise operators, write a program that uses an expression to find the value of the bit at index 3 of an unsigned integer read from the console.

    The bits are counted from right to left, starting from bit 0.
    The result of the expression should be either 1 or 0. Print it on the console.
*/

class ThirdBit
{
    static void Main(string[] args)
    { 
        int N = int.Parse(Console.ReadLine());
        int bitMask = 8;
        //Console.WriteLine(Convert.ToString(N, 2));
        //Console.WriteLine(Convert.ToString(bitMask, 2));
        //Console.WriteLine(N & bitMask);

        bool forthBitValue = false;
        if ((N & bitMask) != 0)
        {
            forthBitValue = true;
        }

        Console.WriteLine("{0}", Convert.ToInt32(forthBitValue));
        
    }
}

