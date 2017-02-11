using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum
//of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. 
//The output should be a single number in a separate text file. Example:
//4
//2 3 3 4
//0 2 3 4			17
//3 7 1 2
//4 3 3 2
//Note: I am creating my files manually, please when checking homework rewrite file paths to suitable direcotires on your own machine.

namespace _05.MatrixMaxSum
{
    class MatrixMaxSum
    {
        public static string ReadFromFile(string filePath)
        {
            string result = null;

            using (StreamReader reader = new StreamReader(filePath))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }

        public static int[,] FromStringToIntMatrix(string[] stringToConvert)
        {
            int matrixSize = Convert.ToInt32(stringToConvert[0]);//get the size of the matrix
            int[,] result = new int[matrixSize,matrixSize];

            int indexInStringArray = 1;//start from the second element of the string array (containnig the first line of the matrix)

            for (int rows = 0; rows < matrixSize; rows++)
            {
                //for (int columns = 0; columns < matrixSize; columns++)
                //{
                    string line = stringToConvert[indexInStringArray];//get the line 
                    string[] correctLine = line.Split(' ');//remove the ympty entiries

                    for (int i = 0; i < correctLine.Length; i++)
                    {
                        result[rows, i] = Convert.ToInt32(correctLine[i]);
                    }
                    indexInStringArray ++;
                //}
            }

            return result;
        }

        static long calculateSum(int[,] matrix, int rows, int cols)
        {
            long sum = 0;

            sum = matrix[rows, cols - 1] + matrix[rows, cols] + matrix[rows + 1, cols - 1] + matrix[rows + 1, cols];  

            return sum;
        }

        static void Main(string[] args)
        {
            //locate and read from file
            string filePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\05.MatrixMaxSum\TextFiles\MatrixToBeRead.txt";
            string fileContnets = null;
            fileContnets = ReadFromFile(filePath);

            //prepare the file contents for work
            string[] separtors = { "\n", "\r" };
            string[] cleanedFileContents = null;
            cleanedFileContents = fileContnets.Split(separtors, StringSplitOptions.RemoveEmptyEntries);
            
            //initialize variables for the matrix and our sum
            int matrixSize = (int) Char.GetNumericValue(fileContnets[0]);
            int[,] OurMatrix = new int[matrixSize, matrixSize];

            //calculate our values
            OurMatrix = FromStringToIntMatrix(cleanedFileContents);
            long maxSum = long.MinValue;

            for (int rows = 0; rows < matrixSize - 1; rows++)
            {
                for (int cols = 1; cols < matrixSize - 1; cols++)
                {
                    long tempSum = 0;
                    tempSum = calculateSum(OurMatrix, rows, cols);
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }

            string outputFIlePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\05.MatrixMaxSum\TextFiles\OutputFile.txt";

            using (StreamWriter write = new StreamWriter(outputFIlePath))
            {
                write.WriteLine(maxSum);
            }

            Console.WriteLine("You have succesfully written in {0}", outputFIlePath);
        }


    }
}
