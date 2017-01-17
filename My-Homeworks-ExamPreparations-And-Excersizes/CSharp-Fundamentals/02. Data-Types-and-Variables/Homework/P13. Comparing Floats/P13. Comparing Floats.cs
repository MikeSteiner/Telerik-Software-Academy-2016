using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Write a program that safely compares two floating-point numbers (double) with precision eps = 0.000001.

    Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. 
    Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps  
 
*/

static class ComparingFloats
{
    
    
    static void Main(string[] args)
    {
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double eps = 0.000001d;

        double precision = Math.Abs(a - b);

        
        string epsStr = eps.ToString("0.000000");
        string precisionStr = precision.ToString("0.000000");

        bool areEqual = (precision < eps);
        bool isBorderCase = (epsStr.Equals(precisionStr));
        string areEqualStr = FirstLetterToLower(areEqual.ToString());



        if (areEqual)
        {
            Console.WriteLine(areEqualStr);
            //Console.WriteLine("The difference {0} < {1}", precision, eps);
        }
        else if (isBorderCase)
        {
            Console.WriteLine(areEqualStr);
            //Console.WriteLine("Border case {0} = {1}", precision, eps);
        }
        else
        {
            Console.WriteLine(areEqualStr);
            //Console.WriteLine("The difference is too big {0} > {1}", precision, eps);
        }

    }

    public static bool NearlyEquals(this double? value1, double? value2, double precision = 0.000001d)
    {
        if (value1 != value2)
        {
            if (value2 == null || value2 == null)
            {
                return false;
            }
            return Math.Abs(value1.Value - value2.Value) < precision;
        }
        return true;
    }

    public static string FirstLetterToLower(string str)
    {
        if (str == null)
            return null;

        if (str.Length > 1)
            return char.ToLower(str[0]) + str.Substring(1);

        return str.ToUpper();
    }
}


