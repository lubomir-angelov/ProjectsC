using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class InputOutput
    {
        const int max_count = 6;

        class Printing
        {
            public void print(bool toConv)
            {
                string print = toConv.ToString();
                Console.WriteLine(print);
            }
        }

        public static void input()
        {
            Printing call = new Printing();
            call.print(true);
        }

        public static void Main()
        {
            input();
        }
    }
}
