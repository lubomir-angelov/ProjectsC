using System;

//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

    class CheckMemberNeighbours
    {
        //method to enter an array by given length
        static void InputArray(int n, int[] array)
        {
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        //check element neighbours
        static bool IsBigger(int position, int[] array)
        {
            if (position == 0 || position == array.Length - 1)
            {
                Console.WriteLine("The given element does not have two neighbours");
                return false;
            }
            if (position < 0 || position >= array.Length)
            {
                Console.WriteLine("The given position is outside of range of the array");
                return false;
            }
            if (array[position] > array[position - 1] && array[position] > array[position + 1])
            {
                return true;
            }

            return false;
        }

        
        static void Main(string[] args)
        {
            //get working data
            Console.WriteLine("Please enter the length of the array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the array");
            int[] arrayNumbers = new int[n];
            InputArray(n, arrayNumbers);
            Console.WriteLine("Please input the position of the element you would like to check");
            int position = int.Parse(Console.ReadLine());

            //solve the problem
            bool isBigger = IsBigger(position, arrayNumbers);
            Console.WriteLine(isBigger);

        }
    }

