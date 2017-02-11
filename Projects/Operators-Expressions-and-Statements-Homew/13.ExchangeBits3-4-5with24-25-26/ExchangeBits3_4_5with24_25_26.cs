//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class ExchangeBits3_4_5with24_25_26
{
    static void Main()
    {
        uint n;
        bool isNuint = uint.TryParse(Console.ReadLine(), out n);

        if (isNuint)
        {
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'), n);

            uint bit3 = n >> 3;
            uint bit4 = n >> 4;
            uint bit5 = n >> 5;
            uint bit24 = n >> 24;
            uint bit25 = n >> 25;
            uint bit26 = n >> 26;

            uint mask = new uint();

            mask |= (bit5 << 26) | (bit4 << 25) | (bit3 << 24) | (bit26 << 5) | (bit25 << 4) | (bit24 << 3);
            uint mask0 = (uint)(n & (~(1 << 3)) & (~(1 << 4)) & (~(1 << 5)) & (~(1 << 24)) & (~(1 << 25)) & (~(1 << 26)));

            uint result = mask | mask0;

            //                Console.WriteLine(Convert.ToString(mask, 2).PadLeft(32, '0'), n);
            //                Console.WriteLine(Convert.ToString(mask0, 2).PadLeft(32, '0'), n);

            Console.WriteLine("The modified number is:");
            Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'), n);

        }
        else Console.WriteLine("Invalid input!");


    }
}
