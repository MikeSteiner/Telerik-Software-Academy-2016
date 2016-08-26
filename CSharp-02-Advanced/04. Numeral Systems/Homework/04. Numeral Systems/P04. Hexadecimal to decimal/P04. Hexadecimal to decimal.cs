/*
Hexadecimal to decimal
Description

Write a program that converts a hexadecimal number N to its decimal representation.

Input

On the only line you will receive a hexadecimal number - N
There will not be leading zeros
Letters will be uppercase
Output

Print the decimal representation of N on a single line
There should not be leading zeros
Constraints

1 <= N <= 1018 = DE0B6B3A7640000(16)
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
13	19

1E34 7732
Submission

Submit your code here
You do not have to submit anything for this problem
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04.Hexadecimal_to_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            string inLine = Console.ReadLine();
            NumeralSystems nS = new NumeralSystems();

            Console.WriteLine(nS.HexToDecimal(inLine));
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

        public string DecimalToBinaryBuildIn(long input)
        {
            string bin = Convert.ToString(input, 2);
            return bin;
        }

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

        public ulong BinaryToDecimalBuildIn(string input)
        {
            return Convert.ToUInt64(input, 2);
        }

        //**** Decimal to Hexadecimal
        public string DecimalToHex(long input)
        {
            string hex = "";

            if (input == 0)
            {
                return "0";
            }
            else
            {
                while (input > 15)
                {
                    string rem = ConvertHexReminder((int)(input % 16L));
                    hex = rem + hex;
                    input /= 16;
                }
                hex = ConvertHexReminder((int)input) + hex;
            }

            return hex;
        }

        public string ConvertHexReminder(int reminder)
        {
            char hexReminder = '0';
            if (reminder > 9)
            {
                switch (reminder)
                {
                    case 10:
                        hexReminder = 'A';
                        break;
                    case 11:
                        hexReminder = 'B';
                        break;
                    case 12:
                        hexReminder = 'C';
                        break;
                    case 13:
                        hexReminder = 'D';
                        break;
                    case 14:
                        hexReminder = 'E';
                        break;
                    case 15:
                        hexReminder = 'F';
                        break;
                    default:
                        break;
                }
                return hexReminder.ToString();
            }
            return reminder.ToString();
        }   

        public string DecimalToHexBuildIn(long input)
        {
            string hex = "";

            hex = Convert.ToString(input, 16).ToUpper();

            return hex;
        }

        // Hex to Decimal
        public ulong HexToDecimal(string input)
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
                    ulong currNum = (ulong)HexLettersToDecNums(input[input.Length -1 - i].ToString());
                    dec += currNum * (ulong)Math.Pow((double)16, i);
                }
            }

            return dec;
        }

        public int HexLettersToDecNums(string hexValue)
        {
            int dec = 0;

            int n;
            bool isNumeric = int.TryParse(hexValue, out n);

            if (!isNumeric)
            {
                switch (hexValue)
                {
                    case "A":
                        dec = 10;
                        break;
                    case "B":
                        dec = 11;
                        break;
                    case "C":
                        dec = 12;
                        break;
                    case "D":
                        dec = 13;
                        break;
                    case "E":
                        dec = 14;
                        break;
                    case "F":
                        dec = 15;
                        break;
                    default:
                        break;
                }
                return dec;
            }

            return int.Parse(hexValue);
        }

        public ulong HexToDecimalBuildin(string input)
        {
            ulong dec = 0L;            
            dec = Convert.ToUInt64(input, 16);           

            return dec;
        }


    }
}
