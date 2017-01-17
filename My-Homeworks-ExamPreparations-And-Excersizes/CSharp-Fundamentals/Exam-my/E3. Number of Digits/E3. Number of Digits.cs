
/*
Number of Pages

Description

A book has N pages, numbered from 1 to N (1, 2, 3, ... N - 1, N).

The total number of digits in the page numbers is D.

Write a program to find the number D by given number of pages (N).

Input
•On the only input line, there will be the number - N - the number of the pages in the book.
•The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
•On the only output line, write the number D (the number of digits used for numbering the book pages)

Constraints
• 1 < N < 1,000,000 
•Allowed working time for your program: 0.1s 
•Allowed memory: 16MB 

Sample tests


Input

Output


4 4 
100 192 
1990 6853 
185184 999999 

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3.Number_of_Digits_Description
{
    class NmberOfPages
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int digits = 0;

            for (int i = pages.ToString().Length -1 ; i >= 0; --i)
            {
                
                int currentIterPages = pages - ((int)Math.Pow(10, i) - 1);
                digits += currentIterPages * (i + 1);
                pages = pages - currentIterPages;
            }
            Console.WriteLine(digits);
        }
    }
}
