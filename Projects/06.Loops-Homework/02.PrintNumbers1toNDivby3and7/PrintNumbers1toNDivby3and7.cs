using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that prints all the numbers from 1 to N, that are NOT divisible by 3 and 7 at the same time.


namespace _02.PrintNumbers1toNDivby3and7
{
    class PrintNumbers1toNDivby3and7
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Please input n.");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine();

        }
    }
}
