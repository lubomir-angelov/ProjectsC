using System;
using System.Collections.Generic;

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
//-a = ~(a-1)
    class BinRep16bit
    {
        static void Main()
        {
            //We can use these lines to validate our result; the binary rep of -5 with the Convert.ToString method has 32 digits, thats why
            //I use a 32 digit bin repr. if we have a negative number; see line 70;
            //int a = -5;
            //Console.WriteLine(Convert.ToString(a, 2).PadLeft(16, '0'));
            //Console.WriteLine(Convert.ToString(~(a - 1), 2).PadLeft(16, '0'));


            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();
            short sNumber = short.Parse(number);
            List<int> binNumber = new List<int>();

            if (sNumber >= 0)
            {
                do
                {
                    binNumber.Add(sNumber % 2);
                    sNumber /= 2;
                }
                while (sNumber > 0);

                binNumber.Reverse();
                //add the mising zeroes
                string zeroes = new string('0', 16 - binNumber.Count);
                Console.Write(zeroes);
                foreach (int digit in binNumber)
                    Console.Write(digit);
                Console.WriteLine();
            }
            else
            {
                sNumber = (short) (Math.Abs(sNumber)- 1);

                do
                {
                    binNumber.Add(sNumber % 2);
                    sNumber /= 2;
                }
                while (sNumber > 0);

                binNumber.Reverse();

                //manually use ~ operator (or something like that, it works :D)
                for (int i = 0; i < binNumber.Count; i++)
                {
                    if (binNumber[i] == 1)
                    {
                        binNumber[i] = 0;
                    }
                    else
                    {
                        binNumber[i] = 1;
                    }
                }
                //add the "mising" ones
                string ones = new string('1', 32 - binNumber.Count); // if we want only 16 digits we can change it to 16 - binNumber.Count
                Console.Write(ones);
                foreach (int digit in binNumber)
                    Console.Write(digit);
                Console.WriteLine();
            }
       
        }
    }

