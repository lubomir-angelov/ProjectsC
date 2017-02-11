using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:
//Hi!
//Expected output:
//\u0048\u0069\u0021

namespace _10.UnicodeCharLits
{
    class UnicodeCharLits
    {
        static void Main(string[] args)
        {
            string text = "This is more complex than just Hi!";
            string result = null;

            for (int i = 0; i < text.Length; i++)
            {
                result += String.Format(@"\u{0:x4}", (ushort)text[i]);
            }

            Console.WriteLine(result);
        }
    }
}
