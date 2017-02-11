//Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _09.First_100_Numbers_Fibonaci
{
    class First_100_Numbers_Fibonaci
    {
        static void Main(string[] args)
        {
            BigInteger fi1 = 0, fi2 = 1;

            for (int i = 0; i < 100; i++)
            {
                BigInteger nextNumber = fi1 + fi2; //ulong overflow around member 90?
                fi1 = fi2;
                fi2 = nextNumber;
                Console.WriteLine(nextNumber);
            }
        }
    }
}
