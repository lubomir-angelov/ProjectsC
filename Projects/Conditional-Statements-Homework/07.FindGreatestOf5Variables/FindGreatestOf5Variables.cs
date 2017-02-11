using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the greatest of given 5 variables.

namespace _07.FindGreatestOf5Variables
{
    class FindGreatestOf5Variables
    {
        static void Main(string[] args)
        {
            int n, var = 0, greatestVar = 0;

            Console.WriteLine("Plese input the number of variables you would like to compare.");
            n = int.Parse(Console.ReadLine());  

            for(int i = 0; i < n; i++)
            {
                var = int.Parse(Console.ReadLine());
                if(var >= greatestVar) greatestVar = var;
            }

            Console.WriteLine("The greatest variable is: {0}", greatestVar);

        }
    }
}
