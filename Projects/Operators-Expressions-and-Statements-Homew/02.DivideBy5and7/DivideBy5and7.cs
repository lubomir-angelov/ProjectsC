﻿//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class DivideBy5and7
{
    static void Main(string[] args)
    {
        int number;

        Console.WriteLine("Please input a number:");
        number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number CAN be devided by 5 and 7 without remainders.");
        }
        else Console.WriteLine("The number CANNOT be devided by 5 and 7 without remainders.");
    }
}
