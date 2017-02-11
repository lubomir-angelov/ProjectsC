using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trapezoid
{
    class Trapezoid
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            string dotsLeft, dotsRight, asterisk = "*";

            int countDotsLeft = n-1, countDotsRight = n-1;

            string dots = new string ('.', n), asterisks = new string('*', n);
            Console.WriteLine(dots + asterisks);

            for (int i = 0; i < n-1; i++)
            {
                dotsLeft = new string('.', countDotsLeft);
                dotsRight = new string('.', countDotsRight);
                Console.WriteLine(dotsLeft + asterisk + dotsRight + asterisk);
                countDotsLeft--;
                countDotsRight++;
            }

            Console.WriteLine(asterisks + asterisks);
        }
    }
}
