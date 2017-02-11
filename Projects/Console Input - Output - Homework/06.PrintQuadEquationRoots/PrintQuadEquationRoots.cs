//Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrintQuadEquationRoots
{
    class PrintQuadEquationRoots
    {
        static void Main(string[] args)
        {
            double a, b, c, x;

            Console.WriteLine("Please input numbers in order a, b, c.");

            bool isAInt = double.TryParse(Console.ReadLine(), out a);
            bool isBInt = double.TryParse(Console.ReadLine(), out b);
            bool isCInt = double.TryParse(Console.ReadLine(), out c);

            double d = b*b-4*a*c;

            if (isAInt && isBInt && isCInt)
            {
                if (d < 0)
                {
                    Console.WriteLine("The quadratic equation has no real roots");
                }
                else
                {
                    if (d == 0)
                    {
                        x = -(b / 2 * a);
                        Console.WriteLine("The quadratic equation has one real root x= {0}", x);
                    }
                    else
                    {
                        double x2;
                        x = (-b + Math.Sqrt(d)) / 2 * a;
                        x2 = (-b - Math.Sqrt(d)) / 2 * a;
                        Console.WriteLine("The quadratic equation has two real roots x1= {0},\nx2= {1}", x, x2);
                    }
                }
            }
            else Console.WriteLine("Invalid input!");
        }
    }
}
