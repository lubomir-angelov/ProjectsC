
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
*/

namespace _05.MaxIncrSequence
{
    class MaxIncrSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the array");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if(length == 1)
                    Console.WriteLine(numbers[i]);
            }

            int lastElementOfSequnece = 0;
            int longestSeqCount = 0;

            for (int i = 0; i < length - 1; i++)
             {
                if (numbers[i] < numbers[i + 1]) // if(number[index] + 1 == number[index+1] 
                {
                    int countCurrentSequence = 2;
                    int indexer = i + 1;
                    while (indexer < length - 1 && numbers[indexer] < numbers[indexer + 1])
                    {
                        indexer++;
                        countCurrentSequence++;
                        lastElementOfSequnece = indexer;
                    }
                    if (countCurrentSequence > longestSeqCount)
                    {
                        longestSeqCount = countCurrentSequence;
                    }
                }
            }

            for (int i = lastElementOfSequnece - longestSeqCount + 1; i <= lastElementOfSequnece; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
