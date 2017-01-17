using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
 

**************************************************************/

class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger nFactorial = 1UL;
        BigInteger nmul2Factorial = 1UL;
        BigInteger nplus1Factorial = 1UL;        

        for (int i = 1; i <= n * 2; i++)
        {
            nmul2Factorial = nmul2Factorial * i;
            if (i <= n)
            {
                nFactorial = nFactorial * i;                
            }
            if (i <= (n + 1))
            {
                nplus1Factorial = nplus1Factorial * i;
            }
        }
        BigInteger result = nmul2Factorial / (nplus1Factorial * nFactorial);
        Console.WriteLine("{0:#0}", result);
    }
}
