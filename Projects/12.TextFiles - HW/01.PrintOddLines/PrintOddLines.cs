using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file and prints on the console its odd lines.
//Note: I am creating my files manually, please when checking homework rewrite file paths to suitable direcotires on your own machine.

namespace _01.PrintOddLines
{
    class PrintOddLines
    {
        static void Main(string[] args)
        {
            string path = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\01.PrintOddLines\MyFile.txt";

            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }
                    line = reader.ReadLine();
                    lineNumber++;
                }
            }

        }
    }
}
