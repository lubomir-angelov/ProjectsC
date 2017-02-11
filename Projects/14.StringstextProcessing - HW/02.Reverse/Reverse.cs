using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

namespace _02.Reverse
{
    class Reverse
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            char[] charArray = line.ToCharArray();
            Array.Reverse(charArray);
            line = new string (charArray);
            Console.WriteLine(line);
        }
    }
}
