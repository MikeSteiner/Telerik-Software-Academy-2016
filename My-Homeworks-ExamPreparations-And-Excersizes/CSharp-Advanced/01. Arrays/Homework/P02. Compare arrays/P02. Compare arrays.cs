/*
Compare arrays
Description

Write a program that reads two integer arrays of size N from the console and compares them element by element.

Input

On the first line you will receive the number N
On the next N lines the numbers of the first array will be given
On the next N lines the numbers of the second array will be given
Output

Print Equal if the two arrays are the same and Not equal if they are not
Constraints

1 <= N <= 20
N will always be a valid integer number
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3
1
2
3
1
2
3	Equal

3
1
1
1
2
2
2
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2.Compare_arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] arrA = new int[N];
            int[] arrB = new int[N];

            //Array A fill
            for (int i = 0; i < arrA.Length; i++)
            {
                arrA[i] = int.Parse(Console.ReadLine());
            }

            //Array B fill
            for (int i = 0; i < arrB.Length; i++)
            {
                arrB[i] = int.Parse(Console.ReadLine());
            }

            //Compare arrA and arrB
            string arrAreEqual = "Equal";
            for (int i = 0; i < arrA.Length; i++)
            {
                bool currentElementsAreEqual = (arrA[i] == arrB[i]);
                if (!currentElementsAreEqual)
                {
                    arrAreEqual = "Not equal";
                    break;
                }
            }

            //Print out
            Console.WriteLine(arrAreEqual);

        }
    }
}
