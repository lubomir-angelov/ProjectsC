using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MatrixPattern
{
    class MatrixPattern
    {
        static int[,] ConsoleReadIntegerMatrix(int matrixRows, int matrixColumns)
        {
            //Console.WriteLine("Please input the values for each row on a line using space or commas or both as separators:");

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

        static long calculateSum(int[,] matrix, int startingRow, int startingCol)
        {
            long sum = 0;

            sum = matrix[startingRow, startingCol] + matrix[startingRow, startingCol + 1] + matrix[startingRow, startingCol + 2] +
                  matrix[startingRow + 1, startingCol + 2] +
                  matrix[startingRow + 2, startingCol + 2] + matrix[startingRow + 2, startingCol + 3] + matrix[startingRow + 2, startingCol + 4];

            return sum;
        }
        static bool CheckPattern(int[,] Matrix, int row, int col)
        {
            bool isValidPattern = false;

            //for (int i = row; i < Matrix.GetLength(0) - 2; i++)
            //{
            //    for (int j = col; j < Matrix.GetLength(1) - 4; j++)
            //    {
                    int currentRow = row;
                    int currenCol = col;
                    //A = B -1, B = C – 1, C = D – 1, D = F – 1, F = E – 1, E = G - 1
                    if(Matrix[currentRow, currenCol] == Matrix[currentRow, currenCol + 1] - 1)
                    {
                        if(Matrix[currentRow, currenCol + 1] == Matrix[currentRow, currenCol + 2] - 1)
                        {
                            if(Matrix[currentRow, currenCol + 2] == Matrix[currentRow + 1, currenCol +2] - 1)
                            {
                                if(Matrix[currentRow + 1, currenCol +2] == Matrix[currentRow + 2, currenCol + 2] - 1)
                                {
                                    if(Matrix[currentRow + 2, currenCol + 3] == Matrix[currentRow + 2, currenCol + 4] - 1)
                                    {
                                        isValidPattern = true;
                                        return isValidPattern;
                                    }
                                }
                            }
                        }
                    }
            //    }
            //}

            return isValidPattern;
        }
        static int CalcDiagSum(int[,] matrix)
        {
            int sum = 0;
            int count = 0;
            int row = 0;
            int col = 0;

            while (count < matrix.GetLength(0))
            {
                sum += matrix[row, col];
                row++;
                col++;
                count++;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[n,n];
            long maxSum = long.MinValue;
            long sum = 0;

            Matrix = ConsoleReadIntegerMatrix(n, n);

            for (int i = 0; i < Matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < Matrix.GetLength(1) - 4; j++)
                {
                    if(CheckPattern(Matrix, i, j))
                    {
                        sum = calculateSum(Matrix, i, j);
                        if(sum > maxSum)
                        {
                            maxSum = sum;
                        }
                    }
                }
            }

           // Console.WriteLine();
            if (maxSum != long.MinValue)
            {
                Console.WriteLine("YES {0}", maxSum);
            }
            else
            {
                maxSum = CalcDiagSum(Matrix);
                Console.WriteLine("NO {0}", maxSum);
            }

          //  Console.WriteLine();
        }
    }
}
