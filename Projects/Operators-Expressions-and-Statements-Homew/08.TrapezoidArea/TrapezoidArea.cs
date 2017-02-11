//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class TrapezoidArea
    {
        static void Main()
        {
            int a, b, h;

            Console.WriteLine("Please input a, b and h:");
            bool isInt1 = int.TryParse(Console.ReadLine(), out a);
            bool isInt2 = int.TryParse(Console.ReadLine(), out b);
            bool isInt3 = int.TryParse(Console.ReadLine(), out h);

            if (isInt1 && isInt2 && isInt3)
            {
                int A = ((a + b) * h) / 2;
                Console.WriteLine("The area of the trapezoid is: {0}", A);
            }
            else Console.WriteLine("Invalid input!");
        }
    }

