using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program that reverses the words in given sentence.
//	Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

namespace _13.ReverseWords
{
    class ReverseWords
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            List<string> words = new List<string>();
            List<string> separtors = new List<string>();
            string pattern = @"\w*#|\w*\+*";

            foreach (Match match in Regex.Matches(text, pattern))
            {
                if (match.Value != "") //add only words without "" for unrecogniseble characters (like #, ' ', !, ',' etc.)
                words.Add(match.Value); 
            }

            words.Reverse();

            string separate = @"\s+|,\s*|\.\s*|!\s*|$";

            foreach (Match match in Regex.Matches(text, separate))
            {   
                separtors.Add(match.Value);
            }

            for(int i = 0; i < words.Count; i ++)
            {
                if (i != words.Count - 1)
                {
                    Console.Write("{0} ", words[i]);
                }
                else
                {
                    Console.Write(words[i]); //at last word dont put a " "
                }

                if(separtors[i] != "")
                    Console.Write(separtors[i]);
            }

            Console.WriteLine();
        }
    }
}
