using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
    Sort 3 Numbers

    Description

    Write a program that enters 3 real numbers and prints them sorted in descending order.

    Use nested if statements.
    Don’t use arrays and the built-in sorting functionality.
    Input

    On the first three lines, you will receive the three numbers, each on a separate line.
    Output

    Output a single line on the console - the sorted numbers, separated by a whitespace
    Constraints

    The three numbers will always be valid integer numbers in the range [-1000, 1000]
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
3
2
1	3 2 1
-5
3
-5	3 -5 -5
1
2
20	20 2 1
     
********************************************************************************/

namespace P07.Sort_3_Numbers
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {            
            int[] inputArr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                int input = int.Parse(Console.ReadLine());
                inputArr[i] = input;                
            }

            int[] sortedArr = BubbleSort(inputArr);
            Array.Reverse(sortedArr);
            foreach (int element in sortedArr)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }

        public static int[] BubbleSort(int[] arrToSort)
        {

            bool swapped;
            do
            {
                swapped = false;
                for (int i = 1; i < arrToSort.Length; i++)
                {
                    if (arrToSort[i] < arrToSort[i - 1])
                    {
                        int savedArrValue = arrToSort[i - 1];
                        arrToSort[i - 1] = arrToSort[i];
                        arrToSort[i] = savedArrValue;
                        swapped = true;
                    }
                }
            } while (swapped);            

            return arrToSort;
        }
                
    }
}
