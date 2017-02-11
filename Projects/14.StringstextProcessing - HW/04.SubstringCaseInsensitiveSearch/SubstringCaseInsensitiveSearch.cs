using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:
//We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight.
//So we are drinking all the day. We will move out of it in 5 days.
//The result is: 9.

namespace _04.SubstringCaseInsensitiveSearch
{
    class SubstringCaseInsensitiveSearch
    {
        static void Main(string[] args)
        {
            string pattern = "in";  
            string input = 
            "We are living in an yellow submarine. We don't have anything else. " +
            "Inside the submarine is very tight.So we are drinking all the day. We will move out of it in 5 days.";

            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = r.Matches(input);
            Console.WriteLine("The result is: {0}", matches.Count.ToString()); 
        }
    }
}
