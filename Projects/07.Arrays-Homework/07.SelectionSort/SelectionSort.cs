using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, 
 * move it at the second position, etc.
 */ 


namespace _07.SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the lenght of the array");
            int length = int.Parse(Console.ReadLine());

            int[] numbers = new int[length];

            for (int i = 0; i < length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int smallestMemberIndex = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                //int currentMemberIndex = i;
                
                int currentMember = numbers[i];
                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentMember > numbers[j])
                    {
                        currentMember = numbers[j];
                        smallestMemberIndex = j;
                    }
                }
                if (currentMember != numbers[i])
                {
                    numbers[smallestMemberIndex] = numbers[i];
                    numbers[i] = currentMember;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));

        }
    }
}
