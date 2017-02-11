using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints all the numbers from 1 to N.

namespace _01.PrintNumbers1toN
{
    class PrintNumbers1toN
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Please input n.");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}, ", i);
            }
            Console.WriteLine();
        }
    }
}
