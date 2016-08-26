/*
Compare char arrays
Write a program that compares two char arrays lexicographically (letter by letter).

Input

On the first line you will receive the first char array as a string
On the second line you will receive the second char array as a string
Output

Print < if the first array is lexicographically smaller
Print > if the second array is lexicographically smaller
Print = if the arrays are equal
Constraints

1 <= size of arrays <= 128
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
hello
halo	>
food
food	=
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3.Compare_char_arrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] arrA = Console.ReadLine().ToCharArray();
            char[] arrB = Console.ReadLine().ToCharArray();

            string arrComparatorStr = "=";
            //A is longer
            if (arrA.Length > arrB.Length)
            {
                arrComparatorStr = ">";
            }
            //B is longer
            else if (arrA.Length < arrB.Length)
            {
                arrComparatorStr = "<";
            }
            // Equal lenght
            else
            {
                for (int i = 0; i < arrA.Length; i++)
                {
                    char arrAChar = arrA[i];
                    char arrBChar = arrB[i];
                    bool charsAreEqual = (arrAChar == arrBChar);
                    if (!charsAreEqual)
                    {
                        if (arrAChar > arrBChar)
                        {
                            arrComparatorStr = ">";
                        }
                        else
                        {
                            arrComparatorStr = "<";
                        }
                        break;
                    }
                }
            }

            //Print out
            Console.WriteLine(arrComparatorStr);
        }
    }
}


//using System;

//class CompareArrays
//{
//    static void Main()
//    {
//        char[] firstArray = Console.ReadLine().ToCharArray();
//        char[] secondArray = Console.ReadLine().ToCharArray();

//        int length = firstArray.Length;
//        bool equal = true;

//        if (firstArray.Length != secondArray.Length)
//        {
//            length = Math.Min(firstArray.Length, secondArray.Length);
//        }


//        for (int i = 0; i < length; i++)
//        {
//            if (firstArray[i] != secondArray[i])
//            {
//                equal = false;
//                if (firstArray[i] < secondArray[i])
//                {
//                    Console.WriteLine("<");
//                    break;
//                }
//                Console.WriteLine(">");
//                break;
//            }
//        }
//        if (equal)
//        {
//            //Console.WriteLine("=");
//            if (firstArray.Length < secondArray.Length)
//            {
//                Console.WriteLine("<");
//            }
//            else if (secondArray.Length < firstArray.Length)
//            {
//                Console.WriteLine(">");
//            }
//            else
//            {
//                Console.WriteLine("=");
//            }

//        }
//    }
//}