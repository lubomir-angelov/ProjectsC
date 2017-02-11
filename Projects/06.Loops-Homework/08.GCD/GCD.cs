using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm 
//(find it in Internet).


namespace _08.GCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            int number1, number2;

            Console.WriteLine("Please input the first number.");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the second number.");
            number2 = int.Parse(Console.ReadLine());

            //int gcd;

            do
            {
                if (number1 > number2)
                {
                    number1 = number1 - number2;
                }
                else
                {
                    number2 = number2 - number1;
                }
            } while (number1 != number2);

            Console.WriteLine("The greatest common diviser of the two numbers is: {0}", number1);
        }
    }
}
