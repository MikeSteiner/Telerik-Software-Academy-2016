using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Create a program that assigns null values to an integer and to a double variable.

    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.  
 
*/

class NullValuesArithmetic
{
    static void Main(string[] args)
    {
        int? intNull = null;



        int? nullInt = null;
        double? nullDbl = null;
        Console.WriteLine("Int null : {0}", nullInt);
        Console.WriteLine("Double null : {0}", nullDbl);

        nullInt = nullInt + 1;
        nullDbl = nullDbl + 1;
        Console.WriteLine("Int null : {0}", nullInt);
        Console.WriteLine("Double null : {0}", nullDbl);

        nullInt = nullInt - 1;
        nullDbl = nullDbl - 1;
        Console.WriteLine("Int null : {0}", nullInt);
        Console.WriteLine("Double null : {0}", nullDbl);

        nullInt = nullInt * 2;
        nullDbl = nullDbl * 2;
        Console.WriteLine("Int null : {0}", nullInt);
        Console.WriteLine("Double null : {0}", nullDbl);

        nullInt = nullInt / 2;
        nullDbl = nullDbl / 2;
        Console.WriteLine("Int null : {0}", nullInt);
        Console.WriteLine("Double null : {0}", nullDbl);
    }
}

