using System;

//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 
//Write a program to test this method.


    class WriteHelloMethod
    {
        static void AskPrintName()
        {
            Console.WriteLine("Please enter your name.");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello" + " " + userName);

        }
        static void Main(string[] args)
        {
            AskPrintName();
        }
    }

