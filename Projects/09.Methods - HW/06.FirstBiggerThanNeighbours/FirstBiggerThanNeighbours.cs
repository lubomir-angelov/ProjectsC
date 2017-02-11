using System;

//Write a method that returns the index of the first element in array that is bigger than its neighbors, 
//or -1, if there’s no such element. Use the method from the previous exercise.


    class FirstBiggerThanNeighbours
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
                //Console.WriteLine("The given element does not have two neighbours");
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

        static int GetFirstBigger(int[] array)
        {
            for(int i = 0; i < array.Length; i ++)
            {
                if(IsBigger(i, array))
                {
                    return i;
                }

            }

            return -1;
        }


        static void Main(string[] args)
        {
            //get working data
            Console.WriteLine("Please enter the length of the array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the array");
            int[] arrayNumbers = new int[n];
            InputArray(n, arrayNumbers);

            //solve problem
            int result = GetFirstBigger(arrayNumbers);
            if (result != -1)
            {
                Console.WriteLine("This is the first element that is bigger than it's neighbours {0}", result);
            }
            else
            {
                Console.WriteLine("There is no such element");
            }

        }
    }

