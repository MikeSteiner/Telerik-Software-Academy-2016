/*
Problem 3 – Ones and Zeros
You are given a non-negative integer number N. Your task is to print the last 16 bits of the binary representation of N on the console. Every bit is printed in a rectangular area with 5 rows and 3 columns. 

A bit with value of 1 should be printed in the format:
.#.
##.
.#. 
.#.
###

A bit with value of 0 should be printed in the format:
###
#.#
#.#
#.#
###

Between every single bit there should be an empty column containing only dots (".").
Input
The input data should be read from the console.
On the only input line there will be a non-negative integer number N which bits must be printed on the console.
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output should be printed on the console.
You should print the last 16 bits of N on the console in the described format.
Your output should contain exactly 5 lines with 63 symbols on each line. Symbols should be only hashes ("#") and dots (".").
Constraints
•	The number N will be a non-negative integer number between 0 and 2147483647, inclusive.
•	The only C# Console methods that you are allowed to use are Console.Write() and Console.WriteLine(). This means that Console.SetCursorPosition() will not work. 
•	Allowed working time for your program: 0.10 seconds.
•	Allowed memory: 16 MB.


Examples
Input example	Output example
1
	
###.###.###.###.###.###.###.###.###.###.###.###.###.###.###..#.
#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.##.
#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#..#.
#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#.#..#.
###.###.###.###.###.###.###.###.###.###.###.###.###.###.###.###

1234
	
###.###.###.###.###..#..###.###..#...#..###..#..###.###..#..###
#.#.#.#.#.#.#.#.#.#.##..#.#.#.#.##..##..#.#.##..#.#.#.#.##..#.#
#.#.#.#.#.#.#.#.#.#..#..#.#.#.#..#...#..#.#..#..#.#.#.#..#..#.#
#.#.#.#.#.#.#.#.#.#..#..#.#.#.#..#...#..#.#..#..#.#.#.#..#..#.#
###.###.###.###.###.###.###.###.###.###.###.###.###.###.###.###

65535
	
.#...#...#...#...#...#...#...#...#...#...#...#...#...#...#...#.
##..##..##..##..##..##..##..##..##..##..##..##..##..##..##..##.
.#...#...#...#...#...#...#...#...#...#...#...#...#...#...#...#.
.#...#...#...#...#...#...#...#...#...#...#...#...#...#...#...#.
###.###.###.###.###.###.###.###.###.###.###.###.###.###.###.###


 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3.Ones_and_Zeros
{
    class ModifyBitsU
    {
        ulong _value;

        public ModifyBitsU(ulong value)
        {
            _value = value;
        }

        public ulong Value
        {
            get
            {
                return _value;
            }
            set
            {
                _value = value;
            }
        }


        public bool GetBitValue(int pos)
        {
            ulong bitMask = (1UL << pos);// (1 << pos);
            bool bitValue = false;
            if ((_value & bitMask) != 0)
            {
                bitValue = true;
            }

            return bitValue;
        }

        public void SetBitValue(int pos, bool setValue)
        {
            ulong bitMask = (1UL << pos);

            if (setValue)
            {
                _value = _value | bitMask;
            }
            else
            {
                bitMask = ~bitMask;
                _value = _value & bitMask;
            }
        }
    }

    static class OnesAndZeros
    {
        public static StringBuilder[] oz = new StringBuilder[5];
        
        public static void WriteOneOrZero(bool value)
        {
            if (value)
            {                
                bool isEmpty = oz[0] == null;

                if(isEmpty)
                {
                    oz[0] = new StringBuilder(".#.");
                    oz[1] = new StringBuilder("##.");
                    oz[2] = new StringBuilder(".#.");
                    oz[3] = new StringBuilder(".#.");
                    oz[4] = new StringBuilder("###");
                }
                else{
                    oz[0].Append(".#.");
                    oz[1].Append("##.");
                    oz[2].Append(".#.");
                    oz[3].Append(".#.");
                    oz[4].Append("###");
                }
                
            }
            else
            {
                //oz[0].Append("###");
                //oz[1].Append("#.#");
                //oz[2].Append("#.#");
                //oz[3].Append("#.#");
                //oz[4].Append("###");

                bool isEmpty = oz[0] == null;

                if (isEmpty)
                {
                    oz[0] = new StringBuilder("###");
                    oz[1] = new StringBuilder("#.#");
                    oz[2] = new StringBuilder("#.#");
                    oz[3] = new StringBuilder("#.#");
                    oz[4] = new StringBuilder("###");
                }
                else
                {
                    oz[0].Append("###");
                    oz[1].Append("#.#");
                    oz[2].Append("#.#");
                    oz[3].Append("#.#");
                    oz[4].Append("###");
                }
            }
            
            
        }

        public static void WriteSpace()
        {
            oz[0].Append(".");
            oz[1].Append(".");
            oz[2].Append(".");
            oz[3].Append(".");
            oz[4].Append(".");            
        }

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            ModifyBitsU mbu = new ModifyBitsU((ulong)N);

            for (int i = 15; i >= 0; i--)
            { 
                WriteOneOrZero(mbu.GetBitValue(i));
               
                if (i > 0)
                {
                    WriteSpace();
                }
            }

            //Print out
            foreach (var line in oz)
            {
                Console.WriteLine(line);
            }

        }
    }
}
