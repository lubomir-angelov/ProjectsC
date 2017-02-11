using System;
using System.Collections.Generic;

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit;
//the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
//I find the task to have two intepretations (cases) : 
//E.G. - 123 --> arr[0] = 1, arr[1] = 2, arr[2] = 3, the last digit being kept at index 0 -> one, so the number to be added is 321 (case 1)
//E.G. - 123 --> arr[0] = 1, arr[1] = 2, arr[2] = 3, user does not enter numbers in reverse, so the last digit is 3 and the number 
//to be added is 123 (case 2)


    class AddBigIntegers
    {
        //case 1 
        static List<int> AddBigNumbers(int[] firstNumber, int[] secondNumber)
        {
            //a list for our result
            List<int> result = new List<int>();

            //get the length of the shorter and the longer array, save which one is longer 
            int shorterNumber = firstNumber.Length, longerNumber = secondNumber.Length, shorterArray = 1;
            if (shorterNumber > secondNumber.Length)
            {
                shorterNumber = secondNumber.Length;
                longerNumber = firstNumber.Length;
                shorterArray = 2;
            }

            //iterate with 1 index through both numbers, fill the list with added digits
            //case 2 --> (i = shorterNumber - 1, j = longerNumber - 1; i >= 0; i--, j--) 
            for (int i = 0; i < shorterNumber; i++)
            {
                result.Add(firstNumber[i] + secondNumber[i]);
            }

            //now add the elements from the shorter array that were left out (first digits of the longer number)
            //case 2 --> i = longerNumber - shorterNumber; i >= 0; i --
            for (int i = shorterNumber; i < longerNumber; i++)
            {
                if (shorterArray == 1)
                    result.Add(secondNumber[i]);
                else
                    result.Add(firstNumber[i]);
            }

            //our result is not complete yet, we have to:
            //find the numbers(more than one digit) and make them into digits and then recalculate the other digits
            for (int index1 = 0, index2 = 1; index1 < result.Count - 1; index1++, index2++)
            {
                if (result[index1] > 9)
                {
                    result[index2] += result[index1] / 10;
                    result[index1] = result[index1] % 10;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            int[] firstNumber = { 9, 2, 5, 9, 1, 3, 5, 2, 6, 5, 6, 6, 7, 1, 3, 5, 4, 4 };
            int[] secondNumber = { 3, 4, 1, 1, 1, 4, 9, 2, 3, 4, 5 ,7, 8, 1, 8 };
            List<int> result = new List<int>();

            result = AddBigNumbers(firstNumber, secondNumber);
            //the list is filled backwards, so we have to reverse it
            result.Reverse();

            foreach (int digit in result)
            {
                Console.Write(digit);
            }

            Console.WriteLine();
        }
    }

