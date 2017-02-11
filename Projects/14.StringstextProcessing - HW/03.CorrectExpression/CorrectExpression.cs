using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
//http://msdn.microsoft.com/en-us/library/bs2twtah(v=vs.110).aspx -- grouping constructs 

namespace _03.CorrectExpression
{
    class CorrectExpression
    {
        static void MatchingParenthesis(string text)
        {
            //Note: double backslash so the VS picks up the escaping sequence --> \\(

            string pattern =  "^[^\\(\\)]*(((?'Open'\\()[^\\(\\)]*)+((?'Close-Open'\\))[^\\(\\)]*)+)*(?(Open)(?!))$";

            Match match = Regex.Match(text, pattern);

            if (match.Success == true)
            {
                Console.WriteLine("The brackets are put corectly.");
            }
            else
            {
                Console.WriteLine("The brackets are NOT put correctly.");
            }
        }

        static void Main(string[] args)
        {
            string expression = ")(a+b))";
            MatchingParenthesis(expression);
        }
    }
}
