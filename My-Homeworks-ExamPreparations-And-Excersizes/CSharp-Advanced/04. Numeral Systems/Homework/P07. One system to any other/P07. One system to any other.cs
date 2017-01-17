/*
Input

On the first line you will receive the number s
On the second line you will receive a number in base s - N
There will not be leading zeros
On the third line you will receive the number d
Output

Print N in base d
There should not be leading zeros
Use uppercase letters
Constraints

2 <= s, d <= 16
1 <= N <= 1018
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input   Output
13
16
9	
Output
21

Input
16
1E34
10
Output
7732

Input
2
10011
16
Output
13

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07.One_system_to_any_other
{
    class Program
    {
        static void Main(string[] args)
        {
            int fromNumSystemBase = int.Parse(Console.ReadLine());
            string anyNumString = Console.ReadLine();
            int targetNumSystemBase = int.Parse(Console.ReadLine());

            NumeralSystems nS = new NumeralSystems();

            ulong decNum = nS.AnyToDecimal(anyNumString, fromNumSystemBase);
            string anyNum = nS.DecimalToAny(decNum, (ulong)targetNumSystemBase);
            Console.WriteLine(anyNum);


        }
    }

    class NumeralSystems
    {
        public NumeralSystems()
        {
        }

        public ulong PositivePow(ulong x, int p)
        {
            ulong result = 1UL;

            if (p <= 0)
            {
                return result;
            }
            //Loop the pow
            for (int i = 1; i <= p; i++)
            {
                result *= x;
            }
            
            return result;
        }

        //**** Any System from/to Decimal
        public ulong AnyToDecimal(string input, int numSystemBase)
        {
            ulong dec = 0UL;

            if (input == "0")
            {
                return 0UL;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int currNum;
                    char currChar = input[input.Length - 1 - i];
                   
                        
                    if (Char.IsDigit(currChar))
                    {
                        currNum = (int)Char.GetNumericValue(input[input.Length - 1 - i]);
                    }
                    else
                    {
                        currNum = CheckCharAndConvToDecNum(currChar.ToString());
                    }

                    //dec += (ulong)currNum * (ulong)Math.Pow((double)numSystemBase, i);
                    dec += (ulong)currNum * PositivePow((ulong)numSystemBase, i);
                }
            }

            return dec;
        }

        public int CheckCharAndConvToDecNum(string charStr)
        {
            int dec = 0;

            int n;
            bool isNumeric = int.TryParse(charStr, out n);

            if (!isNumeric)
            {
                switch (charStr)
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

            return int.Parse(charStr);
        }

        public string DecimalToAny(ulong decNumber, ulong targetNumSystemBase)
        {
            string anyNumString = "";

            if (decNumber == 0)
            {
                return "0";
            }
            else
            {
                while (decNumber > targetNumSystemBase - 1)
                {
                    string rem = ConvertHexReminder((int)(decNumber % targetNumSystemBase));
                    anyNumString = rem + anyNumString;                    
                    decNumber /= targetNumSystemBase;
                }

                anyNumString = ConvertHexReminder((int)decNumber) + anyNumString;

            }

            return anyNumString;
        }


        //**** Decimal to Binary
        public string DecimalToBinary(ulong input)
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
        public string DecimalToHex(ulong input)
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
                    ulong currNum = (ulong)HexLettersToDecNums(input[input.Length - 1 - i].ToString());
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
