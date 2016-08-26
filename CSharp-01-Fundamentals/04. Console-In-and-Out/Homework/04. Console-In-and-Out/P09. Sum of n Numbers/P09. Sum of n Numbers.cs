using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Sum of N Numbers

    Description

    Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.

    Note: You may need to use a for-loop.
    Input

    On the first line, you will receive the number N
    On each of the next N lines, you will receive a floating-point number
    Output

    On must output only one number - the sum of the N numbers
    Constraints

    1 <= N <= 200
    All numbers will be valid floating-point numbers in the range [-1000, 1000]
    Time limit: 0.1s
    Memory limit: 8MB
    Sample tests

Input	Output
3
20
60
10	90
5 
2 
-1 
-0,5
4
2   6,5
1 
1	1

*********************************************************************************************/
namespace P09.Sum_of_n_Numbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            float sum = 0f;

            for (int i = 0; i < n; i++)
            {
                sum = sum + float.Parse(Console.ReadLine());
            }

            Console.WriteLine("{0}", sum);
        }
    }
}
