using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/********************************************************************************
    Digit as Word

    Description

    Write a program that read a digit (0-9) from the console, and depending on the input, shows the digit as a word (in English).

    Print "not a digit" in case of invalid input.
    Use a switch statement.
    Input

    The input consists of one line only, which contains the digit.
    Output

    Output a single line - should the input be a valid digits, print the english word for the digits. Otherwise, print "not a digit".
    Constraints

    The input will never be an empty line.
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
-0,1	not a digit
1	one
9	nine
-9	not a digit
kek	not a digit
     
********************************************************************************/

namespace P08.Digit_as_Word
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int value = 0;            
            string output = "";
            /**********************
            bool isValid = Int32.TryParse(input, out value);
            **********************/

            //string pattern = @"\d";
            string pattern = @"[0-9]";
            Regex r = new Regex(pattern);
            var m = r.Matches(input);
            
            bool isValid = r.IsMatch(input) && (m.Count == 1) && (input.Length == 1);
            //int mCout = m.Count;
            //string firstM = m[0].Value;
            //string secondM = m[1].Value;
            //string thirdM = m[2].Value;
            //***********************/
            if (isValid)
            {
                //value = int.Parse(r.Match.value);
                value = int.Parse(m[0].Value);

                switch (value)
                {
                    case 0:
                        output = "zero";
                        break;
                    case 1:
                        output = "one";
                        break;
                    case 2:
                        output = "two";
                        break;
                    case 3:
                        output = "three";
                        break;
                    case 4:
                        output = "four";
                        break;
                    case 5:
                        output = "five";
                        break;
                    case 6:
                        output = "six";
                        break;
                    case 7:
                        output = "seven";
                        break;
                    case 8:
                        output = "eight";
                        break;
                    case 9:
                        output = "nine";
                        break;
                    default:
                        output = "not a digit";
                        break;
                }
            }
            else
            {
                output = "not a digit";
            }

            Console.WriteLine(output);    

        }
    }
}

