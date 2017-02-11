using System;

    class CompareFloatingPNumbers
    {
        static void Main()
        {
            float number1, number2;
            Console.WriteLine("Please input number1:");
            number1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Please input number2:");
            number2 = float.Parse(Console.ReadLine());

            Console.WriteLine(number1 == number2);
        }
    }

