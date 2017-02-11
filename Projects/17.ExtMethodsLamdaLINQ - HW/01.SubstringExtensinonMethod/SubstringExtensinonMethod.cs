using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1. Implement an extension method Substring(int 
index, int length) for the class 
StringBuilder that returns new StringBuilder 
and has the same functionality as Substring in the 
class String. */

namespace _01.SubstringExtensinonMethod
{
    static class SubstringExtensinonMethod
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder resultSB = new StringBuilder("");
            return resultSB.Append(sb.ToString(), index, length);
        }
      
        static void Main(string[] args)
        {
            StringBuilder mySB = new StringBuilder("Hello world!");
            StringBuilder newSB = new StringBuilder("");
            newSB = Substring(mySB, 6, 5);
            Console.WriteLine(newSB);
        }
    }
}
