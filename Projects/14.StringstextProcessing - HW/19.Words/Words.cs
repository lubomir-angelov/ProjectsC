using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;
using System.IO;

//Write a program that reads a string from the console and lists all different words in the string along with information 
//how many times each word is found.


namespace _19.Words
{
    class Words
    {
        static int countOccurences(string needle, string haystack)
        {
            return (haystack.Length - haystack.Replace(needle, "").Length) / needle.Length;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input the text starting with a space, otherwise the starting word may not be included in the count.");
            string text = " that this is Sparta Sparta";
            int counter = 0;
            string pattern = @"\b\w*\s";
            List<string> words = new List<string>();
            words.Add("zx");//add a string so we can make (1)

            //Match match = new Regex.Matches(text, pattern);

            foreach (Match word in Regex.Matches(text, pattern))
            {
                counter = 0;

                for (int i = words.Count - 1; i >= 0; i--)
                {
                    if (words[i] == word.Value) //(1) here if the list is empty ( 0 elements) we get an IOR exception
                    {
                        counter++;
                        break;
                    }

                    if (counter == 0)
                    {
                        words.Add(word.Value);
                        break;
                    }
                }
            }

            string[] source = text.Split(' ');

            for(int i = 1; i < words.Count; i++) //(skip or "zx" input)
            {
                string needle = " " + words[i].Trim(); //add a space in front of the word so "is" is not counted in this (E.g.) TO DO find a better way
                int count = countOccurences(needle, text);
                Console.WriteLine("The word {0} is met {1} times", words[i], count);
            }

            
            Console.WriteLine();

            //TO DO: test this ----------------------
            //var matchQuery = from myWord in source
            //                 where myWord == words[i]
            //                 select myWord;

            //int wordCount = matchQuery.Count();
        }
    }
}
