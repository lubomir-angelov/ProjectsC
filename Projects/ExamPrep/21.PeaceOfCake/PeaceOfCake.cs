using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.PeaceOfCake
{
    class PeaceOfCake
    {
        static void Main(string[] args)
        {
            int a, b, c, d;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int wholeCakes;
            decimal lessThanOneCake;

            int denominator = b * d;
            int upperPart = (d * a) + (b * c);

            wholeCakes = upperPart / denominator;
            lessThanOneCake = (decimal) upperPart / denominator;

            if(wholeCakes > 0)
            {
                Console.WriteLine("{0}\n{1}/{2}", wholeCakes, upperPart, denominator);
            }
            else
            {
                Console.WriteLine("{0:F22}", lessThanOneCake);
                Console.WriteLine("{0}/{1}", upperPart, denominator);
            }
            
        }
    }
}
