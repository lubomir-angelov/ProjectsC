//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
//the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersPinGivenInterval
{
    class NumbersPinGivenInterval
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            int p = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0) p++;
            }
            Console.WriteLine("The numbers that divide by 5 without a reminder are: {0}", p);
        }
    }
}
