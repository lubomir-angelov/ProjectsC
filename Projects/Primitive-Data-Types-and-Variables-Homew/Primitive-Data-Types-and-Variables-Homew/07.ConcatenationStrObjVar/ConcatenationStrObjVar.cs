using System;

    class ConcatenationStrObjVar
    {
        static void Main(string[] args)
        {
            string varHello = "Hello";
            string varWorld = "World";
            object concHelloWorld = varHello + ' ' + varWorld;
            string castedStringVariable = (string) concHelloWorld;
            Console.WriteLine("The concatenated object variable is : {0}\nThe casted string variable is : {1}", concHelloWorld, castedStringVariable); 
        }
    }

