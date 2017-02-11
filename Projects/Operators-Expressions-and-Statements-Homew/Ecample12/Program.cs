using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int maskIf = (mask & n) != 0 ? 1 : 0; //determine the bit in position p

        Console.WriteLine("Before: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        if (maskIf == 0)
        {
            n |= (1 << p);
        }
        else
        {
            n &= ~(1 << p);
        }
        Console.WriteLine("After: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

    }
}
