//Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareWithoutIf
{
    class CompareWithoutIf
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("The greater number is: {0}", a > b ? a : b);
        }
    }
}
