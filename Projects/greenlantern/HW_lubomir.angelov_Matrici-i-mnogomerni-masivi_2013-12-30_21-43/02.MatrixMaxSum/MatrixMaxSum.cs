using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MatrixMaxSum
{
    class MatrixMaxSum
    {
        static int[,] ConsoleReadIntegerMatrix(int matrixRows, int matrixColumns)
        {
            Console.WriteLine("Please input the values for each row on a line using space or commas or both as separators:");
            int[,] outputMatrix = new int[matrixRows, matrixColumns];

            char[] separators = { ' ', ',' };
            for (int rows = 0; rows < matrixRows; rows++)
            {
                string line = Console.ReadLine();
                string[] numbers = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int cols = 0; cols < matrixColumns; cols++)
                {
                    outputMatrix[rows, cols] = int.Parse(numbers[cols]);       
                }
            }

            return outputMatrix;
        }

        static long calculateSum(int[,] matrix, int rows, int cols)
        {
            long sum = 0;

            sum = matrix[rows - 1, cols] + matrix[rows - 1, cols - 1] + matrix[rows - 1, cols + 1] +
                  matrix[rows, cols] + matrix[rows, cols - 1] + matrix[rows, cols + 1] +
                  matrix[rows + 1, cols] + matrix[rows + 1, cols - 1] + matrix[rows + 1, cols + 1];

            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = ConsoleReadIntegerMatrix(n, m);
            long maxSum = long.MinValue;

            for (int rows = 1; rows < n - 1; rows++)
            {
                for (int cols = 1; cols < m - 1; cols++)
                {
                    long tempSum = 0;
                    tempSum = calculateSum(matrix, rows, cols);
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }

            Console.WriteLine("The maximum sum of 3x3 cells is {0}", maxSum);
        }
    }
}
