using System;

//Write a program to convert decimal numbers to their binary representation.

    class ConvertToBinary
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            
            string binaryNumber = Convert.ToString(Convert.ToInt32(n), 2);
            Console.WriteLine(binaryNumber);
        }
    }

