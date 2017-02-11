using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*08. Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

09. Implement an indexer this[row, col] to access the inner matrix cells.

10. Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix 
multiplication. Throw an exception when the operation cannot be performed. Implement the true operator 
(check for non-zero elements). */


namespace _08_10.MatrixStuff
{
    class MatrixStuff
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix1 = new Matrix<int>(2, 2);
            Matrix<int> matrix2 = new Matrix<int>(2, 2);

            matrix1[0, 0] = 2;
            matrix1[0, 1] = 2;
            matrix1[1, 0] = 3;
            matrix1[1, 1] = 3;
            matrix2[0, 0] = 2;
            matrix2[0, 1] = 2;
            matrix2[1, 0] = 3;
            matrix2[1, 1] = 3;

            Matrix<int> matrixMulti = new Matrix<int>(2,2);
            matrixMulti = matrix1 + matrix2;
            //Console.WriteLine(); uncomment and put break to check the value of matrix multi
            matrixMulti = matrix1 - matrix2;
            //Console.WriteLine(); uncomment and put break to check the value of matrix multi
            matrixMulti = matrix1 * matrix2;
            //Console.WriteLine(); uncomment and put break to check the value of matrix multi
            Console.WriteLine();

            //bool check;
            //check = ? TO DO!

        }
    }
}
