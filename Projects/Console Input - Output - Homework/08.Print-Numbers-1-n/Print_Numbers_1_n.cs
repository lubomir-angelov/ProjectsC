//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Print_Numbers_1_n
{
    class Print_Numbers_1_n
    {
        static void Main(string[] args)
        {
            int n;

            bool isNInt = int.TryParse(Console.ReadLine(), out n);

            if (isNInt)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}
