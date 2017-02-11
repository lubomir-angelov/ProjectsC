
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

namespace _15.SieveOfErathostenes
{
    class SieveOfErathostenes
    {
        static long[] sieve = new long[10000001];
        static void eratosten(long n)
        {
            long mark = 0, number = 2;
            while (number <= n)
            {
                if (sieve[number] == 0 && sieve[number] != 10000000)
                {
                    Console.WriteLine(number);
                    mark = number;
                    do
                    {
                        sieve[mark] = 1;
                        mark += number;
                    } while (mark < n);
                }
                number++;
            }
        }
        static void Main(string[] args)
        {
            sieve[10000000] = 1;
            long n = 10000000;
            Console.WriteLine(1);
            eratosten(n);


//should be done with lists, so we don't have to exclude the "nulls", also most probably more efficient; 
//!must be rewritten!
        }
    }
}
