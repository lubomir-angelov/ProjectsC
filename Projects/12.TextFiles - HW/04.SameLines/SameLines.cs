using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of 
//lines that are different. Assume the files have equal number of lines.
//Note: I am creating my files manually, please when checking homework rewrite file paths to suitable direcotires on your own machine.

namespace _04.SameLines
{
    class SameLines
    {
        static void Main(string[] args)
        {
            string firstFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\04.SameLines\TextFiles\FirstFile.txt";
            string secondFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\04.SameLines\TextFiles\SecondFile.txt";
            string firstFileOutput = null;
            string secondFileOutput = null;
            int lineNumber = 0;
            int sameLinesCounter = 0, difLinesCounter = 0;

            using (StreamReader readerF = new StreamReader(firstFilePath))
            {
                firstFileOutput = readerF.ReadLine();
                while (firstFileOutput != null)
                {                                      
                    secondFileOutput = File.ReadLines(secondFilePath).Skip(lineNumber).Take(1).First(); 

                    if (firstFileOutput == secondFileOutput)
                    {
                        sameLinesCounter++;
                    }
                    else
                    {
                        difLinesCounter++;
                    }
                    firstFileOutput = readerF.ReadLine();
                    lineNumber++;
                }
            }

            Console.WriteLine("Lines that are the same = {0}\nLines that differ = {1}", sameLinesCounter, difLinesCounter);
        }
    }
}
