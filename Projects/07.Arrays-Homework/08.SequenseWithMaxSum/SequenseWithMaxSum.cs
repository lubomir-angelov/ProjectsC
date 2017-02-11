using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the sequence of maximal sum in given array. Example:
	{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
	Can you do it with only one loop (with single scan through the elements of the array)?
*/
namespace _08.SequenseWithMaxSum
{
    class SequenseWithMaxSum
    {

        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void MaxSubArray(int[] array)                    //Kadane's algorithm
        {
            int currentMaxSum = array[0], firstNumberOfSequence = array[0];
            int begining = 0, beginingTemp = 0, end = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (firstNumberOfSequence < 0)
                {
                    firstNumberOfSequence = array[i];
                    beginingTemp = i;
                }
                else
                {
                    firstNumberOfSequence += array[i];
                }
                if (firstNumberOfSequence >= currentMaxSum)    //The = in this line is optional, this version includes "border" cases
                                                               //like the one in the example in the .pptx : 2, -1, 6, 4
                                                               //but 2, -1, 6, 4, -8, 8 is also valid
                {
                    currentMaxSum = firstNumberOfSequence;
                    begining = beginingTemp;
                    end = i;
                }
                
            }
            for (int i = begining; i <= end; i++)
            {
                Console.Write("{0}, ", array[i]);
            }
        }

        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int[] input = new int[n];

            InputArray(n, input);
            MaxSubArray(input);
            Console.WriteLine();
        }
    }
}
