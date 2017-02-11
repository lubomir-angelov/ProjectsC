using System;

//Write a program that prints to the console which day of the week is today. Use System.DateTime.

namespace _03.DayOfTheWeek
{
    class DayOfTheWeek
    {
        static void Main()
        {
            DateTime date = DateTime.Now;
            string dayOfWeek = "ddddddd";
            Console.WriteLine(date.ToString(dayOfWeek));
        }
    }
}
