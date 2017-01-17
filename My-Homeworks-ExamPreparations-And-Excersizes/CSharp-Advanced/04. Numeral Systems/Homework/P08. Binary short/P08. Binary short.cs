/*
 Binary short
Description

Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).

Input

On the only line you will receive a decimal number - N
Output

Print the its binary representation on a single line
There should be exactly 16 digits of output
Constraints

-215 <= N < 215
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
11	0000000000001011
-11	1111111111110101

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P08.Binary_short
{
    class Program
    {
        static void Main(string[] args)
        {
            short N = short.Parse(Console.ReadLine());

            //Console.WriteLine(DecimalToBinaryBuildIn(N).PadLeft(16, '0'));
            Console.WriteLine(DecimalShortSignToBinary(N));

        }

        public static string DecimalShortSignToBinary(short input)
        {
            string bin = "";
            bool isPositive = (input > 0);
            //Zero
            if (input == 0)
            {
                bin = bin.PadLeft(16, '0'); ;
            }
            else
            {
                //Positive
                if (isPositive)
                {
                    while (input > 0)
                    {
                        bin = input % 2 + bin;
                        input /= 2;
                    }
                    bin = bin.PadLeft(16, '0');
                }
                //Negative
                else if (!isPositive)
                {
                    //Forward
                    //input *= -1;
                    //Console.WriteLine(Convert.ToString(input, 2));
                    //input = (short)~input;
                    //Console.WriteLine(Convert.ToString(input, 2));
                    //input += 1;
                    //Console.WriteLine(Convert.ToString(input, 2));

                    byte[] bytes = BitConverter.GetBytes(input);
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        bin = Convert.ToString(bytes[i], 2).PadLeft(8, '0') + bin;
                    }
                }
            }
            

            return bin;
        }

        public static string DecimalToBinaryBuildIn(short input)
        {
            string bin = Convert.ToString(input, 2);
            return bin;
        }

    }
}



//using System;

//class BinaryShort
//{
//    static void Main()
//    {
//        short input = short.Parse(Console.ReadLine());

//        string inputToBinary = ShortToBinary(input);

//        Print the result in the following manner: the first bit is the sign(0 for positive, 1 for negative)
//                the next 15 bits are for the number
        

//                Console.WriteLine(inputToBinary);
//    }
//    static string ShortToBinary(short number)
//    {
//        byte[] bytesInput = BitConverter.GetBytes(number); //get the number as an array of 4 bytes
//        string inputToBinary = "";
//        for (int i = 0; i < bytesInput.Length; i++) //convert each byte to its binary representation and pad
//        {                                           //with zeroes to get 8 bits for each byte
//            inputToBinary = Convert.ToString(bytesInput[i], 2).PadLeft(8, '0') + inputToBinary;
//        }
//        return inputToBinary;
//    }
//}
