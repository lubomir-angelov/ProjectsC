using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//You are given an array of strings. Write a method that sorts the array by the length of its elements 
//(the number of characters composing them).


namespace _05.SortArrayOfStrings
{
    class SortArrayOfStrings
    {

        //sort using selection sort
        static void SortStringByLengthOfElements(string[] array)
        {
            int smallestMemberIndex = 0;
        
            for (int i = 0; i < array.Length; i++)
            {

                int currentMemberLength = array[i].Length;
                string currentMember = array[i];

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentMemberLength > array[j].Length)
                    {
                        currentMember = array[j];
                        currentMemberLength = array[j].Length;
                        smallestMemberIndex = j;                       
                    }
                }
                if (currentMember != array[i])
                {
                    array[smallestMemberIndex] = array[i];
                    array[i] = currentMember;
                }
            }

        }
        static void Main()
        {
            Console.WriteLine("Please input the length of the string");
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine();
            }

            SortStringByLengthOfElements(array);

            foreach (string str in array)
            {
                Console.Write("{0}, ", str);
            }
            Console.WriteLine();
        }
    }
}
