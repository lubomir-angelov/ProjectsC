using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located 
//on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Example:


    class StringMatrixMostFrequent
    {
        static string[,] ConsoleReadStringMatrix(int matrixRows, int matrixColumns)
        {
            string[,] result = new string[matrixRows, matrixColumns];
            string message = @"Please enter each row of the matrix in one line and separate each string with semicolumns "";"" and or space "" "" " ; 
            Console.WriteLine(message);

            char[] separators = { ';' , ' '};

            for (int rows = 0; rows < matrixRows; rows++)
            {
                string line = Console.ReadLine();
                string[] actualInput = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                for (int cols = 0; cols < matrixColumns; cols++)
                {
                    result[rows, cols] = actualInput[cols];
                }
            }

            return result;
        }

        //static void ConsolePrintStringMatrix(string[,] matrix)
        //{
        //    for (int rows = 0; rows < matrix.GetLength(0); rows++)
        //    {
        //        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        //        {
        //            Console.Write("{0} ", matrix[rows, cols]);
        //        }
        //        Console.WriteLine();
        //    }
        //}

        
           
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = ConsoleReadStringMatrix(n, m);

            //string[,] matrix = {
            //                       {"s", "a", "da", "blq", "q"},
            //                       {"pp", "ss", "s", "q", "l"},
            //                       {"p", "pp", "q", "k", "l"},
            //                       {"g", "q", "da", "blq", "k"},
            //                       {"q", "ne", "ne", "ne","ne"}
            //                   };
                                  
            //find the longest sequence of strings in a column
            //string arc = "arc"; // use this to mark a cell as already checked;

            int maxCounter = int.MinValue;
            string result = null; // string which makes the longest sequence
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int counter = 1;

                    int currentRow = rows + 1;

                    if (currentRow == matrix.GetLength(0)) break; // if we are at the last element in the matrix stop;
                    if(matrix[rows, cols] == matrix[currentRow, cols])
                    {
                        while (currentRow < matrix.GetLength(0) && matrix[currentRow, cols] == matrix[rows, cols])
                        {
                            currentRow ++;
                            counter ++;
                        }
                    }

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        result = matrix[rows, cols];
                    }
                }
            }

            //Console.WriteLine("{0} {1}", result, maxCounter);

            //find longest sequence in a row

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int counter = 1;

                    int currentCol = cols + 1;
                    if (currentCol == matrix.GetLength(1)) break; // if we are at the last element in the matrix stop;

                    if (matrix[rows, currentCol] == matrix[rows, cols])
                    {
                        while (currentCol < matrix.GetLength(1) && matrix[rows, currentCol] == matrix[rows, cols])
                        {
                            currentCol++;
                            counter++;
                        }
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        result = matrix[rows, cols];
                    }
                }
            }

           // Console.WriteLine("{0} {1}", result, maxCounter);

            //find the longest sequence in one diagonal (down, right)

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    int counter = 1;

                    int currentRow = rows + 1, currentCol = cols + 1;

                    if (currentRow == matrix.GetLength(0) || currentCol == matrix.GetLength(1)) break; //so we dont get IndexOutOFRange Ex.

                    if (matrix[currentRow, currentRow] == matrix[rows, cols])
                    {
                        while (currentRow < matrix.GetLength(0) && currentCol < matrix.GetLength(1)
                              && matrix[currentRow, currentCol] == matrix[rows, cols])
                        {
                            currentRow++;
                            currentCol++;
                            counter++;
                        }
                    }

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        result = matrix[rows, cols];
                    }
                }
            }

            //Console.WriteLine("{0} {1}", result, maxCounter);

            //find longest sequence in a diagonal (down, left)

            for (int rows = 0; rows < matrix.GetLength(0); rows ++)
            {
                for (int cols = matrix.GetLength(1) - 1; cols >= 0; cols--) // start from the leftmost element
                {
                    int counter = 1;

                    int currentRow = rows + 1, currentCol = cols - 1;

                    if (currentRow == matrix.GetLength(0) || currentCol == 0) break; //IOOR exception skipping 

                    if (matrix[currentRow, currentCol] == matrix[rows, cols])
                    {
                        while (currentRow < matrix.GetLength(0) && currentCol >= 0
                               && matrix[currentRow, currentCol] == matrix[rows, cols])  // put the part with  !!!!
                                                                                        // indexes as a last logical statement
                        {                                                               // else we get an IndexOutOfRange Exception   
                            currentRow ++;
                            currentCol--;
                            counter++;
                        }
                    }

                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        result = matrix[rows, cols];
                    }
                }
            }

            for(int i = 0; i < maxCounter; i ++)
            Console.Write("{0}, ", result);
            Console.WriteLine();
        }
    }

