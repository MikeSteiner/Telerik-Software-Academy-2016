﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************************
    Numbers from 1 to N

    Description

    Write a program that reads an integer number N from the console and prints all the numbers in the interval [1, n], each on a single line.

    Input

    On the only line you will receive the number N
    Output

    You should print the numbers from 1 to N, each on a separate line
    Constraints

    1 <= N < 1000
    N will always be a valid integer number
    Time limit: 0.1s
    Memory limit: 8MB
    Sample tests

Input	Output
3	1
2
3
5	1
2
3
4
5
1	1
Submission
*********************************************************************************************/
namespace P08.Numbers_from_1_to_n
{
    class NumbersFrom1toN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}", i);
            }
           
        }
    }
}
