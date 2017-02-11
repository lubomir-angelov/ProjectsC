using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that finds the biggest of three integers using nested if statements.

namespace _03.BiggestOfThree
{
    class BiggestOfThree
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            Console.WriteLine("Please input 3 numbers that are not equal.");

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());

            if (number1 == number2 || number1 == number3 || number2 == number3)
            {
                Console.WriteLine("Incorrect input. Please input 3 numbers that are not equal.");
            }
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("The biggest is {0}", number1);
            }
            else
            {
                if (number1 < number2 && number2 > number3)
                {
                    Console.WriteLine("The biggest is {0}", number2);
                }
                else
                {
                    if (number1 < number3 && number3 > number2)
                    {
                        Console.WriteLine("The biggest is {0}", number3);
                    }
                }
            }
        }
    }
}
