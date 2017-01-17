using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Fibonacci Numbers

    Description

    Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

    Input

    On the only line you will receive the number N
    Output

    On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)
    Constraints

    1 <= N <= 50
    N will always be a valid positive integer number
    Time limit: 0.1s
    Memory limit: 8MB
    Sample tests

Input	Output
1	0
3	0, 1, 1
10	0, 1, 1, 2, 3, 5, 8, 13, 21, 34

*********************************************************************************************/
namespace P10.Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] fibNumbers = new long[51];
            fibNumbers[0] = 0;
            fibNumbers[1] = 0;
            fibNumbers[2] = 1;

            for (int i = 3; i < fibNumbers.Length; i++)
            {
                fibNumbers[i] = fibNumbers[i - 1] + fibNumbers[i - 2];
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}", fibNumbers[i]);
                if(i != n)
                {
                    Console.Write(", ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
