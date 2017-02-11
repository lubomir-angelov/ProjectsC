using System;

    class AssignNullValues
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            a = 124234;
            b = 8.999999999919191919191; // double's floating point precision is to 15-16 digits
            Console.WriteLine("{0}\n{1}", a, b);
        }
    }

