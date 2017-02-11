using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 */

namespace _10.SubsetSum
{
    class SubsetSum
    {
        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void MaxSubArray(int[] array, int sum)                    
        {
            int firstNumberOfSequence = array[0];
            int begining = 0, beginingTemp = 0, end = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (firstNumberOfSequence == sum)
                {
                    Console.WriteLine(array[0]);
                    break;
                }

                firstNumberOfSequence += array[i];

                if (firstNumberOfSequence >= sum)    
                {
                    if (firstNumberOfSequence == sum)
                    {
                        begining = beginingTemp;
                        end = i;
                        break;
                    }

                    firstNumberOfSequence = array[i];
                    beginingTemp = i;
                }

            }

            if (begining >= 0 && end != 0)
            {

                for (int i = begining; i <= end; i++)
                {
                    Console.Write("{0}, ", array[i]);
                }
            }
            else
            {
                Console.WriteLine("No subset adds to the given sum");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the sum");
            int sum = int.Parse(Console.ReadLine());

            int[] input = new int[n];

            InputArray(n, input);
            MaxSubArray(input, sum);
            Console.WriteLine();

        }
    }
}
