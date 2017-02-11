using System;

    class PrintASCIITable
    {
        static void Main()
        {
            for (int i = 0; i < 128; i++)
            { 
                Console.WriteLine("The symbol of {0} is : {1}", i, (char)i);
            }
            
            
        }
    }

