/*
Fill the matrix
Description

Write a program that fills and prints a matrix of size (n, n) as shown below.

Input

On the first line you will receive the number N
On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix
Output

Print the matrix
Numbers on a row must be separated by a single spacebar
Each row must be on a new line
Constraints

1 <= N <= 128
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
4
a	
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
4
b	
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
4
c	
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
4
d	
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Multidimensional_Arrays
{
    class FillTheMatrix
    {

        static int[,] FillMatrix0(int dim)
        {
            int[,] matrix = new int[dim, dim];

            //0
            //1   2   3   4
            //5   6   7   8
            //9   19  11  12
            //13  14  15  16 

            int value = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }

            return matrix;
        }              

        static int[,] FillMatrixA(int dim)
        {
            int[,] matrix = new int[dim, dim];

            //a
            //1   5   9   13
            //2   6   10  14
            //3   7   11  15
            //4   8   12  16

            int value = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[col, row] = value;
                    value++;
                }
            }

            return matrix;
        }

        static int[,] FillMatrixB(int dim)
        {
            int[,] matrix = new int[dim, dim];

            //b
            //1   8   9   16
            //2   7   10  15
            //3   6   11  14
            //4   5   12  13

            //Fill out array b            
            int value = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int colReverceFill = col;

                    bool isOdd = row % 2 == 1;
                    if (isOdd)
                    {
                        colReverceFill = (dim - col);
                        colReverceFill--;
                    }
                    matrix[colReverceFill, row] = value;
                    value++;
                }
            }

            return matrix;
        }

        static int[,] FillMatrixC(int dim)
        {
            int[,] matrix = new int[dim, dim];       

            //Fill out array c              
            //**** ATo
            //c
            //0
            //0   0
            //0   0   0
            //7   11  14  16
            //4   8   12  15
            //2   5   9   13  0
            //1   3   6   10  0  0

            int value = 2;
            matrix[dim - 1, 0] = 1; //startup element

            for (int row = dim-2; row > dim * (-1); row--)
            {
                //value++;
                int rowDiag = row;
                for (int diagonal = 0; diagonal < dim; diagonal++)
                {                    
                    //if inside
                    bool isRowDiagInside = (0 <= rowDiag && rowDiag < dim);
                    if (isRowDiagInside)
                    {
                        
                        matrix[rowDiag, diagonal] = value;
                        value++;
                    }
                    rowDiag++;
                }
            }
            //**** ATo end

            return matrix;
        }



        static int val;

        static int[,] FillMatrixD(int dim)
        {
            int[,] matrix = new int[dim, dim];

            //Fill out array d              
            //d
            //1   12  11  10
            //2   13  16  9
            //3   14  15  8
            //4   5   6   7

            val = 1;
            int[] currPos = new int[]{0, 0};

            while (true)
            {
                currPos = MoveDown(matrix, currPos);
                if (IsFillOutCompleted(matrix, currPos))
                {
                    break;
                }
                currPos = MoveRight(matrix, currPos);
                if (IsFillOutCompleted(matrix, currPos))
                {
                    break;
                }
                currPos = MoveUp(matrix, currPos);
                if (IsFillOutCompleted(matrix, currPos))
                {
                    break;
                }
                currPos = MoveLeft(matrix, currPos);
                if (IsFillOutCompleted(matrix, currPos))
                {
                    break;
                }

                //break;
            }
            
           

            return matrix;
        }

        //Check if pos is inside matrix
        static bool IsInsideMatrix(int rowPos, int colPos, int dim)
        {
            bool isInsideMatrix =   (0 <= rowPos && rowPos < dim) &&
                                    (0 <= colPos && colPos < dim);
            
            return isInsideMatrix;
        }

        //Check if matrix filled out
        static bool IsFillOutCompleted(int[,] matrix, int[] pos)
        {
            int rowPos = pos[0];
            int colPos = pos[1];
            int size = matrix.Length;

            bool isCompleted = (matrix[rowPos, colPos] == size);
            if (isCompleted)
            {
                return true;
            }
            else
            {
                return false;
            }      
        }
        //Move down and set value
        static int[] MoveDown(int[,] matrix, int[] pos)
        {
            Tuple<int, int> bau = new Tuple<int, int>(0, 2);
            int rowPos = pos[0];
            int colPos = pos[1];
            int dim = (int)matrix.GetLongLength(0);

            for (int row = rowPos; row < dim; row++)
            {
                if (IsInsideMatrix(row, colPos, dim) && matrix[row, colPos] == (0))
                {                   
                    matrix[row, colPos] = val;
                    val++;
                    pos[0] = row;                    
                }                
            }

            return pos;
        }
        //Move right and set value
        static int[] MoveRight(int[,] matrix, int[] pos)
        {
            int rowPos = pos[0];
            int colPos = pos[1];
            int dim = (int)matrix.GetLongLength(0);

            for (int col = colPos; col < dim; col++)
            {
                if (IsInsideMatrix(rowPos, col, dim) && matrix[rowPos, col] == (0))
                {
                    matrix[rowPos, col] = val;
                    val++;
                    pos[1] = col;
                }                
            }

            return pos;
        }
        //Move right and set value
        static int[] MoveUp(int[,] matrix, int[] pos)
        {
            int rowPos = pos[0];
            int colPos = pos[1];
            int dim = (int)matrix.GetLongLength(0);

            for (int row = rowPos; row >= 0; row--)
            {
                if (IsInsideMatrix(row, colPos, dim) && matrix[row, colPos] == (0))
                {
                    matrix[row, colPos] = val;
                    val++;
                    pos[0] = row;
                }                
            }

            return pos;
        }
        //Move right and set value
        static int[] MoveLeft(int[,] matrix, int[] pos)
        {
            int rowPos = pos[0];
            int colPos = pos[1];
            int dim = (int)matrix.GetLongLength(0);

            for (int col = colPos; col >= 0; col--)
            {
                if (IsInsideMatrix(rowPos, col, dim) && matrix[rowPos, col] == (0))
                {
                    matrix[rowPos, col] = val;
                    val++;
                    pos[1] = col;
                }                
            }

            return pos;
        }

        static void PrintMatrix(int[,] matrix)
        {
            //Print matrix
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int r = 0; r < rowLength; r++)
            {
                for (int c = 0; c < colLength; c++)
                {
                    if (c < colLength - 1)
                    {
                        Console.Write("{0} ", matrix[r, c]);
                    }
                    else
                    {
                        Console.Write("{0}", matrix[r, c]);
                    }
                    
                }
                Console.Write(Environment.NewLine);
            }
        }
        //-------------------------------------------------------------------
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string cmd = Console.ReadLine();

            //int N = 4;
            //string cmd = "a";

            switch (cmd)
            {
                case ("0"):
                    //---------------------------------------
                    //0
                    //1   2   3   4
                    //5   6   7   8
                    //9   19  11  12
                    //13  14  15  16 

                    var matrix0 = FillMatrix0(N);
                    PrintMatrix(matrix0);

                    //Console.WriteLine(new string('-', 10));
                    break;
                case ("a"):
                    //---------------------------------------
                    //a
                    //1   5   9   13
                    //2   6   10  14
                    //3   7   11  15
                    //4   8   12  16

                    var matrixA = FillMatrixA(N);
                    PrintMatrix(matrixA);

                    //Console.WriteLine(new string('-', 10));
                    break;
                case ("b"):
                    //---------------------------------------
                    //b
                    //1   8   9   16
                    //2   7   10  15
                    //3   6   11  14
                    //4   5   12  13

                    var matrinxB = FillMatrixB(N);
                    PrintMatrix(matrinxB);

                    //Console.WriteLine(new string('-', 10));
                    break;
                case ("c"):
                    //---------------------------------------            
                    //c
                    //7   11  14  16
                    //4   8   12  15
                    //2   5   9   13
                    //1   3   6   10
                    //Fill out array c

                    var matrixC = FillMatrixC(N);
                    PrintMatrix(matrixC);

                    //Console.WriteLine(new string('-', 10));
                    break;
                case ("d"):
                    //---------------------------------------            
                    //d
                    //1   12  11  10
                    //2   13  16   9
                    //3   14  15   8
                    //4    5   6   7

                    var matrixD = FillMatrixD(N);
                    PrintMatrix(matrixD);

                    //Console.WriteLine(new string('-', 10));
                    break;
                default:
                    break;
            }
            
            //---------------------------------------
            
        }   
    }
}
