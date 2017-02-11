using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _08.ModifyMethod
{
    class ModifyMethod
    {
        static void Main(string[] args)
        {
            string fileToRead = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\08.ModifyMethod\TextFiles\Text.txt";
            string fileToWrite = @"D:\Programming\VisualStudioPrograms\Projects\12.TextFiles - HW\08.ModifyMethod\TextFiles\WriteText.txt";
            List<string> firstFileContents = new List<string>();

            using (FileStream fStream = File.Open(fileToRead, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (BufferedStream buffer = new BufferedStream(fStream))
            using (StreamReader read = new StreamReader(buffer))
            {
                string line = read.ReadLine();
                while (line != null)
                {
                    line = Regex.Replace(line, @"\bstart\b", "finish");//modifyng this line with regular expressions
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

            Console.WriteLine("You have succesfully read from the file:\n\n{0}\n\nReplaced the word start with the word finish and written the new text in\n\n{1}\n\n"
                              , fileToRead, fileToWrite);
        }
    }
}
