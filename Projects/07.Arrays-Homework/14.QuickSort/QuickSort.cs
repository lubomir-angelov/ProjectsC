using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

namespace _14.QuickSort
{
    class QuickSort
    {

        static bool isArrayNull(string[] array)
        {
            bool isNull = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == null)
                {
                    isNull = true;
                }
            }

            return isNull;
        }
        static string[] ConcatenateMyResult(string[] less, string pivot, string[] greater)
        {
            string[] result = new string[less.Length + greater.Length + 1];
            int greaterIndex = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (i < less.Length)
                {
                    result[i] = less[i];
                }
                if (i == less.Length)
                {
                    result[i] = pivot;
                }
                if (i > less.Length)
                {
                    result[i] = greater[greaterIndex];
                    greaterIndex++;
                }
            }

            return result;
        }

        static string[] QuickSortM(string[] array)
        {
            // check to see if the array has only null values, if it does we quit the recursion (skip the "empty" cicles)
            // we can have an array with only null values if all of the elemnts are lesser or greater than the pivot, then 
            // one of the arrays leftArray/rightArray will have only nulls and will the recursion will cycle through our
            // "solution" binary tree unnecessary number of times 
            if (isArrayNull(array)) 
            {
                return array;
            }
            if (array.Length <= 1)
            {
                return array;
            }

            int pivot = array.Length / 2;
            string[] leftArray = new string[array.Length - 1];
            string[] rightArray = new string[array.Length - 1];
            int leftArrayI = 0, rightArrayI = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int value = string.CompareOrdinal(array[i], array[pivot]);
                if (value < 0)
                {
                    leftArray[leftArrayI] = array[i];
                    leftArrayI++;
                }
                if (value > 0)
                {
                    rightArray[rightArrayI] = array[i];
                    rightArrayI++;
                }
            }

            
            return ConcatenateMyResult(QuickSortM(leftArray), array[pivot], QuickSortM(rightArray));
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Please input the length of the array");
            int length = int.Parse(Console.ReadLine());


            string[] Array = new string[length];

            for (int i = 0; i < length; i++)
            {
                string currentLine = Console.ReadLine();
                Array[i] = currentLine;
            }

            string[] sorted = QuickSortM(Array);

            for (int i = 0; i < sorted.Length; i++)
            {
                if(sorted[i] != null)
                Console.WriteLine(sorted[i]);
            }
        }
    }
}
