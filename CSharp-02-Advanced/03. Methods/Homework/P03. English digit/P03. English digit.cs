/*
 * English digit
Description

Write a method that returns the last digit of given integer as an English word. 
Write a program that reads a number and prints the result of the method.

Input

On the first line you will receive a number
Output

Print the last digit of the number as an English word
Constraints

Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
42	two
Submission
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.English_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string output = ConvertDigitToEnWord(ReturnLastDigit(num));
            Console.WriteLine(output);

        }

        static int ReturnLastDigit(int value)
        {
            int lastDigit = -1;
            int lD = (value % 10);
            if (0 <= lD && lD <= 9)
            {
                lastDigit = lD;
            }
            
            return lastDigit;
        }
       
        static string ConvertDigitToEnWord(int digit)
        {
            string enWord = "Not Found";

            string[] digitsEnWords = new string[11];
            digitsEnWords[0] = "zero";
            digitsEnWords[1] = "one";
            digitsEnWords[2] = "two";
            digitsEnWords[3] = "three";
            digitsEnWords[4] = "four";
            digitsEnWords[5] = "five";
            digitsEnWords[6] = "six";
            digitsEnWords[7] = "seven";
            digitsEnWords[8] = "eight";
            digitsEnWords[9] = "nine";

            for (int i = 0; i < digitsEnWords.Length; i++)
            {
                if (i == digit)
                {
                    enWord = digitsEnWords[i];
                    break;
                }                
            }

            return enWord;
        }
    }
}
