
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
//If an invalid number or non-number text is entered, the method should throw an exception. 
//Using this method write a program that enters 10 numbers:
//            a1, a2, … a10, such that 1 < a1 < … < a10 < 100

namespace _02.ReadNumbers
{
    class ReadNumber
    {
        static int counter = 1;

        static int ReadNumbers(int start, int end)
        {
            int number = 0;

            try
            {
                Console.Write("Enter a{2} number between {0} and {1}: ", start, end, counter);
                number = int.Parse(Console.ReadLine());
                counter++;

                if (counter == 10)
                {
                    return number;
                }

                if (start > number || end < number)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Your number is not valid!");
                return 0;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Your number is not in the limits!");
                return 0;
            }

            return ReadNumbers(number, end);
        }

        static void Main()
        {
            ReadNumbers(1, 100);
        }
    }
}
