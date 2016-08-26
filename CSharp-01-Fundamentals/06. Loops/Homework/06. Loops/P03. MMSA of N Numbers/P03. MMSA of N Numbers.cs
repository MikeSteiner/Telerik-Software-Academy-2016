using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
    MMSA(Min, Max, Sum, Average) of N Numbers

    Description

    Write a program that reads from the console a sequence of N integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).

    The input starts by the number N (alone in a line) followed by N lines, each holding an integer number.
    The output is like in the examples below.
    Input

    On the first line, you will receive the number N.
    On each of the next N lines, you will receive a single floating-point number.
    Output

    You output must always consist of exactly 4 lines - the minimal element on the first line, the maximal on the second, the sum on the third and the average on the fourth, in the following format:
    min=3
    max=6
    sum=9
    avg=4.5
    Constraints

    1 <= N <= 1000
    All numbers will be valid floating-point numbers that will be in the range [-10000, 10000]
    Time limit: 0.1s
    Memory limit: 16MB
    Sample tests

Input	Output
3
2
5
1	min=1
max=5
sum=8
avg=2.67
3
2
-1
4	min=-1
max=4
sum=5
avg=1.67

**************************************************************/
namespace P03.MMSA_of_N_Numbers
{
    class MMSAofNNumbers
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double[] nums = new double[num];

            for (int i = 0; i < num; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("min={0:#0.00}", nums.Min());
            Console.WriteLine("max={0:#0.00}", nums.Max());
            Console.WriteLine("sum={0:#0.00}", nums.Sum());
            Console.WriteLine("avg={0:#0.00}", nums.Average());
        }
    }
}
