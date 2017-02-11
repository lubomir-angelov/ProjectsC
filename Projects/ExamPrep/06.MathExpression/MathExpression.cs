using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://bgcoder.com/Contest/Practice/7

namespace _06.MathExpression
{
    class MathExpression
    {
        static void Main(string[] args)
        {
            double n, m, p;

            n = double.Parse(Console.ReadLine());
            m = double.Parse(Console.ReadLine());
            p = double.Parse(Console.ReadLine());

            double sum, npow = n*n, divider = 1/ (m*p);
            int mod = (int) (m % 180);           
            double sin = Math.Sin(mod);
            double secondDivider = 128.523123123 * p;

            sum = ((npow + divider + 1337) / (n - secondDivider)) + sin;

            Console.WriteLine("{0:0.000000}", sum);

        }
    }
}
