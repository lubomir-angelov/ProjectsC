using System;

    class BankAccount
    {
        static void Main()
        {
            string holderName = "Ivan Ivanov Ivanov";
            decimal balance = 2397.9018909090909090909090909090909090909M;
            string bankName = "SomeBank";
            string IBANcode = "GR16 0110 1250 0000 0001 2300 695";
            string BICcode = "BNPABGSX";
            long cardNumber1 = 1111111111111111111, cardNumber2, cardNumber3;

            Console.WriteLine("The current card balance is: {0}", balance);

//a six-digit Issuer Identification Number (IIN) (previously called the "Bank Identification Number" (BIN)) the first digit of which is the Major Industry Identifier (MII),
//a variable length (up to 12 digits) individual account identifier,
//a single check digit calculated using the Luhn algorithm.[2] 
// this adds up to 19 digits at most in a standart credit card number -> long is suitable
        }
    }

