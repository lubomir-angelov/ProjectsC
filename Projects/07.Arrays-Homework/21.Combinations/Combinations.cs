
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
//	N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

namespace _21.Combinations
{
    class Combinations
    {
        static int n = int.Parse(Console.ReadLine());
        static int k = int.Parse(Console.ReadLine());

        static void CombinationsFunction(int a, int b, int[] numbers)
        {
            if (a == numbers.Length)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }

            else
            {
                for (int i = b; i <= n; i++)
                {
                    numbers[a] = i;
                    CombinationsFunction(a + 1, i + 1, numbers);
                }
            }

        }


        static void Main(string[] args)
        {
            int[] numbers = new int[k];
            CombinationsFunction(0, 1, numbers);
        }
    }
}
