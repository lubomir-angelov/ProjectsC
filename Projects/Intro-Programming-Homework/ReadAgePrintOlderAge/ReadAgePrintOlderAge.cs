using System;

    class ReadAgePrintOlderAge
    {
        static void Main()
        {
            int x; 
            Console.WriteLine("Please enter your age");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age will be "+(x+10));
        }
    }
