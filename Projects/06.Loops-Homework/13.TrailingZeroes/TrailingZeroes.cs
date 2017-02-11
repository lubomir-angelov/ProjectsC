using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

//Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
//	N = 10  N! = 3628800  2
//	N = 20  N! = 2432902008176640000  4
//	Does your program work for N = 50 000?
//	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!

namespace _13.TrailingZeroes
{
    class TrailingZeroes
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please input the number n.");
            n = int.Parse(Console.ReadLine());

      //      BigInteger nFact = 1;
            int count = 0;

            for (int i = 5; i <= n; i *= 5)
            {
                count = count + (n / i);
            }
      /*      for (int i = 2; i <= n; i++)
            {
                nFact *= i;
            }   */

            Console.WriteLine("The trailing zeroes of {0}! are {1}", n, count);
            //Works for n = 50 000 , a bit slow 
        }
    }
}
