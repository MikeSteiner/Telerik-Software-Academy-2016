using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
    34.567839023, 12.345, 8923.1234857, 3456.091? 
    Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 
*/

class FloatOrDouble
{
    static void Main(string[] args)
    {
        decimal varOne = 34.567839023m;
        float varTwo = 12.345f;
        decimal varTree = 8923.1234857m;
        double varFour = 3456.091d;
        
        Console.WriteLine("Var: {0}; MaxValue: {1}", varOne, decimal.MaxValue);
        Console.WriteLine("Var: {0}; MaxValue: {1}", varTwo, float.MaxValue);
        Console.WriteLine("Var: {0}; MaxValue: {1}", varTree, double.MaxValue);
        Console.WriteLine("Var: {0}; MaxValue: {1}", varFour, float.MaxValue);        
    }
}

