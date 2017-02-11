using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that compares two char arrays lexicographically (letter by letter).

namespace _03.CompareLexicographically
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the first array");
            int firstArrayLength = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the length of the second array");
            int secondArrayLength = int.Parse(Console.ReadLine());

            char[] firstArray = new char[firstArrayLength], secondArray = new char[secondArrayLength];

            for (int i = 0; i < firstArrayLength; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < secondArrayLength; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
            }

            bool identical = true;

            if (firstArrayLength == secondArrayLength)
            {
                for (int i = 0; i < firstArrayLength; i++)
                {
                    if (firstArray[i] != secondArray[i])
                        identical = false;
                }
            }
            else
            {
                identical = false;
            }

            Console.WriteLine("The arrays are identical : {0}", identical);
        }
    }
}
