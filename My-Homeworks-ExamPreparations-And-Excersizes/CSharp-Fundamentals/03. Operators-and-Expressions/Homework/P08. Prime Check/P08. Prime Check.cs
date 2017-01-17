using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Description

    Write a program that reads an integer N (which will always be less than 100 or equal) 
    and uses an expression to check if given N is prime (i.e. it is divisible without remainder only to itself and 1).

    Note: You should check if the number is positive

*/

class PrimeCheck
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        bool isPrime = false;
        int reminderCounter = 0;

        if (N > 0)
        {
            //isPrime = (N % 1 == 0L) && (N % N == 0);
            for (int i = 1; i <= N; i++)
            {
                if (N % i == 0)
                {
                    reminderCounter++;
                }

            }
        }

        isPrime = (reminderCounter == 2);

        string output = Convert.ToString(isPrime).ToLower().Substring(0, 1);
        output = output + Convert.ToString(isPrime).ToLower().Substring(1);
        Console.WriteLine(output);
    }
}

