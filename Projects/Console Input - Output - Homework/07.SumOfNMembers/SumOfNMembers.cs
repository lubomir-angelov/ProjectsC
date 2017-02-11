//Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOfNMembers
{
    class SumOfNMembers
    {
        static void Main(string[] args)
        {
            int n, sum = 0;

            bool isNInt = int.TryParse(Console.ReadLine(), out n);

            if (isNInt)
            {
                for (int i = 0; i < n; i++)
                {
                    int a = 0;
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    sum += a;
                }
                Console.WriteLine("The sum = {0}", sum);
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}
