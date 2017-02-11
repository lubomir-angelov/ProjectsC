using System;

//Write a method that return the maximal element in a portion of array of integers starting at given index. 
//Using it write another method that sorts an array in ascending / descending order.


    class AscendingDescending
    {
        static int MaximalElement(int[] array, int startingIndex)
        {
            //check for correct imput
            if (startingIndex >= array.Length || startingIndex < 0)
            {
                Console.WriteLine("You have entered an invalid index");
                return 0;
            }


            //assume the maximal element is the starting one
            int maxEelement = array[startingIndex];
            
            //iterate through the array 
            for (int i = startingIndex; i < array.Length; i++)
            {
                //check if the current element is bigger
                if (array[i] > maxEelement)
                {
                    maxEelement = array[i]; ;
                }
            }

            return maxEelement;
        }

        static void Main(string[] args)
        {
            int[] arrayNumbers = { 9, 0, -1, 22, 14, -18, 73, 65 };
            int index = 3;

            Console.WriteLine(MaximalElement(arrayNumbers, index));
        }
    }
