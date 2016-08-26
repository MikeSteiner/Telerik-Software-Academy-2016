/*
Index of letters
Description

Write a program that creates an array containing all letters from the alphabet (a-z). Read a word from the console and print the index of each of its letters in the array.

Input

On the first line you will receive the word
Output

Print the index of each of the word's letters in the array
Each index should be on a new line
Constraints

1 <= word length <= 128
Word is consisted of lowercase english letters
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
telerikacademy	

19
4
11
4
17
8
10
0
2
0
3
4
12
24
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12.Index_of_letters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            //Fill out alphabet array
            char[] alphabet = new char[26];     
            int i = 0;
            for (char ch = 'a'; ch <= 'z'; ch++, i++)
            {
                alphabet[i] = ch;
            }

            string inLine = Console.ReadLine();

            //Process input word
            for (int j = 0; j < inLine.Length; j++)
            {
                char currLetter = Convert.ToChar(inLine[j].ToString().ToLower());
                //-- I
                //int letterIx = Array.IndexOf(alphabet, currLetter);
                //Console.WriteLine(letterIx);

                //-- II
                for (int x = 0; x < alphabet.Length; x++)
                {
                    if (alphabet[x] == currLetter)
                    {
                        Console.WriteLine(x);
                        break;
                    }
                }
                
            }
            
        }
    }
}
