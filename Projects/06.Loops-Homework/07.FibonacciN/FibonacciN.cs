using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that reads a number N and calculates the sum of the first N members of the sequence 
//of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

namespace _07.FibonacciN
{
    class FibonacciN
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Please input n.");
            n = int.Parse(Console.ReadLine());

            BigInteger fib1 = 0, fib2 = 1, fib3 = 0, sumfib = 1;

            for (int i = 1; i <= n -2; i++)
            {
                fib3 = fib1 + fib2;
                fib1 = fib2;
                fib2 = fib3;
                sumfib += fib3;
            }

            Console.WriteLine("The sum of the {1} members is: {0}", sumfib, n);

        }
    }
}
