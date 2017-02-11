//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

    class Bit3Check
    {
        static void Main()
        {
            int givenInteger, bitnumber;
            
            Console.WriteLine("Please input the number's bits you would like to check");
            givenInteger = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input the number of the bit you wold like to check");
            bitnumber = int.Parse(Console.ReadLine());

            int mask = 1 << bitnumber;
            int givenIntegerAndMask = givenInteger & mask;
            int bit = givenIntegerAndMask >> bitnumber;

            Console.WriteLine(Convert.ToString(givenInteger, 2).PadLeft(32, '0'));
            Console.WriteLine(bit == 1);
            
        }
    }

