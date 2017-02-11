//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Read3IntPrintSum
{
    class Read3IntPrintSum
    {
        static void Main(string[] args)
        {
            int a, b, c;
            bool isAInt = int.TryParse(Console.ReadLine(), out a);
            bool isBInt = int.TryParse(Console.ReadLine(), out b);
            bool isCInt = int.TryParse(Console.ReadLine(), out c);

            if (isAInt && isBInt && isCInt)
            {
                Console.WriteLine("Sum = {0}", a + b + c);
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}
