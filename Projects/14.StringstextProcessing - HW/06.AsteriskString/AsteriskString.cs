using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, 
//the rest of the characters should be filled with '*'. Print the result string into the console.


namespace _06.AsteriskString
{
    class AsteriskString
    {
        static string readString()
        {

            //string character = Console.Read().ToString();
            string result = null;
            ConsoleKeyInfo keyPressed = Console.ReadKey();
            int counter = 0;

            while (counter <= 20 && keyPressed.Key.ToString() != "Enter")
            {
                char c = keyPressed.KeyChar;
                result += c;
                counter++;
                keyPressed = Console.ReadKey();
            }

            Console.WriteLine();    
            return result;
        }

        static string AddAsterikses(string s)
        {
            string asterisk = new string('*', 20 - s.Length);
            s = s + asterisk;
            return s;
        }

        static void Main(string[] args)
        {
            string result = null;
            result = readString();
            result = AddAsterikses(result);
            Console.WriteLine("This is the resulting string {0} and its length {1}", result, result.Length);
        }
    }
}
