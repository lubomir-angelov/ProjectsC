using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem369
{
    class Problem369
    {
        static void Main(string[] args)
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            long r = 0;

            switch (b)
            {
                case 3: r = (long) a + c; break;
                case 6: r = (long) a * c; break;
                case 9: r = (long) a % c; break;
                default: break;
            }
            if (r % 3 == 0)
            {
                long result = r / 3;
                Console.WriteLine(result);
                Console.WriteLine(r);
            }
            else
            {
                long result = r % 3;
                Console.WriteLine(result);
                Console.WriteLine(r);
            }
        }
    }
}
