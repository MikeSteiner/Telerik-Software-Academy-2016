/*
Maximal sum
Description

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.

Input

On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M numbers separated with spaces - the elements of the matrix
Output

Print the maximal sum of 3 x 3 square
Constraints

3 <= N, M <= 1024
Numbers in the matrix will be in the interval [ -1000, 1000 ]
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3 3
4 3 5
2 6 4
8 2 7
41

5 5
1 1 3 3 5
-6 -7 2 -3 -1
3 0 -4 5 9
7 -7 0 1 0
-7 -6 -4 -4 9	
19

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02.Maximal_sum
{
    class Program
    {
        //Claculates the given area sum
        static int CalcAreaSum(int[,] matrix, int[] pivotPos, int areaLenght, int areaHeight)
        {
            int row = pivotPos[0];
            int col = pivotPos[1];
            int sum = 0;

            for (int r = row; r < row + areaLenght; r++)
            {
                for (int c = col; c < col + areaHeight; c++)
                {
                    sum += matrix[r, c];
                }
            }

            return sum;
        }

        //Read array from console
        static void ReadArray(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inLine = Console.ReadLine();

                int[] inLineArr = inLine.Split(' ').Select(p => int.Parse(p)).ToArray();
                for (int col = 0; col < inLineArr.Length; col++)
                {
                    matrix[row, col] = inLineArr[col];
                }
            }
        }

        //***********************************  
        //      MAIN 
        //***********************************  
        static void Main(string[] args)
        {
            //int[,] nums = new int[,]
            //{
            //    { 1,   2,   3,   4 },
            //    { 5,   6,   7,   8 },
            //    { 9,  10,  11,  12 },
            //    { 13, 14,  15,  16 }
            //};

            //int[,] nums = new int[,]
            //{
            //    {  1,   1,   3,   3,  5 },
            //    { -6,  -7,   2,  -3, -1 },
            //    {  3,   0,  -4,   5,  9 },
            //    {  7,  -7,   0,   1,  0 },
            //    { -7,  -6,  -4,  -4,  9 }
            //};

            int[] dims = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToArray();
            int[,] nums = new int[dims[0], dims[1]];
            int dimLenght = nums.GetLength(0);
            int dimHight = nums.GetLength(1);

            ReadArray(nums);


            int areaLenght = 3;
            int areaHeight = 3;
            int bestSum = int.MinValue;
            int[] currPos = new int[2];

            for (int row = 0; row < nums.GetLength(0); row++)
            {
                for (int col = 0; col < nums.GetLength(1); col++)
                {
                    int currSum = int.MinValue;
                    currPos[0] = row;
                    currPos[1] = col;

                    //Check if pos is inside matrix
                    bool isInsideMatrix = ((row + areaLenght - 1) < dimLenght) &&
                                            ((col + areaHeight - 1) < dimHight);

                    if (isInsideMatrix)
                    {
                        currSum = CalcAreaSum(nums, currPos, areaLenght, areaHeight);

                        if (currSum > bestSum)
                        {
                            bestSum = currSum;
                        }
                    }
                }
            }

            Console.WriteLine(bestSum);

        }
    }
}
