using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime[] arr = { DateTime.Now, DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), DateTime.Now.AddDays(7) };

            Array.Sort(arr, (a, b) => a.DayOfWeek.CompareTo(b.DayOfWeek));

            PrintArray(arr);
        }

        private static void PrintArray(DateTime[] arr)
        {
            foreach (var day in arr)
            {
                Console.WriteLine(day + " ");
            }
        }
    }
}
