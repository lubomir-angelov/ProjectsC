using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. 
//Display them in the standard date format for Canada.
//Note - not working! - TO DO: fix

namespace _19.DateTimeExtract
{
    class DateTimeExtract
    {
        static void Main(string[] args)
        {
            string text = "Today is the 25.05.2013 and it is a beatiful day outside, unlike the last years day of horrific halestorms" +
                          "thorught the entire continent. Truly 25.05.2012 will be remembered for a long time.";

            string format = "dd.MMM.yy";

            //convert dtformat into regex pattern
            StringBuilder sb = new StringBuilder();
            foreach (char c in format)
            {
                if (Char.IsLetter(c))
                {
                    if (char.ToUpperInvariant(c) == 'D' || char.ToUpperInvariant(c) == 'H' || char.ToUpperInvariant(c) == 'S')
                        sb.Append(".{1,2}");
                    else
                        sb.Append(".");
                }
                else if (Char.IsWhiteSpace(c))
                    sb.Append("\\s");
                else
                    sb.Append(c);
            }


            string dtPattern = sb.ToString();

            Regex dtrx = new Regex(dtPattern);

            //get the match using the regex pattern
            var dtMatch = dtrx.Match(text);

            if (dtMatch != null)
            {
                string firstString = dtMatch.Value.Trim();

                //try and parse the datetime from the string
                DateTime firstMatch;
                if (DateTime.TryParseExact(firstString, format, null, DateTimeStyles.None, out firstMatch))
                {
                    Console.WriteLine("{0:fr-CA}", firstMatch);
                }
                else
                {
                    Console.WriteLine("No dd.mm.yyyy format");
                }
            }
        }
    }
}
