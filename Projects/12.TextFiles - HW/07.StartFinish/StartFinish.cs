using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
//Ensure it will work with large files (e.g. 100 MB).
//Note: I am creating my files manually, please when checking homework rewrite file paths to suitable direcotires on your own machine.
//idea from http://stackoverflow.com/questions/2161895/reading-large-text-files-with-streams-in-c-sharp
//discussion wheter it's faster to wrap a buffer around the already buffered (StreamReader/Writer) methods  
//interesting tests, done without an additional buffer :
//http://designingefficientsoftware.wordpress.com/2011/03/03/efficient-file-io-from-csharp/ 
////Note: I am creating my files manually, please when checking homework rewrite file paths to suitable direcotires on your own machine.

namespace _07.StartFinish
{
    class StartFinish
    {
        static void Main(string[] args)
        {
            string fileToRead = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\07.StartFinish\TextFiles\Text.txt";
            string fileToWrite = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\07.StartFinish\TextFiles\WriteText.txt";
            List<string> firstFileContents = new List<string>();

            using (FileStream fStream = File.Open(fileToRead, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream buffer = new BufferedStream(fStream))
            using (StreamReader read = new StreamReader(buffer))
            {
                string line = read.ReadLine();
                while (line != null)
                {
                    line = line.Replace("start", "finish");//keeping in mind the differnce between Upper/Lower case
                    firstFileContents.Add(line);
                    line = read.ReadLine();
                }
            }

            using (StreamWriter write = new StreamWriter(fileToWrite))
            {
                for (int i = 0; i < firstFileContents.Count; i++)
                {
                    write.WriteLine(firstFileContents[i]);
                }
            }

            Console.WriteLine("You have succesfully read from the file:\n\n{0}\n\nReplaced the substring start with the substring finish and written the new text in\n\n{1}\n\n", fileToRead, fileToWrite);
        }
    }
}
