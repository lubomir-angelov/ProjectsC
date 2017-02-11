using System;

//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.


namespace _01.LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            bool isYearLeap = DateTime.IsLeapYear(year);
            Console.WriteLine("The year is {0}", isYearLeap ? "a leap year" : "not a leap year");
        }
    }
}
