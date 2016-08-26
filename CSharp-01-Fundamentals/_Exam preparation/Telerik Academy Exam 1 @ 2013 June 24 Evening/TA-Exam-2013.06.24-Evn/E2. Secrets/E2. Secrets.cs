/*
 * Problem 2 – The Secrets of Numbers
The special sum of a number is the sum of its digits calculated by the following algorithm:
•	Each digit with odd position from right to left adds to the special sum its value multiplied by the square of its position in the number.
•	Each digit with even position from right to left adds to the special sum the square of its value multiplied by its position in the number.
For example if the number is 37 its special sum is 7 * 12 + 32 * 2 = 25. Another example: if the number is 111 its special sum is 1 * 12 + 12 * 2 + 1 * 32 = 12.
The secret alpha-sequence of a number is a sequence of capital letters from the English alphabet constructed by the number’s special sum. The length of the sequence is indicated by the last digit of the number’s special sum. If this length is 0 the number has no secret alpha-sequence. 
The number R represents the remainder of a number’s special sum divided by the number of letters in the alphabet (26). The first letter of the alpha-sequence is the letter from the English alphabet at position equal to the sum R + 1. Every next letter in the secret alpha-sequence is the next letter of the alphabet. If the last letter (‘Z’) is reached the sequence afterwards continues from the first letter of the alphabet (‘A’).
For example if the special sum of a number is 3, its secret alpha-sequence is “DEF”. Another example: if the special sum of a number is 48 its secret alpha-sequence is “WXYZABCD”.
Write a program that finds the special sum and the secret alpha-sequence of an integer number N.
Input
The input data should be read from the console. The only input line contains the integer number N to which the secret alpha-sequence is to be found. The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console. The output consists of two lines. On the first output line you must print input number’s special sum and on the second output line you must print its secret alpha-sequence or indicate its absence in format: “X has no secret alpha-sequence” where ‘X’ is the input number.
Constraints
•	The integer number N will have no more than 400 digits.
•	Allowed working time for your program: 0.1 seconds.
•	Allowed memory: 16 MB.

Examples
Input	Output		Input	Output		Input	Output
3	3
DEF		22	10
22 has no secret alpha-sequence		424	48
WXYZABCD


 */
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2.Secrets
{
    class Program
    {
        public static BigInteger SpecialSum(BigInteger number)
        {
            if (number<0)
            {
                number *= (-1);
            }
            BigInteger sum = 0;
            int reminder = 1;
            // 123
            for (int pos = 1; number > 0; pos++)
            {
                bool isEvenPos = (pos % 2 == 0);
                bool isOddPos = (pos % 2 == 1);

                reminder = (int)(number % 10);
                number = number / 10;

                if (isOddPos)
                {
                    sum += reminder * (int)Math.Pow(pos, 2);
                }
                else if (isEvenPos)
                {
                    sum += (int)Math.Pow(reminder, 2) * pos;
                }                
            }

            return sum;
        }

        public static int SecretAlphaLenght(BigInteger spSum)
        {         
            int secretAlphaLenght = 0;
            if (spSum % 10 > 0)
            {
                secretAlphaLenght = (int)(spSum % 10);
            }
            return secretAlphaLenght;
        }

        public static int SecretAlphaFirstLetter(BigInteger spSum)
        {
            int R = (int)spSum % 26;
            if (R > 26)
            {
                R -= 26;
            }
            int fL = 'A' + R - 1;
            
            return fL;
        }

        //*******************

        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(Console.ReadLine());
            //Specisl sum calulation
            BigInteger spSum = SpecialSum(N);
            Console.WriteLine(spSum);            

            string secretAlpha = "";

            //Special alpha sequence lenght calculation
            int secretAlphSeqLenght = SecretAlphaLenght(spSum);            
            
            //Special alpha sequence             
            if (secretAlphSeqLenght > 0)
            {
                //Special alpha sequence find first letter                 
                int fL = SecretAlphaFirstLetter(spSum);
                //char firstLetter = (char)fL;
                               
                for (int i = 0; i < secretAlphSeqLenght; i++)
                {
                    fL += 1;
                    if (fL > 90)
                    {
                        fL = 'A';
                    }
                    char firstLetter = (char)fL;
                    secretAlpha += firstLetter;                    
                }
                Console.WriteLine(secretAlpha);
            }
            else
            {
                Console.WriteLine("{0} has no secret alpha-sequence", N);
            }

        }
    }
}
