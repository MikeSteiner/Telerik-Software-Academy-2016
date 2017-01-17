/*
N Factorial
Description

Write a method that multiplies a number represented as an array of digits by a given integer number. 
Write a program to calculate N!.

Input

On the first line you will receive the number N
Output

Print N!
Constraints

0 <= N <= 100
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
5	120
Submission
 */
using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10.N_Factorial
{
    class Program
    {
        //n n!
        //0	1
        //1	1
        //2	2
        //3	6
        //4	24
        //5	120
        //6	720

        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger nFatorial = CalcFactorial(N);
            Console.WriteLine(nFatorial);

        }
        

        static BigInteger CalcFactorial(int N)
        {
            //long factorial = 1;
            if (N <= 1)
            {
                return 1L;
            }
            
            return N * CalcFactorial(N - 1);
        }
    }
}
