using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that calculates N!/K! for given N and K (1<K<N).

namespace _04.CalculateN_K_
{
    class CalculateN_K_
    {
        static void Main(string[] args)
        {
            int n, k;
            int factN = 1, factK = 1;

            Console.WriteLine("Please input n.");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input k.");
            k = int.Parse(Console.ReadLine());

            if (k < 1 || k > n || n < 0)
            {
                Console.WriteLine("Invalid input!");
            }

            for (int i = 2; i <= n; i++)
            {
                if (i <= k)
                {
                    factK *= i;
                }
                factN *= i;
            }

            Console.WriteLine("The factoriels of {0} and {1} are:\nK! = {2}\nN! = {3} .", k, n, factK, factN);
            
        }
    }
}
