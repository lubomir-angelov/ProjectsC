using System;

//Write a method GetMax() with two parameters that returns the bigger of two integers. 
//Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().


    class WriteGetMaxMethod
    {

        static int GetMax(int firstNumber, int secondNumber)
        {
            //initialize the first number as tha bigger one
            int number = firstNumber;

            //if the second number is bigger change our result values
            if (firstNumber < secondNumber)
            {
                number = secondNumber;
            }

            return number;
              
        }

        static void Main(string[] args)
        {
            //get working data
            Console.WriteLine("Please input numbers");

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            //solve the problem
            int result = 0;
            result = GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
            Console.WriteLine(result);

            //this also works --> Console.WriteLine(GetMax(GetMax(firstNumber, secondNumber), thirdNumber);
        }
    }

