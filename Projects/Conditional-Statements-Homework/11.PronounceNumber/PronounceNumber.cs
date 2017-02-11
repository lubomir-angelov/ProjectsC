using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that converts a number in the range [0...999] to a text corresponding to its English pronunciation. Examples:
	0  "Zero"
	273  "Two hundred seventy three"
	400  "Four hundred"
	501  "Five hundred and one"
	711  "Seven hundred and eleven" */


namespace _11.PronounceNumber
{
    class PronounceNumber
    {
        static void Main(string[] args)
        {
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            string[] teens = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "ninteen" };
            string[] tys = {"twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            string hundred = " hundred ";
            string and = " and ";

            int number;

            Console.WriteLine("Please input a number from 0 to 999.");
            number = int.Parse(Console.ReadLine());

            int hundreds = (number/100) % 10;
            int tens = (number/10) % 10;
            int ones = number % 10;

            if (number >= 0 && number <= 9)
            {
                Console.WriteLine(digits[number]);
            }
            if(number >9 && number < 20)
            {
                Console.WriteLine(teens[number-10]);
            }
            if (number > 19 && number < 100)
            {
                Console.WriteLine(tys[tens - 2] + " " + digits[ones]);
            }
            if (number > 99 && number < 1000)
            {
                if (number == 100)
                {
                    Console.WriteLine(digits[hundreds] + hundred);
                }
                else
                {
                    if (tens > 1)
                    {
                        Console.WriteLine(digits[hundreds] + hundred + and + tys[tens - 2] + " " + digits[ones]);
                    }
                    else
                    {
                        Console.WriteLine(digits[hundreds] + hundred + and + teens[ones]);
                    }
                }
            }

            if (number < 0 || number > 999) Console.WriteLine("Invalid input!");

        }
    }
}
