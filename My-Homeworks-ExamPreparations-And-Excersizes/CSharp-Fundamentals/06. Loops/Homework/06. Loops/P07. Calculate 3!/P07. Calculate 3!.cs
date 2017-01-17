using System;
using System.Numerics;
/**************************************************************
    Calculate 3!

    Description

    In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

    Try to use only two loops.
    Input

    On the first line, there will be only one number - N
    On the second line, there will also be only one number - K
    Output

    On the only output line, write the result of the calculation for the provided N and K
    Constraints

    1 < K < N < 100
    Hint: overflow is possible
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
3 
2	3
4 
2	6
10
6	210
52
5	2598960

**************************************************************/

class Calculate3Factorial
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
            
        BigInteger nFactorial = 1UL;
        BigInteger kFactorial = 1UL;
        BigInteger nkFactorial = 1UL;

        for (int i = 1; i <= n; i++)
        {
            nFactorial = nFactorial * i;
            if (i <= k)
            {
                kFactorial = kFactorial * i;
            }
            if (i <= (n - k))
            {
                nkFactorial = nkFactorial * i;
            }
        }
        BigInteger result = nFactorial / (kFactorial * nkFactorial);
        Console.WriteLine("{0:#0}", result);        


    }
}

