using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Description

Write a program that reads an integer from the console, uses an expression to check 
if given integer is odd or even, and prints "even NUMBER" or "odd NUMBER", where you should print the input number's value instead of NUMBER.
 
*/

class OddOrEve
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        //int res = input % 2;
        bool isEven = (input % 2 == 0);
        bool isOdd = (Math.Abs(input % 2) == 1);

        if (isEven)
        {
            Console.WriteLine("even {0}", input);
        } else if (isOdd)
        {
            Console.WriteLine("odd {0}", input);
        }
     
    }
}

