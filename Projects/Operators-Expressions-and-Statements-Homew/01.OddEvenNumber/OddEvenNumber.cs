//Write an expression that checks if given integer is odd or even.

using System;

class OddEvenNumber
{
    static void Main()
    {
        int number;
        Console.WriteLine("Please insert a number:");
        number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
        else Console.WriteLine("The number is odd");
    }
}
