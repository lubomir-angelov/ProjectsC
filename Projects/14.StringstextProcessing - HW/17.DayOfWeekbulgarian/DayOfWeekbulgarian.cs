using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 
//6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


namespace _17.DayOfWeekbulgarian
{
    class DayOfWeekbulgarian
    {
        static void Main(string[] args)
        {
            DateTime date = DateTime.Parse(Console.ReadLine());

            date = date.AddMinutes(390);
            DateTimeFormatInfo bgFormat = new CultureInfo("bg-BG", false).DateTimeFormat;
            Console.WriteLine("Chosen date plus 6.30h: {0}\nDay of the week of that date in bulgarian: {1}", date, date.ToString("dddd", bgFormat));
        }
    }
}
