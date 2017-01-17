using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Description

Write a program that does the following:

Reads an integer number from the console.
Stores in a variable if the number can be divided by 7 and 5 without remainder.
Prints on the console "true NUMBER" if the number is divisible without remainder by 7 and 5. 
Otherwise prints "false NUMBER". In place of NUMBER print the value of the input number.

*/

class DivideBy7and5
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        bool isDivisiableBySeven = (input % 7 == 0);
        bool isDivisiableByFive = (input % 5 == 0);

        if (isDivisiableBySeven && isDivisiableByFive)
        {
            Console.Write("true ");
        }
        else
        {
            Console.Write("false ");
        }
        Console.Write(input);
        Console.WriteLine();
    }
}

