using System;

//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

// Use "Ctrl + e + u" to uncomment slected rows, "Ctrl + e + c" to comment selected rows; 
//*after pressing "Ctrl + e" you can stop pressing and then press the next key

 class Matrix_nn
    {
        // a)
        //static int[,] FillMatrix(int n, int[,] matrix)
        //{
        //    int[,] result = new int[n,n];
        //    int digit = 1;
        //    for (int rows = 0; rows < n; rows++)
        //    {
        //        for (int colls = 0; colls < n; colls++)
        //        {
        //            result[colls, rows] = digit;
        //            digit++;
        //        }
        //    }
        //    return result;
        //}

        // b)
        //static int[,] FillMatrix(int n, int[,] matrix)
        //{
        //    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
        //    int digit = 1, tempdigit = 0;

        //    for (int rows = 0; rows < matrix.GetLength(0); rows++)
        //    {
        //        if (rows % 2 == 0)
        //        {
        //            for (int colls = 0; colls < matrix.GetLength(1); colls++)
        //            {
        //                result[colls, rows] = digit;
        //                digit++;
        //            }
        //            tempdigit = digit + n - 1;
        //            digit += n;
        //        }
               
        //        else
        //        {                    
        //            for (int colls = 0; colls < matrix.GetLength(1); colls++)
        //            {
        //                result[colls, rows] = tempdigit;
        //                tempdigit--;
        //            }
        //        }
        //    }

        //    return result;
        //}


        // c)    
        //static int[,] FillMatrix(int n, int[,] matrix)
        //{
        //    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
        //    int digit = 1;

        //    for (int i = 0; i < n; i++)
        //    {
        //        for (int j = 0; j <= i; j++)
        //        {
        //            result[n - i + j - 1, j] = digit++;
        //        }
        //    }

        //    for (int i = n - 2; i >= 0; i--)
        //    {
        //        for (int j = i; j >= 0; j--)
        //        {
        //            result[i - j, n - j - 1] = digit++;
        //        }
        //    }

        //    return result;
        //}

        // d) - idea from http://forums.academy.telerik.com/48994/ jasssonpet
        static bool isFillable(int[,] matrix, int x, int y) //Check if the current cell is supposed to be filled
        {
            bool isCellFillable;
            isCellFillable = (x >= 0 && x < matrix.GetLength(0) && y >= 0 && y < matrix.GetLength(1) && matrix[x, y] == 0);
            return isCellFillable;
        }

        static int n = int.Parse(Console.ReadLine());    
        static int direction = 0;
        static int[,] directions = new int[,] { { 1, 0 }, { 0, 1 }, { -1, 0 }, { 0, -1 } };
        static int[,] result = new int[n, n];

        static int[,] FillMatrix(int[,] matrix, int row, int coll, int digit) //fill the matrix recursively
        {
            

            result[row, coll] = digit;

            if (digit == result.Length)
            {
                return result;            //bottom of recursion
            }

            int temprow = row + directions[direction, 0];
            int tempcoll = coll + directions[direction, 1];

            if (!isFillable(result, temprow, tempcoll))
            {
                direction = -1;
            }

            while(!isFillable(result, temprow, tempcoll))
            {
                direction ++;
                temprow = row + directions[direction, 0];
                tempcoll = coll + directions[direction, 1];
            }

            return FillMatrix(result, temprow, tempcoll, digit + 1); //call the recursion with the next digit
        }

        static void PrintMatrix(int[,] matrix)
        {
            int cellSize = (int)Math.Log10(matrix.Length) + 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,-" + cellSize + "} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {     
            int[,] matrix = new int[n,n];
            PrintMatrix(FillMatrix(matrix, 0, 0, 1)); //Print the result of FillMatrix (which returns a matrix as a result);
        }
    }






