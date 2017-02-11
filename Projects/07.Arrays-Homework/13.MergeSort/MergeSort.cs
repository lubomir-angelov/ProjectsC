
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * * Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).
*/

namespace _13.MergeSort
{
    class MergeSort
    {

        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        static int[] MergeTwoArrays(int[] firstArray, int[] secondArray)
        {
            int[] result = new int[firstArray.Length + secondArray.Length];

            int firstArrayIndex = 0, secondArrayIndex = 0;

            for (int i = 0; i < result.Length; i++)
            {
                if (secondArrayIndex == secondArray.Length || ((firstArrayIndex < firstArray.Length) && (firstArray[firstArrayIndex] <= secondArray[secondArrayIndex])))
                {
                    result[i] = firstArray[firstArrayIndex];
                    firstArrayIndex++;
                }
                else
                {
                    if (firstArrayIndex == firstArray.Length || ((secondArrayIndex < secondArray.Length) && (secondArray[secondArrayIndex] <= firstArray[firstArrayIndex])))
                    {
                        result[i] = secondArray[secondArrayIndex];
                        secondArrayIndex++;
                    }
                }
            }

            return result;
        }

        static int[] SplitArrayInTwoAndMergeSort(int[] numbers)
        {
            if (numbers.Length <= 1)
            {
                return numbers;
            }

            int mid = numbers.Length / 2;
            int[] leftArray = new int[mid];
            int[] rightArray = new int[numbers.Length - mid];

            for (int i = 0; i < mid; i++)
            {
                leftArray[i] = numbers[i];
            }

            for(int i = mid, j = 0; i < numbers.Length; i ++, j ++)
            {
                rightArray[j] = numbers[i];
            }

            leftArray = SplitArrayInTwoAndMergeSort(leftArray);
            rightArray = SplitArrayInTwoAndMergeSort(rightArray);

            return MergeTwoArrays(leftArray, rightArray);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the array you would like to mergesort");
            int length = int.Parse(Console.ReadLine());

            int[] input = new int[length];
            
            InputArray(length, input);
            int[] SortedArray = SplitArrayInTwoAndMergeSort(input);
            

            for (int i = 0; i < SortedArray.Length; i++)
            {
                Console.WriteLine(SortedArray[i]);
            }
        }
    }
}
