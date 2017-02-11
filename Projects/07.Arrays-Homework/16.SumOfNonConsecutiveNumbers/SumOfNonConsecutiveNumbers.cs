using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements of the array
//  that has a sum S. Example:
//	arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)



namespace _16.SumOfNonConsecutiveNumbers
{
    class SumOfNonConsecutiveNumbers
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the array");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input S");
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the array");

            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            bool[] solutions = new bool[sum + 1];

            solutions[0] = true;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = sum; j > 0; j --)
                {
                    if (j - numbers[i] >= 0)
                    {
                        if (solutions[j - numbers[i]] == true)
                        {
                            solutions[j] = true;
                        }
                    }
                }
            }
            if (solutions[sum])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
