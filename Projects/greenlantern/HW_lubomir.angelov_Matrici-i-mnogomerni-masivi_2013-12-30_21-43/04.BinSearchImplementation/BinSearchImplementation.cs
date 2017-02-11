using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, that reads from the console an array of N integers and an integer K, sorts the array 
//and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

namespace _04.BinSearchImplementation
{
    class BinSearchImplementation
    {
        //Enter array
        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        //Print Array
        static void PrintIntArray(int[] array)
        {
            foreach(int number in array)
                Console.Write("{0}, ", number);
            Console.WriteLine();
        }

        static void Main()
        {
            Console.WriteLine("Please enter N");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the array members");
            int[] arrayNumbers = new int[n];
            InputArray(n, arrayNumbers);
            Console.WriteLine("Please enter K");
            int k = int.Parse(Console.ReadLine());

            Array.Sort(arrayNumbers);
            Console.WriteLine("This is the sorted array");
            PrintIntArray(arrayNumbers);

            int index = Array.BinarySearch(arrayNumbers, k);


            //if there is a number equal to K the method returns its index (a positive integer value)

            if (index > 0)
            {
                Console.WriteLine("There is a number equal to K, it has an index --> {0}, here it is --> {1}", index, arrayNumbers[index]);
            }

             //If value is not found and value is less than one or more elements in array, a negative number 
             //which is the bitwise complement of the index of the first element that is larger than value.

            if (index < 0 && ~(index) < arrayNumbers.Length)
            {
                Console.WriteLine("This is the largest number, lesser than K  --> {0} it's index in the array is --> {1}", 
                    arrayNumbers[~(index) - 1], ~(index) - 1);
            }

            //If value is not found and value is greater than any of the elements in array, 
            //a negative number which is the bitwise complement of (the index of the last element plus 1).

            if (index < 0 && ~(index) == arrayNumbers.Length)
            {
                Console.WriteLine("K is greater than all of the elements of the array, SO here is the last element of the array --> {0}, with index --> {1}",                                              arrayNumbers[~(index) - 1], ~(index) - 1);
            }


        }
    }
}

