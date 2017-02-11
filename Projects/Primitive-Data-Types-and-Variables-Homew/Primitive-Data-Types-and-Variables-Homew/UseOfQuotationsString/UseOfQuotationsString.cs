using System;

    class UseOfQuotationsString
    {
        static void Main()
        {
            string stringVar1 = "The \"use\" of quotations causes difficulties.";
            string stringVar2 = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(stringVar1);
            Console.WriteLine(stringVar2);
        }
    }

