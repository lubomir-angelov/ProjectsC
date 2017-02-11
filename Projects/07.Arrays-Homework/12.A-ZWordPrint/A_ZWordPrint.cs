using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that creates an array containing all letters from the alphabet (A-Z). 
//Read a word from the console and print the index of each of its letters in the array.


namespace _12.A_ZWordPrint
{
    class A_ZWordPrint
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The letters are enumerated as follows 0 - A, 1 - a ... until 50 - Z, 51 - z\nPlease input a word:");
            string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";

            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < letters.Length; j++)
                {
                    if (word[i] == letters[j])
                    {
                        Console.Write("{0} - {1}, ", word[i], j);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
