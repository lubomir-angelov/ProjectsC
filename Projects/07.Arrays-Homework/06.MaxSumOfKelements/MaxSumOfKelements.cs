using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.
 */ 

namespace _06.MaxSumOfKelements
{
    class MaxSumOfKelements
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(", ", numbers));
            Array.Sort(numbers);
            int sum = 0;

            for (int i = numbers.Length - k; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("The maximal sum from the elements is {0}", sum);
        }
    }
}
