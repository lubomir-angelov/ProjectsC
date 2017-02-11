
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
//	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

namespace _20.VariationsOfKElements
{
    class VariationsOfKElements
    {
        static int n = int.Parse(Console.ReadLine());
        static int k = int.Parse(Console.ReadLine());

        static void Variations(int a, int[] numbers)
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
                for (int i = 1; i <= n; i++)
                {
                    numbers[a] = i;
                    Variations(a + 1, numbers);
                }
            }
           
        }
        static void Main(string[] args)
        {
            int[] numbers = new int[k];
            Variations(0, numbers);
        }
    }
}
