using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

namespace _03.MinMaxOfInterval
{
    class MinMaxOfInterval
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please input n.");
            n = int.Parse(Console.ReadLine());

            int input;
            int? max = null, min = null;

            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());

                if (max == null && min == null)
                {
                    max = input;
                    min = input;
                }
                if (input > max)
                {
                    max = input;
                }
                else
                {
                    if (input < min)
                    {
                        min = input;
                    }
                }
            }

            Console.WriteLine("The maximal value is max = {0}, the minimal value is min = {1}", max, min);
        }
    }
}
