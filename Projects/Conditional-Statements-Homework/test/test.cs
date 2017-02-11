using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class test
    {
        static void Main(string[] args)
        {
            int k, n, count = 0;
            string concNumbers = null;
            string sZeroes = "0", sOnes = "1";

            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)         // Input
            {
                int a;
                a = int.Parse(Console.ReadLine());

                concNumbers += Convert.ToString(a, 2);
            }

            for (int i = 1; i < k; i++)         //"dancing" bits
            {
                sZeroes += "0";
                sOnes += "1";
            }

            if(concNumbers.Contains(sZeroes)) 
                {
                    count++;
                }
            if(concNumbers.Contains(sOnes))
                {
                    count++;
                }

            Console.WriteLine(count);
        }
    }
}
