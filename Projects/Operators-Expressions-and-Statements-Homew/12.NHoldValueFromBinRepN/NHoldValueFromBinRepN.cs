//We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold 
//the value v at the position p from the binary representation of n.
//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
//	n = 5 (00000101), p=2, v=0  1 (00000001)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class NHoldValueFromBinRepN
    {
        static void Main()
        {
            int n, v, p;

            Console.WriteLine("Please input number:");
            bool isNInt = int.TryParse(Console.ReadLine(), out n);            
            Console.WriteLine("Please input position:");
            bool isPInt = int.TryParse(Console.ReadLine(), out p);
            Console.WriteLine("Please input bit value:");
            v = int.Parse(Console.ReadLine());

            if (isNInt && isPInt && (v == 1 || v == 0))
            {
                Console.WriteLine("This is the number in Binary representation {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
                int mask = 1 << p;
                if ((mask & n) != 0)
                {
                    n &= ~(1 << p);
                    Console.WriteLine("This is the new number in Binary representation {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
                    Console.WriteLine("Now the integer value of n = {0}", n);
                }
                else
                {
                     n |= 1 << p;
                     Console.WriteLine("This is the new number in Binary representation {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
                     Console.WriteLine("Now the integer value of n = {0}", n);
                }
             }
              else Console.WriteLine("Ivalid input!");
        }
    }

