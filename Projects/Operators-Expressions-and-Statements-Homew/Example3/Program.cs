using System;

class ExchangesBitsOfGivenUnsignedInteger
{
    static void Main()
    {
        Console.WriteLine("Please enter a unsigned iginteger number!");
        uint number = uint.Parse(Console.ReadLine());
        //тук извличаме стойността на съответния бит и го записваме в променлива
        uint bit3 = (number & (1 << 3)) >> 3;
        uint bit4 = (number & (1 << 4)) >> 4;
        uint bit5 = (number & (1 << 5)) >> 5;
        uint bit24 = (number & (1 << 24)) >> 24;
        uint bit25 = (number & (1 << 25)) >> 25;
        uint bit26 = (number & (1 << 26)) >> 26;
        //тук нулираме съответните битове
        uint modifyNumber = Convert.ToUInt32(number & (~(1 << 3)) & (~(1 << 4)) & (~(1 << 5)) & (~(1 << 24)) & (~(1 << 25)) & (~(1 << 26)));
        Console.WriteLine(Convert.ToString(modifyNumber, 2).PadLeft(32, '0'));
        uint result = modifyNumber | (bit3 << 24) | (bit4 << 25) | (bit5 << 26) | (bit24 << 3) | (bit25 << 4) | (bit26 << 5);
      //  Console.WriteLine("The binary representation of your number ({0}) is : {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}