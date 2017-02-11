using System;

//Write a method that counts how many times given number appears in given array. 
//Write a test program to check if the method is working correctly.


    class CountAppearanceInArray
    {

        //method to enter an array by given length
        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        //get an array and a number and count that numbers' appearence
        static void CountInArray(int[] array, int number)
        {
            int counter = 0;
            foreach (int element in array)
            {
                if (element == number)
                    counter++;
            }

            Console.WriteLine("The number appeared {0} times", counter);
        }

        static void Main(string[] args)
        {
            //get working data
            Console.WriteLine("Please enter the length of the array");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Please enter the array elements");
            InputArray(length, array);

            Console.WriteLine("Please input the number you would like to check");
            int number = int.Parse(Console.ReadLine());

            //solve problem
            CountInArray(array, number);       
        }
    }

