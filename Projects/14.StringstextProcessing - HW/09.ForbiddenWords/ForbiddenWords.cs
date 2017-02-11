using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given a string containing a list of forbidden words and a text containing some of these words. 
//Write a program that replaces the forbidden words with asterisks. Example:
//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 
//and is implemented as a dynamic languagein CLR.

//Words: "PHP, CLR, Microsoft"
//        The expected result:
//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is 
//implemented as a dynamic language in ***.


namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static string replaceAWordInString(string word, string text)
        {
            string result = text.Replace(word, new string('*', word.Length));
            return result;
        }

        static void Main(string[] args)
        {
            string[] dictionary = {"PHP", "CLR", "Microsoft"};
            string text = 
            "Microsoft announced its next generation PHP compiler today." + 
            "It is based on .NET Framework 4.0 and is implemented as a dynamic languagein CLR.";

            for (int i = 0; i < dictionary.Length; i++)
            {
                text = replaceAWordInString(dictionary[i], text);
            }

            Console.WriteLine(text);
        }
    }
}
