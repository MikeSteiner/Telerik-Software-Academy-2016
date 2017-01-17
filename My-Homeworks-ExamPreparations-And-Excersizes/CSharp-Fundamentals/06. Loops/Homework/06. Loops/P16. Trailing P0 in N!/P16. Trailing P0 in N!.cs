using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

/**************************************************************
    Trailing 0 in N!

    Description

    Write a program that calculates with how many zeroes the factorial of a given number N has at its end.

    Your program should work well for very big numbers, e.g. N = 100000.
    Input

    On the only input line, you will receive a single integer - the number N
    Output

    Output a single number - the count of trailing zeroes for the N!
    Constraints

    N will always be a valid positive integer number.
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output	Explanation
10	2	3628800
20	4	2432902008176640000
100000	24999	think why

**************************************************************/
namespace P16.Trailing_P0_in_N_
{
    class TrailingP0inNfactorial
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            BigInteger nFactorial = new BigInteger(1);

            for (int i = 1; i <= N; i++)
            {
                nFactorial = nFactorial * i;
            }

            //Console.WriteLine(nFactorial);

            //int zeroesCounter = 0;          
            /*
            int trailingZeroesMaxLenght = 0;
            char[] nF = nFactorial.ToString().ToCharArray();

            for (int i = 0; i < nF.Length; i++)
            {
                if (nF[i] == '0')
                {
                    zeroesCounter = 1;
                    int j;
                    for (j = i+1; j < nF.Length; j++)
                    {
                        if (nF[j] == '0')
                        {
                            zeroesCounter++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    if (zeroesCounter >= trailingZeroesMaxLenght)
                    {
                        trailingZeroesMaxLenght = zeroesCounter;
                        i = j;
                    }
                }
            }
            Console.WriteLine(zeroesCounter);
            */

            //*********** Forst attempt
            //string nFStr = nFactorial.ToString();
            //List<string> trZeroesInFactorial = new List<string>();// Regex.Match(nFStr, @"[0]");
            //foreach (Match m in Regex.Matches(nFStr, @"0+"))
            //{
            //    trZeroesInFactorial.Add(m.Value);
            //}
            //List<int> lenghts = trZeroesInFactorial.Select(p => p.Length).ToList();
            //Console.WriteLine(lenghts.Max());

            //*********** Seckond Attempt
            //int endingZeroesCounter = 0;
            //while (true)
            //{
            //    bool endsWithZero = (nFactorial % 10 == 0);

            //    if (endsWithZero){ 
            //        nFactorial = nFactorial / 10;
            //        endingZeroesCounter++;
            //    }
            //    else
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine(endingZeroesCounter);

            //*********** Third Attempt
            StringBuilder nFSB = new StringBuilder(nFactorial.ToString());
            int endingZeroesCounter = 0;
            while (true)
            {
                bool endsWithZero = nFSB[nFSB.Length - 1] == '0';
                if (endsWithZero)
                {
                    nFSB.Remove(nFSB.Length-1,1);
                    endingZeroesCounter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(endingZeroesCounter);

        }
    }
}
