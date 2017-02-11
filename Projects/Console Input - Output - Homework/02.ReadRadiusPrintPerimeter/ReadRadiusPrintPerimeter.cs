//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadRadiusPrintPerimeter
{
    class ReadRadiusPrintPerimeter
    {
        static void Main(string[] args)
        {
            int r;


            bool isRInt = int.TryParse(Console.ReadLine(), out r);

            if (isRInt)
            {
                Console.WriteLine("The Perimeter is {0:F3}", 2 * Math.PI * r);
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}
