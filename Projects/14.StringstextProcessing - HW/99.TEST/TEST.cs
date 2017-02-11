
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _99.TEST
{
    class TEST
    {

        static void Main()
        {
            string text = "that this is Sparta Sparta";

            //Convert the string into an array of words 
            string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            
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

            for (int i = 1; i < words.Count; i++) //(skip or "zx" input)
            {
               var matchQuery = from word in source
                             where word.ToLowerInvariant() == words[i].ToLowerInvariant()
                             select word;

                int wordCount = matchQuery.Count();

                //string needle = words[i].Trim();
                //int count = countOccurences(needle, text);

                Console.WriteLine("The word {0} is met {1} times", words[i], wordCount);
            }

            // Create and execute the query. It executes immediately  
            // because a singleton value is produced. 
            // Use ToLowerInvariant to match "data" and "Data"  
            

            // Count the matches. 
           
        }

        //public static void Main()
        //{
        //    string input = "This is a sentence. This is another sentence.";
        //    string pattern = @"\b(\w+\s*)+\.";
        //    Match match = Regex.Match(input, pattern);
        //    if (match.Success)
        //    {
        //        Console.WriteLine("Matched text: {0}", match.Value);
        //        for (int ctr = 1; ctr < match.Groups.Count; ctr++)
        //        {
        //            Console.WriteLine("   Group {0}:  {1}", ctr, match.Groups[ctr].Value);
        //            int captureCtr = 0;
        //            foreach (Capture capture in match.Groups[ctr].Captures)
        //            {
        //                Console.WriteLine("      Capture {0}: {1}",
        //                                  captureCtr, capture.Value);
        //                captureCtr++;
        //            }
        //        }
        //    }
        //}
    }
}
