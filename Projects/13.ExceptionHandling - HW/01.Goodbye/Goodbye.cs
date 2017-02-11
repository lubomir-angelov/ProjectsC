using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, 
//print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.


namespace _01.Goodbye
{
    class Goodbye
    {
        static void Main(string[] args)
        {
            string readFilePath = @"D:\Programming\VisualStudioPrograms\Projects\13.ExceptionHandling - HW\01.Goodbye\TextFiles\firstFile.txt";
            //string writeFilePath = @"D:\Programming\VisualStudioPrograms\Projects\13.ExceptionHandling - HW\01.Goodbye\TextFiles\secondFile.txt";
            int fileContents = 0;
            using (StreamReader reader = new StreamReader(readFilePath))
            {
                try
                {
                    fileContents = int.Parse(reader.ReadLine());
                    if (fileContents > 0)
                    {
                        Console.WriteLine(Math.Sqrt(fileContents));
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number.");
                }

                finally
                {
                    Console.WriteLine("Good bye");
                }
            }


        }
    }
}
