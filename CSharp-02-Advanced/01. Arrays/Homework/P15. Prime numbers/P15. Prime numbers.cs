/*
Prime numbers
Description

Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.

Input

On the first line you will receive the number N
Output

Print the biggest prime number which is <= N
Constraints

2 <= N <= 10 000 000
Time limit: 0.3s
Memory limit: 64MB
Sample tests

Input	Output
13	13
126	113
26	23

 */
//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace P15.Prime_numbers
//{
//    class PrimeNumbers
//    {
//        static void Main(string[] args)
//        {
//            int N = int.Parse(Console.ReadLine());
//            Dictionary<int, bool> primeNums = new Dictionary<int, bool>();

//            Stopwatch stopWatch = new Stopwatch();
//            stopWatch.Start();
//            //Fill out prime nums collection
//            for (int i = 0; i < 10000000; i++)
//            {
//                primeNums.Add(i, true);
//            }

//            //Reset the non-prime nums to false
//            for (int i = 2; i < primeNums.Count; i++)
//            {
//                if (primeNums[i])
//                {
//                    for (int j = i + i; j < primeNums.Count; j += i)
//                    {
//                        primeNums[j] = false;
//                    }
//                }
//            }

//            //Find out the nearest (less or equal) prime and print it
//            for (int i = N; i >= 2; i--)
//            {                
//                if (primeNums[i])
//                {
//                    Console.WriteLine(i);
//                    break;
//                }
//            }
//            //Time checker
//            stopWatch.Stop();
//            Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);

//        }
//    }
//}

/*
 * Thanks to
 * https://github.com/tpopov94/CSharp-Part-II/
 * 
 */
using System;
using System.Diagnostics;

class PrimeNumbers
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        //Fill out prime nums collection
        bool[] primeNumbers = new bool[10000000];       // all numbers value is false by default;
        for (int i = 0; i < primeNumbers.Length; i++)
        {
            primeNumbers[i] = true;                     // so we set them all to true to be easier to chech them
        }

        //Checking for prime numbers
        for (int i = 2; i < primeNumbers.Length; i++)
        {
            if (primeNumbers[i])
            {
                for (int j = i + i; j < primeNumbers.Length; j += i) 
                {
                    primeNumbers[j] = false;
                }
            }

        }

        //Find and print out
        for (int i = N; i >= 2; i--)
        {
            if (primeNumbers[i])
            {
                Console.Write("{0} ", i);
                break;
            }

        }
        Console.WriteLine();

        //Time checker
        stopWatch.Stop();
        //Console.WriteLine("Time elapsed: {0}", stopWatch.Elapsed);
        
    }
}

