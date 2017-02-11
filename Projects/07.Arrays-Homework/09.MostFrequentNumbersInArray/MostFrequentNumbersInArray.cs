using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
*/

namespace _09.MostFrequentNumbersInArray
{
    class MostFrequentNumbersInArray
    {
        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void MostFrequentElementInNumbersArray(int[] arrayNumbers)
        {
            int counter = 0, number = 0;
            
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int currentNumber = arrayNumbers[i];
                int tempCounter = 0;
                for (int j = i; j < arrayNumbers.Length; j++)
                {
                    if (currentNumber == arrayNumbers[j])
                    {
                        tempCounter++;
                    }
                }
                if (tempCounter > counter)
                {
                    counter = tempCounter;
                    number = currentNumber;
                }
            }
            Console.WriteLine("This {0} is the most frequent number, it is met {1} times", number, counter);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the array");
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];
            InputArray(n, input);
            MostFrequentElementInNumbersArray(input);
        }
    }
}
