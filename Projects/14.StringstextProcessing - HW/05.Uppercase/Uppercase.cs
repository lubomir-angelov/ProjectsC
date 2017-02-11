using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
//The tags cannot be nested. Example:
//We are living in a <upcase>yellow submarine</upcase>. 
//We don't have <upcase>anything</upcase> else.
//Result:
//We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

namespace _05.Uppercase
{
    class Uppercase
    {
        static string ToUpperCase(int startingIndex, int endingIndex, string text)
        {
            //find the text inside <upcase> ... </upcase> and copy it to temp
            char[] temp = new char[endingIndex - startingIndex];
            text.CopyTo(startingIndex, temp, 0, endingIndex - startingIndex);
            //change temp to a string 
            string oldValue = new string(temp);
            //change the casing
            string newValue = oldValue.ToUpper();
            //replace the lowercase string with uppercase string in the original string
            text = text.Replace(oldValue, newValue);

            return text;
        }
        static void Main(string[] args)
        {
            string input = "We are living in a <upcase>yellow submarine</upcase>. " +
                           "We don't have <upcase>anything</upcase> else.";
            string first = "<upcase>";
            string second = "</upcase>";

            while (input.IndexOf(first) != -1 && input.IndexOf(second) != -1)
            {
                int firstStartingIndex = input.IndexOf(first);
                int secondStartingIndex = input.IndexOf(second);
                
                //change to upper case
                input = ToUpperCase(input.IndexOf(first) + 8, secondStartingIndex, input);

                //delete the <upcase> string
                input = input.Remove(firstStartingIndex, 8);

                //now our string has a different index-ation so:
                secondStartingIndex = input.IndexOf(second);

                //delet the </upcase> string
                input = input.Remove(secondStartingIndex, 9);
            }
            
            Console.WriteLine(input);

        }
    }
}
