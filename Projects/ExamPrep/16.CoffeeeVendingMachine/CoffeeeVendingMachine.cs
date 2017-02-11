using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.CoffeeeVendingMachine
{
    class CoffeeeVendingMachine
    {
        static void Main(string[] args)
        {
            double coins;
            double a, p, coinsAvailable = 0;

            for (int i = 0; i < 5; i++)
            {
                coins = double.Parse(Console.ReadLine());
                switch (i)
                {
                    case 0: coinsAvailable += 0.05 * coins; break;
                    case 1: coinsAvailable += 0.10 * coins; break;
                    case 2: coinsAvailable += 0.20 * coins; break;
                    case 3: coinsAvailable += 0.50 * coins; break;
                    case 4: coinsAvailable += 1.00 * coins; break;
                    default: break;
                }
            }

            a = double.Parse(Console.ReadLine());
            p = double.Parse(Console.ReadLine());

            if (a < p)
            {
                Console.WriteLine("More {0:0.00}", p - a);
            }
            if (a == p)
            {
                Console.WriteLine("Yes {0:0.00}", coinsAvailable);
            }
            if(a > p)
            {
                if (coinsAvailable - (a - p) >= 0)
                {
                    Console.WriteLine("Yes {0:0.00}", coinsAvailable - (a - p));
                }
                if (coinsAvailable - (a - p) < 0)
                {
                    Console.WriteLine("No {0:0.00}", Math.Abs(coinsAvailable - (a - p)));
                }
            }

            
        }
    }
}
