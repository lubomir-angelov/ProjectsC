using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

namespace _06.CalcSum
{
    class CalcSum
    {
        static void Main(string[] args)
        {
            int n, x;
            long factN = 1, powX;
            double sum = 1;

            Console.WriteLine("Please input n.");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input x.");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                factN *= i;
                powX = (long) Math.Pow(x, i);
                sum += (double) factN / powX; 
            }

            Console.WriteLine("The sum is S = {0}", sum);
        }
    }
}
