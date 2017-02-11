using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
 * Find in the array a subset of K elements that have sum S or indicate about its absence.
 */

namespace _17.SubsetOfKAddsToS
{
    class SbsetOfKAddsToS
    {
        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void FindSubsetOfKElements(int[] array, int sum, int subsetLength)
        {            
            int firstNumberOfSequence = array[0];
            int counter = 1;
            //int begining = 0, beginingTemp = 0, end = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (firstNumberOfSequence == sum && subsetLength == 1)
                {
                    Console.WriteLine("There is such a subset");
                    return;
                }

               
                firstNumberOfSequence += array[i];
                counter++;

                if(firstNumberOfSequence >= sum)
                {
                    if(firstNumberOfSequence == sum && counter == subsetLength)
                    {
                        Console.WriteLine("There is such a subset");
                        return;
                    }

                    firstNumberOfSequence = array[i];
                    counter = 0;
                    counter++;
                }

                if(i == array.Length - 1 && (counter != subsetLength || firstNumberOfSequence != sum))
                {
                    Console.WriteLine("There is no such subset");
                    return;
                }
            }
               
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input K");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input S");
            int s = int.Parse(Console.ReadLine());

            int[] input = new int[n];

            InputArray(n, input);
            FindSubsetOfKElements(input, s, k);
            Console.WriteLine();

        }
    }
}

