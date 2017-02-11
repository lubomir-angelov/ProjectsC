using System;

    class ExchangeIntValues
    {
        static void Main()
        {
            int value1 = 5;
            int value2 = 10;
            int exchangeValues = 0;
            exchangeValues = value1;
            value1 = value2;
            value2 = exchangeValues;
            Console.WriteLine("Value1= {0}\nValue2= {1}", value1, value2);
        }
    }

