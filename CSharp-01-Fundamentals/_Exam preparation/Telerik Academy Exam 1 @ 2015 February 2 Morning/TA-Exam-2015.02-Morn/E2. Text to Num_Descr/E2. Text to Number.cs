using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
/*
    Problem 2 – Text to Number

    You are given a text and a number (M). This text can contain digits, Latin letters (both capital and letter case) and any other symbols, except for '@'. The number is used to the parsing of the text.
    Your task is to go through all characters of the text and, starting from RESULT = 0, to perform the following operations:
    •	If the current character is '@', stop the program and print the RESULT
    •	If the current character is a digit (0-9), then multiply the RESULT by this digit
    •	If the current character is a letter, add its number from the Latin alphabet to RESULT. 'A' is with number 0
    •	If the current character is a symbol, that is different from the ones above, create module of the RESULT by the provided number (M)
    Input
    The input data is given at the standard input. 
    It consists of two lines:
    •	The first one contains the number M, that is used for the module of the result
    •	The second line contains the text
    The input will be valid, in the specified format, within the constraints given below. There is no need to check the input data explicitly.
    Output
    Print the result from the parsing (RESULT)
    Constraints
    •	M will always be between 2000 and 10 000
    •	The length of the text will always be less than 100 000
    •	Allowed working time for your program: 0.5 seconds.
    •	Allowed memory: 16 MB.
Example
2001
Hello .NET 5! My name is Peter 8-)@	518	RESULT = 0 + 7(H) = 7
RESULT = 7 + 4(e) = 11
RESULT = 11 + 11(l) = 22
RESULT = 22 + 11(l) = 33
RESULT = 33 + 14(o) = 47
RESULT = 47 % 2001( ) = 47
RESULT = 47 % 2001(.) = 47
RESULT = 47 + 13(N) = 60
RESULT = 60 + 4(E) = 64
RESULT = 64 + 19(T) = 83
RESULT = 83 % 2001( ) = 83
RESULT = 83 * 5(5) = 415
RESULT = 415 % 2001(!) = 415
RESULT = 415 % 2001( ) = 415
RESULT = 415 + 12(M) = 427
RESULT = 427 + 24(y) = 451
RESULT = 451 % 2001( ) = 451
RESULT = 451 + 13(n) = 464
RESULT = 464 + 0(a) = 464
RESULT = 464 + 12(m) = 476
RESULT = 476 + 4(e) = 480
RESULT = 480 % 2001( ) = 480
RESULT = 480 + 8(i) = 488
RESULT = 488 + 18(s) = 506
RESULT = 506 % 2001( ) = 506
RESULT = 506 + 15(P) = 521
RESULT = 521 + 4(e) = 525
RESULT = 525 + 19(t) = 544
RESULT = 544 + 4(e) = 548
RESULT = 548 + 17(r) = 565
RESULT = 565 % 2001( ) = 565
RESULT = 565 * 8(8) = 4520
RESULT = 4520 % 2001(-) = 518
RESULT = 518 % 2001()) = 518

*/

//2001
//Hello .NET 5! My name is Peter 8-)@
namespace E2.TextToNumber
{
    class TextToNumber
    {
        static void Main(string[] args)
        {
            //Input
            int num = int.Parse(Console.ReadLine());
            string inLine = Console.ReadLine();
            //int indexOfEnd = inLine.IndexOf('@');
            inLine = inLine.Substring(0, inLine.IndexOf('@'));
            
            //2001
            //Hello .NET 5! My name is Peter 8-)@	518	RESULT = 0 + 7(H) = 7

            long result = 0;


            for (int i = 0; i < inLine.Length; i++)
            {
                char currentChar = inLine[i];
                bool isLetter = (currentChar >= 65 && currentChar <= 90) || (currentChar >= 97 && currentChar <= 122);
                bool isDigit = (currentChar >= 48 && currentChar <= 57);
                bool isOther = !isLetter && !isDigit;
                                     

                long resOld = result;
                string tmpSym = "";
                long value = 0;

                if (isLetter)
                {                    
                    int letterValue = 0;
                    for (char ch = 'a'; ch <= 'z'; ch++)
                    {
                        if(ch == Convert.ToChar(currentChar.ToString().ToLower()))
                        {
                            break;
                        }
                        letterValue++;
                    }
                    result = result + (long)(letterValue);
                    tmpSym = "+";
                }
                else if (isDigit)
                {
                    //long value;
                    value = int.Parse(currentChar.ToString());
                    result = result * (long)value;
                    tmpSym = "*";
                }
                else if (isOther)
                {                    
                    result = result % (long)num;
                    tmpSym = "%";
                }
                //Console.Write("Res {0} = {1} {2} {3} ('{4}')", result, resOld, tmpSym, value, currentChar);
                //Console.WriteLine();
            }
            Console.WriteLine(result);

        }
    }
}
