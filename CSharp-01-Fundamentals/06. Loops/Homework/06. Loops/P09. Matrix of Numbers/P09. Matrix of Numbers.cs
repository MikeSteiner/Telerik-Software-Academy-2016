using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**************************************************************
 

**************************************************************/
namespace P09.Matrix_of_Numbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] matrix = new int[N, N];
            //matrix[0, 0] = 1;

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = j+i+1;
                }
            }

            //int bound = matrix.GetUpperBound(0);
            int currentLine = 0;
            int maxIndex = matrix.GetUpperBound(0);

            foreach (int item in matrix)
            {
                bool isLastElementInLine = (item == (int)matrix.GetValue(currentLine, maxIndex));

                Console.Write(item + " ");                
                
                if (isLastElementInLine)
                {
                    currentLine++;
                    Console.WriteLine();
                }
            }

        }
    }
}
