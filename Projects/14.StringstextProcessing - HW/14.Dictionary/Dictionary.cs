using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string[] dictionary = {
                                 "door - an object which serves as a boundary between different premises", 
                                 "car - a motorized means of transportation",
                                 "dog - an annoying barking annimal, often taken as a pet"
                                  };

            string word = Console.ReadLine();
            for (int i = 0; i < dictionary.Length; i++)
            {
                int firstSpaceIndex = dictionary[i].IndexOf(' ');
                string wordFromDict = dictionary[i].Substring(0, firstSpaceIndex);

                if (String.Compare(word, wordFromDict) == 0)
                {
                    Console.WriteLine(dictionary[i]);
                    counter++;
                }
            }

            if (counter == 0)
            { Console.WriteLine("The word is not present in the dictionary"); }
        }

    }
}
