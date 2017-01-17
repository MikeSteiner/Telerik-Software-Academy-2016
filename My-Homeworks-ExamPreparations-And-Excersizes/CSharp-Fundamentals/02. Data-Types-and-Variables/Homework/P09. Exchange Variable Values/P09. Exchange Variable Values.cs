using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. 
    Print the variable values before and after the exchange.  
 
*/

class ExchangeVariableValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
        Console.WriteLine();
        b = a;
        a = a * 2;
        Console.WriteLine("a: {0}", a);
        Console.WriteLine("b: {0}", b);
        

    }
}

