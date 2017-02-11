//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class IsPrime
    {
        static void Main()
        {
            uint n;

            Console.WriteLine("Please input a positive integer number, number <= 100 :");
            bool isUint = uint.TryParse(Console.ReadLine(), out n);

            if (isUint && n <= 100)
            {
                uint divider = 2;
                uint maxDivider = (uint) Math.Sqrt(n);
                bool prime = true;
                while (prime && (divider <= maxDivider))
                {
                    if (n % divider == 0)
                    {
                        prime = false;
                    }
                    divider++;
                }
                Console.WriteLine("Is {0} Prime? - {1}", n, prime);
            }
            else Console.WriteLine("Invalid input!");
        }
    }

