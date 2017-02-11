using System;
using System.Collections.Generic;

//Write a method that reverses the digits of given decimal number. Example: 256  652


    class ReverseDigits
    {
        static void ReverseDigitsM(int number)
        {
            //check if the given number is positive
            int isNumberPositive = 1;
            if(number < 0)
            {
                number *= -1;
                isNumberPositive = -1;
            }

            //here we create a list to hold the digits of the number in backwards order
            List<int> reversedNumber = new List<int>();

            //fill in the List
            do
            {
                reversedNumber.Add(number % 10);
                number /= 10;
            } while (number != 0);

            //if the number was negative print the reversed number with a '-' in front
            if (isNumberPositive == -1)
            {
                Console.Write("-");
                foreach (int digit in reversedNumber)
                    Console.Write("{0}", digit);
            }

            //if it was positive, simply print the reversed digits
            else
            {
                foreach (int digit in reversedNumber)
                    Console.Write("{0}", digit);
            }

            //reset the cursor to a new line
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //get working data
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            //call the method
            ReverseDigitsM(number);
        }
    }

