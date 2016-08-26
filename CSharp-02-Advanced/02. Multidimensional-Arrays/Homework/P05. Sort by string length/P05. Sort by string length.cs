/*
Sort by string length
Description

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

Submission

You do not have to submit anything for this problem
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Sort_by_string_length
{
    class SortByStringLength
    {
        static void Main(string[] args)
        {
            //string inLine = Console.ReadLine();
            string inLine = "You are given an array of strings. Write a method that sorts the array by the length of its elements";
            string[] inputStrings = inLine.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            inputStrings = inputStrings.OrderBy(s => s.Length).ToArray();

            Console.WriteLine(string.Join("-", inputStrings));
        }
    }
}
