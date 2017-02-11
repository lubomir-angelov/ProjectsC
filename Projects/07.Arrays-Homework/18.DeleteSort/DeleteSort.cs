using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Write a program that reads an array of integers and removes from it a minimal number of elements in such way that 
//  the remaining array is sorted in increasing order. Print the remaining sorted array. Example:
//    {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}


namespace _18.DeleteSort
{
    class DeleteSort
    {
        static int length = int.Parse(Console.ReadLine());
        static int[] array = new int[length];

        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void OutputArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void PrintList(List<int> theList)
        {
            foreach (int number in theList)
            {
                Console.WriteLine(number);
            }
        }

        static List<int> ArrayCutter(int[] array)
        {
            List<int> result = new List<int>();
            int leftComparer = 0, rightComparer = 0, leftOuts = 0;

            if (array[0] < array[1])
            {
                result.Add(array[0]);
            }
            else
            {
                leftOuts = array[0];
            }
            for (int i = 1; i < array.Length - 1; i++)
            {
                 
                leftComparer = array[i - 1];
                rightComparer = array[i + 1];

                if (leftComparer == leftOuts)
                {
                    if (result.Count != 0)
                    {
                        leftComparer = result[result.Count - 1];
                    }
                    else
                    {
                        leftComparer = int.MinValue;
                    }
                }

                if (array[i] > leftComparer && array[i] < rightComparer)
                {
                    result.Add(array[i]);
                }
                else
                {
                    leftOuts = array[i];
                }

                if (i == array.Length - 2 && rightComparer > result[result.Count - 1])
                {
                    result.Add(rightComparer);
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter the length of the array");
            //Console.WriteLine("Please enter the array");

            InputArray(length, array);
            PrintList(ArrayCutter(array));
        }
    }
}
