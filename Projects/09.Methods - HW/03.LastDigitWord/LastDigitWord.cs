using System;

//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

    class LastDigitWord
    {
        static string GetLastDigitAsWord(int number)
        {
            //create a dictionary
            string[] digits = {   "zero", "one", "two", "three",
                                  "four", "five", "six", "seven", 
                                  "eight", "nine"
                              };

            //get the last digit
            int lastDigit = number % 10;

            //if the user enterd a number that is lesser than 0, we need to "positi - fy" our result
            if (lastDigit < 0)
                lastDigit *= -1;

            //get the word for the last digit from our dictionary
            string result = digits[lastDigit];

            return result;
        }

        static void Main(string[] args)
        {
            //get working data
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());

            //solve the problem
            string result = GetLastDigitAsWord(number);
            Console.WriteLine(result);
        }
    }

