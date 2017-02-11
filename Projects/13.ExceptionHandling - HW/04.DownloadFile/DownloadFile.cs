using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

//Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
//and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions 
//and to free any used resources in the finally block.


namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            string filePathToDownload = @"http://nssdc.gsfc.nasa.gov/image/planetary/saturn/saturn.jpg";
            string saveToPath = @"D:\Programming\VisualStudioPrograms\Projects\13.ExceptionHandling - HW\04.DownloadFile\Downloads\image.jpg";
            WebClient webClient = new WebClient();

            try
            {
                webClient.DownloadFile(filePathToDownload, saveToPath);
                Console.WriteLine("You have succesfully downloaded and saved the image.");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("The address parameter is null.");
            }
            catch (WebException)
            {
                Console.WriteLine("The URI formed by combining BaseAddress and address is invalid.\n -or-\nfilename is null or Empty.\n-or-\nThe file does not exist.\n  -or- An error occurred while downloading data.\n");
            }

        }
    }
}
