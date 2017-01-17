using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    Calculate Again

    Description

    Write a program that calculates N! / K! for given N and K.

    Use only one loop.
    Input

    On the first line, there will be only one number - N
    On the second line, there will be only one number - K
    Output

    Output a single line, consisting of the result from the calculation described above.
    Constraints

    1 < K < N < 100
    Hint: overflow is possible
    N and K will always be valid integer numbers
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
5
2	60
6
5	6
8
3	6720

**************************************************************/
namespace P06.Calculate_Again_
{
    class CalculateAgainfactorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            BigInteger result = new BigInteger();
            BigInteger nFactorial = new BigInteger(1);
            BigInteger kFactorial = new BigInteger(1);

            for (int i = 1; i <= n; i++)
            {
                nFactorial = nFactorial * i;
                if (i <= k)
                {
                    kFactorial = kFactorial * i;
                }
            }
           result = (nFactorial / kFactorial);

            Console.WriteLine("{0:#0}", result);
        }
    }
}
