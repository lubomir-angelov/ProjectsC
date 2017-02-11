using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the maximal sequence of equal elements in an array.
//Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.


namespace _05.FindMaxSequenceOfIdenticalNumbers
{
    class FindMaxSequenceOfIdenticalNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the length of the array");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int realCount = 0; // the length of the longest sequence
            
            for (int i = 0; i < numbers.Length - 1; i++)   //get the longest sequence;
            {
                if (numbers[i] == numbers[i + 1])
                {
                    int counter = 1; // the length of the current sequence 
                    int indexer = i; // we've already met one pair of identical numbers in the array; 
                    int number = numbers[i];  // get the number that is forming the sequence;
                                                                      
                    while (indexer < n - 1 && numbers[indexer] == numbers[indexer + 1]) //count how long the sequence is;
                    {
                        counter ++;
                        indexer++;
                    }
                    if(counter > realCount) realCount = counter;
                    i = indexer;
         
                }
            }

            for (int i = 0; i < numbers.Length - 1; i++)  // print the longest sequence;
            {
                if (numbers[i] == numbers[i + 1])
                {
                    int counter = 1, indexer = i, number = numbers[i];
                    while (indexer < n - 1 && numbers[indexer] == numbers[indexer + 1])
                    {
                        counter++;
                        indexer++;
                    }
                    if (counter == realCount)
                    {
                        for (int j = 0; j < realCount; j++)
                        {
                            Console.WriteLine(number);
                        }
                        break;
                    }

                    i = indexer;
                }
            }

        }
    }
}
