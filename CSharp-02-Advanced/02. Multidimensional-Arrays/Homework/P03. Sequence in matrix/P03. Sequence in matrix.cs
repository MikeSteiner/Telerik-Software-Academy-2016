/*
Sequence in matrix
Description

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix and prints its length.

Input

On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M strings separated with spaces - the strings in the matrix
Output

Print the length of the longest sequence of equal equal strings in the matrix
Constraints

3 <= N, M <= 128
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
6 6
92 11 23 42 59 48
09 92 23 72 56 14
17 63 92 46 85 95
34 12 52 69 23 95
26 88 78 71 29 95
26 34 16 63 39 95	

4
Submission

Submit your code here 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Sequence_in_matrix
{
    class SequenceInMatrix
    {
        //Read array from console
        static void ReadArray(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string inLine = Console.ReadLine();

                string[] inLineArr = inLine.Split(' ').Select(p => p).ToArray();
                for (int col = 0; col < inLineArr.Length; col++)
                {
                    matrix[row, col] = inLineArr[col];
                }
            }
        }

        //Search rows       =>  serchDirection = 0
        //Search columns    =>  serchDirection = 1
        static int FindLongestInRowsColums(string[,] matrix, int serchDirection)
        {
            int bestLenght = 1;
            int currLenght = 1;

            int maxRows = matrix.GetLength(0);
            int maxCols = matrix.GetLength(1);
            if (serchDirection != 0)
            {
                maxRows = matrix.GetLength(1);
                maxCols = matrix.GetLength(0);
            }


            string prevValue = matrix[0,0];

            for (int row = 0; row < maxRows; row++)
            {
                for (int col = 0; col < maxCols; col++)
                {
                    //Ignore the very first element
                    if (row == 0 && col == 0)
                    {
                        continue;
                    }

                    //serchDirection == 0 => search rows
                    //serchDirection == 1 => search cols
                    int r = row;
                    int c = col;
                    if (serchDirection != 0)
                    {
                        r = col;
                        c = row;
                    }                    
                    string currValue = matrix[r, c];

                    //Best lenght checker
                    if (currValue.Equals(prevValue))
                    {
                        currLenght++;
                    }
                    else
                    {
                        if (currLenght > bestLenght)
                        {
                            bestLenght = currLenght;
                        }
                        currLenght = 1;                        
                    }
                    prevValue = currValue;             
                }

                if (currLenght > bestLenght)
                {
                    bestLenght = currLenght;
                    currLenght = 1;
                }
            }

            return bestLenght;
        }

        //diagDirection == 'L' => search Left to Right diagonals
        //diagDirection == 'R' => search Right to Left diagonals
        static int FindLongestInDiagonals(string[,] matrix, char diagDirection)
        {
            int bestLenght = 1;
            int currLenght = 1;

            int maxRows = matrix.GetLength(0);
            int maxCols = matrix.GetLength(1);

            //0
            //0   0
            //0   0   0
            //7   11  14  16
            //4   8   12  15
            //2   5   9   13
            //1   3   6   10

            //change startup element based on diagDirection
            //diagDirection == 'L' => search Left to Right diagonals
            //diagDirection == 'R' => search Right to Left diagonals
            string prevValue;
            if (diagDirection == 'L')
            {
                prevValue = matrix[maxRows - 1, 0];
            }
            else if (diagDirection == 'R')
            {
                prevValue = matrix[maxRows - 1, maxCols - 1];
            }
            else
            {
                diagDirection = 'L';
                prevValue = matrix[maxRows - 1, 0];
            }
            
             

            for (int row = maxRows - 2; row > maxRows * (-1); row--)
            {                
                int rowDiag = row;
                
                if (diagDirection == 'L')
                {
                    for (int diagonal = 0; diagonal < maxCols; diagonal++)
                    {
                        string currValue = "";
                        //if inside
                        bool isRowDiagInside = (0 <= rowDiag && rowDiag < maxRows);
                        if (isRowDiagInside)
                        {
                            currValue = matrix[rowDiag, diagonal];

                            //Best lenght checker
                            if (currValue.Equals(prevValue))
                            {
                                currLenght++;
                            }
                            else
                            {
                                if (currLenght > bestLenght)
                                {
                                    bestLenght = currLenght;
                                }
                                currLenght = 1;
                            }

                            prevValue = currValue;
                        }

                        rowDiag++;
                    }

                    if (currLenght > bestLenght)
                    {
                        bestLenght = currLenght;
                        currLenght = 1;
                    }
                }
                else if (diagDirection == 'R')
                {
                    for (int diagonal = maxCols - 1; diagonal >= 0; diagonal--)
                    {
                        string currValue = "";
                        //if inside
                        bool isRowDiagInside = (0 <= rowDiag && rowDiag < maxRows);
                        if (isRowDiagInside)
                        {
                            currValue = matrix[rowDiag, diagonal];

                            //Best lenght checker
                            if (currValue.Equals(prevValue))
                            {
                                currLenght++;
                            }
                            else
                            {
                                if (currLenght > bestLenght)
                                {
                                    bestLenght = currLenght;
                                }
                                currLenght = 1;
                            }

                            prevValue = currValue;
                        }

                        rowDiag++;
                    }

                    if (currLenght > bestLenght)
                    {
                        bestLenght = currLenght;
                        currLenght = 1;
                    }
                }
                

                
            }            

            return bestLenght;
        }

        //***********************************  
        //      MAIN 
        //*********************************** 
        static void Main(string[] args)
        {
            //string[,] nums = new string[,]
            //{
            //    { "1",   "5",   "2",   "3" },
            //    { "5",   "5",   "6",   "8" },
            //    { "9",   "5",  "11",  "12" },
            //    { "13", "14",  "15",  "16" }
            //};

            //string[,] nums = new string[,]
            //{
            //    {  "1",   "5",   "2",   "3" },
            //    {  "5",   "5",   "6",   "8" },
            //    {  "9",   "5",  "11",  "12" },
            //    { "13",  "14",  "15",  "16" }
            //};


            //string[,] nums = new string[,]
            //{
            //    {  "1",   "5",   "2",   "3" },
            //    {  "5",   "5",   "5",   "5" },
            //    {  "9",   "7",   "1",  "12" },
            //    { "13",   "9",   "5",   "17" }
            //};


            //string[,] nums = new string[,]
            //{
            //    {  "1",   "5",   "2",   "5" },
            //    {  "5",   "1",   "5",   "8" },
            //    {  "9",   "5",   "8",  "5" },
            //    { "5",   "8",   "5",   "17" }
            //};

            //string[,] nums = new string[,]
            //{
            //    {  "1",   "5",   "2" },
            //    {  "5",   "1",   "5" },
            //    {  "9",   "5",   "8" },
            //    { "5",   "8",   "5" }
            //};

            //string[,] nums = new string[,]
            //{
            //    { "1",   "5",   "2",   "5",  "7" },
            //    { "5",   "1",   "5",   "8",  "7" },
            //    { "9",   "5",   "8",   "5",  "7" },
            //    { "5",   "8",   "1",  "17",  "7" }
            //};

            int[] dims = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToArray();
            string[,] nums = new string[dims[0], dims[1]];

            ReadArray(nums);

            int bestSeqLenght = 1;            

            //Search all rows
            int currSeqLenght = FindLongestInRowsColums(nums, 0);
            if (currSeqLenght > bestSeqLenght)
            {
                bestSeqLenght = currSeqLenght;                
            }
            //Search all columns
            currSeqLenght = FindLongestInRowsColums(nums, 1);
            if (currSeqLenght > bestSeqLenght)
            {
                bestSeqLenght = currSeqLenght;                
            }
            //Search Left diagonals
            currSeqLenght = FindLongestInDiagonals(nums, 'L');
            if (currSeqLenght > bestSeqLenght)
            {
                bestSeqLenght = currSeqLenght;
            }
            //Search Right diagonals
            currSeqLenght = FindLongestInDiagonals(nums, 'R');
            if (currSeqLenght > bestSeqLenght)
            {
                bestSeqLenght = currSeqLenght;
            }

            //Print out
            Console.WriteLine(bestSeqLenght);

        }
    }
}
