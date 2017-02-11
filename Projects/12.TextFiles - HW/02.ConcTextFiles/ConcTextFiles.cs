using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that concatenates two text files into another text file.
//Note: I am creating my files manually, please when checking homework rewrite file paths to suitable direcotires on your own machine.

namespace _02.ConcTextFiles
{
    class ConcTextFiles
    {
        static void Main()
        {
            string firstFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\02.ConcTextFiles\TextFiles\firstFile.txt";
            string secondFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\02.ConcTextFiles\TextFiles\secondFile.txt";
            string firstFileContents;
            string secondFileContents;

            using (StreamReader read = new StreamReader(firstFilePath))
            {
                firstFileContents = read.ReadToEnd();
            }
            //add a new line to do end of the firstfileContents string so the text from the second file is on a new line
            firstFileContents += "\r\n";

            using (StreamReader read = new StreamReader(secondFilePath))
            {
                secondFileContents = read.ReadToEnd();
            }

            string outputFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\02.ConcTextFiles\TextFiles\XoutputFile.txt";
            string outputFileSContents;
            using (StreamWriter write = new StreamWriter(outputFilePath))
            {
                StringBuilder build = new StringBuilder();
                build.Append(firstFileContents);
                build.Append(secondFileContents);
                outputFileSContents = build.ToString();
                write.WriteLine(outputFileSContents);
            }
        }
    }
}
