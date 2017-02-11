using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 
 * (find it in Wikipedia).
*/

namespace _11.BinarySearch
{
    class BinarySearch
    {
        static void InputArray(int n, int[] array)
        {
            Console.WriteLine("Please input the array members separated by a new line.");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static int BinarySearchFunction(int[] numbers, int x, int imin, int imax)
        {
            int imid = (imin + imax) / 2;
            if (numbers[imid] == x)
            {
                return imid;
            }

            if (numbers[imid] > x)
            {
                imax = imid - 1;
                return BinarySearchFunction(numbers, x, imin, imax);
            }
            if (numbers[imid] < x)
            {
                imin = imid + 1;
                return BinarySearchFunction(numbers, x, imin, imax);
            }

            return imid;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the element");
            int elementToFind = int.Parse(Console.ReadLine());

            int[] input = new int[n];

            InputArray(n, input);
            Array.Sort(input);
            Console.WriteLine(BinarySearchFunction(input, elementToFind, 0, input.Length));
        }
    }
}
