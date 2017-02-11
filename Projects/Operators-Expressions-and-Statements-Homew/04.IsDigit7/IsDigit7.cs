//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

using System;

    class IsDigit7
    {
        static void Main()
        {
            int number, checknumber;

            Console.WriteLine("Please input your number:");
            number = int.Parse(Console.ReadLine());

            checknumber = number;

            int count = 2;

            do
            {
                count--;
                checknumber /= 10;
            }
            while (count != 0);

            Console.WriteLine((checknumber % 10) == 7);

        }
    }

