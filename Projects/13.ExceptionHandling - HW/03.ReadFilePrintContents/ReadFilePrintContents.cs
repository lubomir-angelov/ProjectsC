using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security;

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), 
//reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). 
//Be sure to catch all possible exceptions and print user-friendly error messages.

namespace _03.ReadFilePrintContents
{
    class ReadFilePrintContents
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();
            string fileContents = null;

            try
            {
                using (StreamReader read = new StreamReader(filePath))
                {
                    fileContents = read.ReadToEnd();
                }
                Console.WriteLine(fileContents);
            }

            catch (ArgumentNullException)
            {
                Console.WriteLine("The path is null");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The chosen path is a zero-length string, contains only white space, or contains one or more invalid characters");

            }

            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length.");
            }

            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid");
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The chosen path is one of three either read-only or the requested operation is not supported on the current platform or  the path specified a directory.");
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");        
            }

            catch (NotSupportedException)
            {
                Console.WriteLine("File not supprted");
            }
            catch (SecurityException)
            {
                Console.WriteLine("The caller does not have the required permission.");
            }

        }
    }
}
