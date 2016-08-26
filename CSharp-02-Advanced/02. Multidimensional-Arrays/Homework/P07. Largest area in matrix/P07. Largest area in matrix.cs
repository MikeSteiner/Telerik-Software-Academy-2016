/*
Largest area in matrix
Description

Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

Input

On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M numbers separated with spaces - the elements of the matrix
Output

Print the size of the lasrgest area of equal neighbour elements
Constraints

3 <= N, M <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input   Output
5 6
1 3 2 2 2 4
3 3 3 2 4 4
4 3 1 2 3 3
4 3 1 3 3 1
4 3 3 3 1 1	13
Hint: you can use the algorithm 
Depth-first search: http://en.wikipedia.org/wiki/Depth-first_search
 or 
Breadth-first search: http://en.wikipedia.org/wiki/Breadth-first_search.

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.Largest_area_in_matrix
{
    class LargestAreaInMatrix
    {
        private const int initialValue = 1;
        private const int visitedValue = -1;
        private static int targetValue;
        private static int maxRow;
        private static int maxCol;
        private static int currentLenght;
        private static int maxLenght;

        static void Main(string[] args)
        {
            int[] dims = Console.ReadLine().Split(' ').Select(p => int.Parse(p)).ToArray();
            int[,] matrix = new int[dims[0], dims[1]];

            ReadArray(matrix);

            maxRow = matrix.GetLength(0);
            maxCol = matrix.GetLength(1);

            ScanMatrix(matrix);
            
            Console.WriteLine(maxLenght);
        }
        
        private static void ReadArray(int[,] matrix)
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

        private static void ScanMatrix(int[,] matrix)
        {
            for (int row = 0; row < maxRow; row++)
            {
                for (int col = 0; col < maxCol; col++)
                {
                    bool isAlreadyVisited = IsAlreadyVisited(matrix, row, col);
                    if (!isAlreadyVisited)
                    {
                        Tuple<int, int> key = new Tuple<int, int>(row, col);

                        targetValue = matrix[row, col];
                        matrix[row, col] = visitedValue;
                        currentLenght = initialValue;

                        ReadNeighbours(matrix, row, col);

                        if (currentLenght > maxLenght)
                        {
                            maxLenght = currentLenght;
                        }
                    }
                }
            }
        }

        private static void ReadNeighbours(int[,] matrix, int row, int col)
        {
            CheckElement(matrix, row, col, Direction.Up);
            CheckElement(matrix, row, col, Direction.Left);
            CheckElement(matrix, row, col, Direction.Right);
            CheckElement(matrix, row, col, Direction.Down);
        }

        private static void CheckElement(int[,] matrix, int row, int col, Direction dir)
        {
            int targetRow = row;
            int targetCol = col;
            switch (dir)
            {
                case Direction.Up:
                    targetRow--;
                    break;
                case Direction.Left:
                    targetCol--;
                    break;
                case Direction.Right:
                    targetCol++;
                    break;
                case Direction.Down:
                    targetRow++;
                    break;
                default:
                    break;
            }

            bool isInsideMatrix = IsInsideMatrix(matrix, targetRow, targetCol);
            if (isInsideMatrix)
            {
                bool isAlreadyVisited = IsAlreadyVisited(matrix, targetRow, targetCol);
                if (!isAlreadyVisited)
                {
                    if (targetValue == matrix[targetRow, targetCol])
                    {
                        currentLenght++;
                        matrix[targetRow, targetCol] = visitedValue;
                        ReadNeighbours(matrix, targetRow, targetCol);
                    }
                }
            }
        }

        private static bool IsInsideMatrix(int[,] matrix, int row, int col)
        {
            return ((0 <= row) && (row < maxRow)) && ((0 <= col) && (col < maxCol));
        }

        private static bool IsAlreadyVisited(int[,] matrix, int row, int col)
        {
            return (matrix[row, col] == visitedValue);
        }
    }

    enum Direction
    {
        Up,
        Left,
        Right,
        Down
    }
}