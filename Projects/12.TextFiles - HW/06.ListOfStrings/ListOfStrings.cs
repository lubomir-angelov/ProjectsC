using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. Example:
//    Ivan			George
//    Peter			Ivan
//    Maria			Maria
//    George			Peter
//Note: I am creating my files manually, please when checking homework rewrite file paths to suitable direcotires on your own machine.

namespace _06.ListOfStrings
{
    class ListOfStrings
    {
        static void Main(string[] args)
        {
            string firstFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\06.ListOfStrings\TextFiles\FirstFile.txt";
            string seondFilePath = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\06.ListOfStrings\TextFiles\SecondFile.txt";

            List<string> fileContents = new List<string>();

            using (StreamReader reader = new StreamReader(firstFilePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    fileContents.Add(line);
                    line = reader.ReadLine();
                }
                
            }

            fileContents.Sort();
            
            using (StreamWriter write = new StreamWriter(seondFilePath))
            {
                for (int listIndex = 0; listIndex < fileContents.Count; listIndex++)
                {
                    write.WriteLine(fileContents[listIndex]);
                }
            }

            Console.WriteLine("You have succesfully sorted the data from the file:\n{0}\nand written the sorted data in the file:\n{1}\n", firstFilePath, seondFilePath);
        }
    }
}
