using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_CS2__2014._01._24_E
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeralSystemsEx_v2 nS = new NumeralSystemsEx_v2();

            string inLine = Console.ReadLine();
            int stepLen = 1;
            string inLineIn7 = nS.SplitInLine(inLine, stepLen);
            int systemBase7 = 7;
            ulong inLineInDec = nS.AnyToDecimal(inLineIn7, systemBase7);

            Console.WriteLine(inLineInDec);
        }
    }

    class NumeralSystemsEx_v2   //With dinamic step finder method
    {
        public static string[] anySequenceOfDigits = new string[]
        {
            "f",  //0
            "bIN",  //1
            "oBJEC",  //2
            "mNTRAVL",  //3
            "lPVKNQ",  //4
            "pNWE",  //5
            "hT",  //6
            //"ERI",  //7
            //"CAD",  //8
            //"K-A",  //9
            //"IIA",  //10
            //"YLO",  //11
            //"PLA"   //12
        };

        public static string[] hexSequenceOfDigits = new string[]
        {
            "0",    //0
            "1",    //1
            "2",    //2
            "3",    //3
            "4",    //4
            "5",    //5
            "6",    //6
            "7",    //7
            "8",    //8
            "9",    //9
            "A",    //10
            "B",    //11
            "C",    //12
            "D",    //13
            "E",    //14
            "F"     //15
            
        };

        public NumeralSystemsEx_v2()
        {

        }

        public ulong PosPower(ulong x, int p)
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

        //new method from v2
        private int FindDinamicStep(string inLine, int index)
        {
            int dinamicStepLenght = 1;

            char currChar = inLine[index];
            switch (currChar)
            {
                //"f",  //0
                //"bIN",  //1
                //"oBJEC",  //2
                //"mNTRAVL",  //3
                //"lPVKNQ",  //4
                //"pNWE",  //5
                //"hT",  //6

                case 'f':
                    dinamicStepLenght = 1;
                    break;
                case 'b':
                    dinamicStepLenght = 3;
                    break;
                case 'o':
                    dinamicStepLenght = 5;
                    break;
                case 'm':
                    dinamicStepLenght = 7;
                    break;
                case 'l':
                    dinamicStepLenght = 6;
                    break;
                case 'p':
                    dinamicStepLenght = 4;
                    break;
                case 'h':
                    dinamicStepLenght = 2;
                    break;
                default:
                    break;
            }

            return dinamicStepLenght;
        }

        public string SplitInLine(string inLine, int stepLenght)
        {
            string result = "";

            for (int i = 0; i < inLine.Length; i = i + stepLenght)
            {
                //Find current step lenght
                stepLenght = FindDinamicStep(inLine, i);

                string currGroup = inLine.Substring(i, stepLenght);
                for (int j = 0; j < anySequenceOfDigits.Length; j++)
                {
                    bool isSequenceMatch = anySequenceOfDigits[j].Equals(currGroup);
                    if (isSequenceMatch)
                    {
                        result += hexSequenceOfDigits[j];
                        break;
                    }
                }
            }

            return result;
        }


        // convert Any numerical system to Decimal
        // use any system base, 2, 8, 13... up to 16
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
                    //Get the current character in reverse order
                    char currChar = input[input.Length - 1 - i];

                    int currNum;
                    if (Char.IsDigit(currChar))
                    {
                        //If current character is a digit [0-9], 
                        //directly take the int value
                        currNum = (int)Char.GetNumericValue(input[input.Length - 1 - i]);
                    }
                    else
                    {
                        //If current character is not a digit => symbol from A...F, 
                        // convert if and after that take the int value [10 - 15]
                        currNum = ConvertHexLetterToDecNum(currChar.ToString());
                    }

                    //The real conversion with the system base on particular power 0, 1, 2, 3
                    //Example 2pow0 = 1, 2pow1 = 2, 2pow2 = 4 etc...
                    //dec += (ulong)currNum * (ulong)Math.Pow((double)numSystemBase, i);
                    dec += (ulong)currNum * PosPower((ulong)numSystemBase, i);
                }
            }

            return dec;
        }

        public int ConvertHexLetterToDecNum(string letter)
        {
            int dec = 0;

            int n;
            bool isNumeric = int.TryParse(letter, out n);

            if (!isNumeric)
            {
                switch (letter)
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

            return int.Parse(letter);
        }

        public string ConvertDecNumToHexLetter(int number)
        {
            char hexLetter = '0';
            if (number > 9)
            {
                switch (number)
                {
                    case 10:
                        hexLetter = 'A';
                        break;
                    case 11:
                        hexLetter = 'B';
                        break;
                    case 12:
                        hexLetter = 'C';
                        break;
                    case 13:
                        hexLetter = 'D';
                        break;
                    case 14:
                        hexLetter = 'E';
                        break;
                    case 15:
                        hexLetter = 'F';
                        break;
                    default:
                        break;
                }
                return hexLetter.ToString();
            }
            return number.ToString();
        }

        // convert Decimal numerical system to Any numerical system
        // use any system base, 2, 8, 13... up to 16
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
                    string rem = ConvertDecNumToHexLetter((int)(decNumber % targetNumSystemBase));
                    anyNumString = rem + anyNumString;
                    decNumber /= targetNumSystemBase;
                }

                anyNumString = ConvertDecNumToHexLetter((int)decNumber) + anyNumString;

            }

            return anyNumString;
        }

    }
}
