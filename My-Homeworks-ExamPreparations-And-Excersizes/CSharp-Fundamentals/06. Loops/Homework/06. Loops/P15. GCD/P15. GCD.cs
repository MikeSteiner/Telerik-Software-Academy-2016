using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    GCD

    Description

    Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.

    Use the Euclidean algorithm (find it in Internet).
    Input

    On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.
    Output

    Output a single number - the GCD of the numbers A and B.
    Constraints

    The numbers A and B will always be valid integers in the range [2, 500].
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
3 2	1
60 40	20
5 -15	5

**************************************************************/
namespace P15.GCD
{
    // My code is 90 if 100
    class GCD
    {
        static void Main(string[] args)
        {

            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int a = nums[0];
            int b = nums[1];
            int temp;
            //set a as the greather value a=max(a, b)
            if (b >= a)
            {
                temp = b;
                b = a;
                a = temp;
            }

            while (true)
            {
                temp = b;
                b = a % b;
                a = temp;

                if (b == 0)
                {
                    break;
                }
            }
            Console.WriteLine(a);
        }
    }
}
    
            //Working code from https://github.com/owolp/Telerik-Academy/blob/master/Modul-1/CSharp-Part-1/06-Loops/15.GCD/GCD.cs
            //90 of 100 :)
            //using System;

            //namespace GCD
            //    {
            //        class GCD
            //        {
            //            static void Main()
            //            {
            //                string[] stringNumbersArray = Console.ReadLine().Split(' ');

            //                int a = Convert.ToInt32(stringNumbersArray[0]);
            //                int b = Convert.ToInt32(stringNumbersArray[1]);

            //                int max = Math.Max(a, b);
            //                int min = Math.Min(a, b);
            //                int gcd = max % min;

            //                while (max > 0 || min > 0 || gcd > 0)
            //                {
            //                    max = Math.Max(min, gcd);
            //                    min = Math.Min(min, gcd);
            //                    if (max % min <= 0)
            //                    {
            //                        break;
            //                    }
            //                    else
            //                    {
            //                        gcd = max % min;
            //                    }
            //                }

            //                Console.WriteLine(gcd);
            //            }
            //        }
            //    }
        

