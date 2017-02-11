using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program that extracts from a given text all sentences containing given word.
//		Example: The word is "in". The text is:

//We are living in a yellow submarine. We don't have anything else. 
//Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//Result:
//We are living in a yellow submarine.
//We will move out of it in 5 days.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.

namespace _08.ExtractGivenWord
{
    class ExtractGivenWord
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else." +
                          "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string pattern = @"\b(\w+\s*)+\.";

            Match match = Regex.Match(text, pattern);
            while (match.Success)
            {
                for (int groupNumber = 1; groupNumber < match.Groups.Count; groupNumber++)
                {
                    foreach (Capture word in match.Groups[groupNumber].Captures)
                    {
                        if (word.Value == "in ")
                        {
                            Console.WriteLine(match.Value);
                            break;
                        }
                    }


                }

                match = match.NextMatch();
            }

            Console.WriteLine();
        }
    }
}
