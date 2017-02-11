//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ValueOfBitNumber
{
    static void Main()
    {
        int v;
        int p;

        Console.WriteLine("Please input i:");
        bool isVInt = int.TryParse(Console.ReadLine(), out v);
        Console.WriteLine("Please input the bit position, b:");
        bool isPInt = int.TryParse(Console.ReadLine(), out p);

        if (isVInt && isPInt)
        {
            int mask = 1 << p;
            int vAndMask = v & mask;
            int bit = vAndMask >> p;

            Console.WriteLine("This is the number in Binary representation {0}", Convert.ToString(v, 2).PadLeft(32, '0'));
            Console.WriteLine("The answer is {0}", bit);
        }
        else Console.WriteLine("Invalid input!");
    }
}
