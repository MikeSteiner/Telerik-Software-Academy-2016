using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    Spiral Matrix

    Description

    Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.

    Input

    The input will always consist of a single line containing a single number - N.
    Output

    Output a spiral matrix as described below.
    Constraints

    N will always be a valid integer number.
    1 ≤ N ≤ 20
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
2	1 2
4 3
3	1 2 3
8 9 4
7 6 5
4	1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7

**************************************************************/
namespace P17.Spiral_Matrix
{
    //class SpiralMatrix
    //{
    //    static void Main(string[] args)
    //    {
    //        int N = int.Parse(Console.ReadLine());
    //        int[,] spiralMatrix = new int[N, N];

    //        string right = "";
    //        string down = "";
    //        string left = "";
    //        string up = "";

    //        for (int i = 0; i <= N * N; i++)
    //        {
    //            if(i < N)
    //            {
    //                right = right + i.ToString();
    //            }
    //            else if (i >= N && i < 2 * N - 1)
    //            {
    //                down = down + i.ToString();
    //            }
    //            else if (i >= 2 * N - 1 && i < 3 * N - 1)
    //            {
    //                left = left + i.ToString();
    //            }
    //            else if (i >= 3 * N - 1 && i < 4 * N - 1)
    //            {
    //                up = up + i.ToString();
    //            }
    //        }
    //        Console.WriteLine(right);
    //        Console.WriteLine(down);
    //        Console.WriteLine(left);
    //        Console.WriteLine(up);
    //    }
    //}
    //Working code from https://github.com/owolp/Telerik-Academy/blob/master/Modul-1/CSharp-Part-1/06-Loops/15.GCD/GCD.cs
    //100 of 100 :)
    class SpiralMatrix
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int[,] numberArray = new int[number, number];
            int row = 0;
            int col = 0;
            int counter = 1;
            int steps = number;
            int cycles = 0;

            while (counter <= number * number)
            {
                for (int i = 0; i < steps; i++)
                {
                    col = i + cycles;
                    numberArray[row, col] = counter;
                    counter++;
                }
                steps--;

                for (int i = 1; i <= steps; i++)
                {
                    row = i + cycles;
                    numberArray[row, col] = counter;
                    counter++;
                }
                steps--;

                for (int i = steps; i >= 0; i--)
                {
                    col = i + cycles;
                    numberArray[row, col] = counter;
                    counter++;
                }

                for (int i = steps; i > 0; i--)
                {
                    row = i + cycles;
                    numberArray[row, col] = counter;
                    counter++;
                }
                cycles++;
            }

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {

                    Console.Write(j == number + i - 1 ? "{0}" : "{0} ", numberArray[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
