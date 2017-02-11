using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file and inserts line numbers in front of each of its lines. 
//The result should be written to another text file.


namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string firstFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\03.LineNumbers\MyFile.txt";
            string secondFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\03.LineNumbers\OtherFile.txt";

            StreamReader reader = new StreamReader(firstFilePath);
            using (reader)
            {
                using (StreamWriter write = new StreamWriter(secondFilePath))
                {
                    StringBuilder build = new StringBuilder();
                    int lineNumber = 0;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        write.WriteLine("Line number {0} : {1}", lineNumber, line);
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
            }

            

        }
    }
}
