using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

namespace _05.NfactKfactMultiplAndMinus
{
    class NfactKfactMultiplAndMinus
    {
        static void Main(string[] args)
        {
            BigInteger factN = 1, factK = 1, productFact, differenceKNFact = 1;

            int n, k;

            Console.WriteLine("Please input n.");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input k.");
            k = int.Parse(Console.ReadLine());

            if (n < 1 || n > k || k < 1)
            {
                Console.WriteLine("Invalid input!");
            }

            int differenceKN = k - n;

            for (int i = 2; i <= k; i++)
            {
                if (i <= n)
                {
                    factN *= i;
                }
                if (i <= differenceKN)
                {
                    differenceKNFact *= i;
                }

                factK *= i;
            }

            productFact = factN * factK;
            
            Console.WriteLine("N!*K! = {0}\n(K-N)! = {1}", productFact, differenceKNFact);

        }
    }
}
