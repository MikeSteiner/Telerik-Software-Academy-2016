/*

• Define a class  Matrix<T>  to hold a matrix of numbers (e.g. integers, floats, decimals). 

Problem 9. Matrix indexer
• Implement an indexer  this[row, col]  to access the inner matrix cells.

Problem 10. Matrix operations
• Implement the operators  +  and  -  (addition and subtraction of matrices of the same size) and  *  for matrix multiplication.
• Throw an exception when the operation cannot be performed.
• Implement the  true  operator (check for non-zero elements).

Problem 11. Version attribute
• Create a  [Version]  attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format  major.minor  (e.g.  2.11 ).
• Apply the version attribute to a sample class and display its version at runtime.

 * 
 */
namespace PRG08
{
    using System;
    using GenericMatrix;

    public class StartPoint
    {
        public static void Main()
        {
            //Tests should be comming here!
            Console.WriteLine(Environment.NewLine
                + "Matrix Testing: "
                + Environment.NewLine);

            var matrix1 = new Matrix<int>(3, 2);
            var matrix2 = new Matrix<int>(2, 2);
            #region Filling Matrices
            matrix1[0, 0] = 4;
            matrix1[0, 1] = 8;
            matrix1[1, 0] = 0;
            matrix1[1, 1] = 2;
            matrix1[2, 0] = 1;
            matrix1[2, 1] = 6;

            matrix2[0, 0] = 5;
            matrix2[0, 1] = 2;
            matrix2[1, 0] = 9;
            matrix2[1, 1] = 4;
            #endregion

            var resultProduct = matrix1 * matrix2;

            if (matrix2)
            {
                Console.WriteLine("no zeroes");
            }
            else
            {
                Console.WriteLine("yes zeroes");
            }
        }
    }
}
