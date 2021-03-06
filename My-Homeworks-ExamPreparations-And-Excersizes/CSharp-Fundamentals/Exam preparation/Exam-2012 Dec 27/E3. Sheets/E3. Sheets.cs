﻿/*
 Problem 3 – Sheets
Asya loves confetti. One day she decided to create exactly N small pieces of sheets with paper size A10.
A10 is a standard for paper sizes. A9 is another standard that is twice as bigger as A10, so A9 can be cut into 2 pieces of size A10. A8 is twice as bigger as A9 and so on. A0 is twice as bigger as A1. See the picture on the left.
Asya has only one sheet of each type (totally 11 sheets). She wants to have exactly N pieces of size A10 by cutting as few sheets as possible.
Asya should not have any wasted sheets.
Write a program for her.
For example if we want to cut sheets into 9 pieces with the size of A10, we will use the only A7 sheet (cut into 8 pieces of size A10) and the only sheet with size A10. Then we will use 2 sheets. All other 9 sheets will not be used.
Input
On the only line of the input there will be the number N.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
Print the sizes of the sheets that will not be used after Asya’s cutting. Print one size on a single line.
The order of the paper sizes doesn’t matter. See the examples below.
Constraints
•	N will be between 0 and 2046, inclusive.
•	Allowed work time for your program: 0.1 seconds. Allowed memory: 16 MB.
Examples
Example
input	Example
output
1
	A9
A8
A7
A6
A5
A4
A3
A2
A1
A0
Example
input	Example
output
9	A9
A8
A6
A5
A4
A3
A2
A1
A0
Example
input	Example
output
666
	A0
A10
A2
A5
A8
A4
Example
input	Example
output
1337
	A1
A3
A4
A8
A9
  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3.Sheets
{
    class Sheets
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            List<string> notusedPaperSizes = new List<string>();

            for (int bit = 0; bit < Convert.ToString(N, 2).PadLeft(11,'0').Length; bit++)
            {
                //bool isOne = ((1 << bit) & N) > 0;
                bool isZero = ((1 << bit) & N) == 0;

                if (isZero)
                {
                    notusedPaperSizes.Add("A" + Math.Abs(bit - 10).ToString());
                }

            }

            //PrintOut
            foreach (string papaerSize in notusedPaperSizes)
            {
                Console.WriteLine(papaerSize);
            }
        }
    }
}
