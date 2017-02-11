using System;

//Write a program that generates and prints to the console 10 random values in the range [100, 200].

namespace _02.RandomValues
{
    class RandomValues
    {
        static void Main(string[] args)
        {
            Random randomValue = new Random();

            for (int i = 1; i <= 10; i++)
            {
                int randomNumber = randomValue.Next(100, 200);
                Console.WriteLine("Random Number {0} = {1} ", i, randomNumber);     
            }

        }
    }
}
