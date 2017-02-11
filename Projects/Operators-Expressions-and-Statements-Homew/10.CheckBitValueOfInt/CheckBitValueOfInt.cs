//Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1.
//Example: v=5; p=1  false.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class CheckBitValueOfInt
    {
        static void Main()
        {
            int v;
            int p;

            Console.WriteLine("Please input v:");
            bool isVInt = int.TryParse(Console.ReadLine(), out v);
            Console.WriteLine("Please input the bit position, p:");
            bool isPInt = int.TryParse(Console.ReadLine(), out p);

            if (isVInt && isPInt)      //Correct input check
            {
                int mask = 1 << p;
                int vAndMask = v & mask;
                int bit = vAndMask >> p;

                Console.WriteLine("This is the number in Binary representation {0}", Convert.ToString(v, 2).PadLeft(32, '0'));
                Console.WriteLine("The answer is {0}", bit == 1);
            }
            else Console.WriteLine("Invalid input!");
        }
    }

