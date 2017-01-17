using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Interval

    Description

    Write a program that reads two positive integer numbers N and M and prints how many numbers exist between them 
    such that the reminder of the division by 5 is 0.
    Input

    On the first two lines you will receive two integers - N on the first and M on the second.
    Output

    Output a single value - the amount of numbers divisible by 5 without remainder.
    Constraints

    0 <= N <= M <= 2000
    Time limit: 0.1s
    Memory limit: 8MB
    Sample tests

Input	Output	Explanation
6
11	1
20
37	3
2
2	0	think why
Submission
*********************************************************************************************/
namespace P11.Interval
{
    class Interval
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int devByFiveCounter = 0;

            for (int i = n+1; i < m; i++)
            {
                bool isDevidableByFive = (i % 5 == 0);
                if (isDevidableByFive)
                {
                    devByFiveCounter++;
                }
            }
            Console.WriteLine("{0}", devByFiveCounter);
        }
    }
}
