using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2fib
{
    class Program
    {
        static ulong fib(ulong n)
        {
            if (n < 2) return 1;
            else return fib(n - 1) + fib(n - 2);
        }

        static void Main(string[] args)
        {
            ulong n;
            n = ulong.Parse(Console.ReadLine());

            Console.WriteLine(fib(n));
        }
    }
}
