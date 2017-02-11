using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:
//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2004
//Distance: 4 days


namespace _16.CalculateNumberOfDays
{
    class CalculateNumberOfDays
    {
        static void Main(string[] args)
        {
            DateTime firstDate = DateTime.Parse(Console.ReadLine());
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            TimeSpan days = firstDate - secondDate;
            Console.WriteLine("Distance: {0} days", days.Days);
        }
    }
}
