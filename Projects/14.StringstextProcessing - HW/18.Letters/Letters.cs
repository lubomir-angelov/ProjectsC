using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string from the console and prints all different letters in the string along with information 
//how many times each letter is found. 
//source (1) --> http://stackoverflow.com/questions/541954/how-would-you-count-occurrences-of-a-string-within-a-string
//source (2) --> http://stackoverflow.com/questions/541954/how-would-you-count-occurrences-of-a-string-within-a-string/541976#541976
//I chose to use a LINQ expression
//possible with regex --> int count = new Regex(Regex.Escape(needle)).Matches(haystack).Count;
//or simple foreach (not suitable for multiple character/string occurences)
namespace _18.Letters
{
    class Letters
    {
        static void Main(string[] args)
        {
            string dictionary = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            string text = Console.ReadLine();

            for (int i = 0; i < dictionary.Length; i++)
            {
                int count = text.Count(c => c == dictionary[i]);
                if (count > 0)
                {
                    Console.WriteLine("The letter {0} is met {1} times in the text.", dictionary[i], count);
                }
            }
        }


    }
}
