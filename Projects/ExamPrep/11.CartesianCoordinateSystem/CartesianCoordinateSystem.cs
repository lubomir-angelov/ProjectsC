using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _11.CartesianCoordinateSystem
{
    class CartesianCoordinateSystem
    {
        static void Main(string[] args)
        {
            double x, y;
            bool isXBigInt = double.TryParse(Console.ReadLine(), out x);
            bool isYBigInt = double.TryParse(Console.ReadLine(), out y);

            if (isXBigInt && isYBigInt)
            {

                if (x == 0 || y == 0)
                {
                    if (x == 0 && y != 0) Console.WriteLine(5);
                    if (x != 0 && y == 0) Console.WriteLine(6);
                    if (x == y) Console.WriteLine(0);
                }
                if (x > 0 && y > 0 && x != 0 && y != 0) Console.WriteLine(1);
                if (x < 0 && y > 0 && x != 0 && y != 0) Console.WriteLine(2);
                if (x < 0 && y < 0 && x != 0 && y != 0) Console.WriteLine(3);
                if (x > 0 && y < 0 && x != 0 && y != 0) Console.WriteLine(4);
            }
            
            
        }
    }
}
 
