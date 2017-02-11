using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//In the combinatorial mathematics, the Catalan numbers are calculated by the following formula: Cn = (2n)!/(n+1)!n!
//Write a program to calculate the Nth Catalan number by given N.

namespace _09.CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int n;
            BigInteger factN = 1, fact2n = 1, factn1 = 1;

            Console.WriteLine("Please input the number n.");
            n = int.Parse(Console.ReadLine());

            double catalan;

            for (int i = 2; i <= n; i++)
            {                            
                factN *= i;
            }
            for (int i = 2; i <= 2 * n; i++)
            {
                fact2n *= i;
            }
            factn1 = factN * (n+1);
            BigInteger divider = factn1 * factN;
            catalan = (double) (fact2n / divider);
            Console.WriteLine("The catalan number of {0} is {1}", n, catalan);
        }
    }
}
