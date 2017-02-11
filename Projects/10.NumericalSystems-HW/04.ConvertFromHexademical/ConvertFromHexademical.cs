using System;

//Write a program to convert hexadecimal numbers to their decimal representation.

    class ConvertFromHexademical
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note: Please use only capital letters for your entry.");
            string hexNumber = Console.ReadLine();

            long decNumber = 0;

            for(int i = 0, multiplier = hexNumber.Length - 1; i < hexNumber.Length; i ++, multiplier --)
            {
                    switch (hexNumber[i])
                    {
                        case 'A': decNumber += 10 * (long)Math.Pow(16, multiplier); break;
                        case 'B': decNumber += 11 * (long)Math.Pow(16, multiplier); break;
                        case 'C': decNumber += 12 * (long)Math.Pow(16, multiplier); break;
                        case 'D': decNumber += 13 * (long)Math.Pow(16, multiplier); break;
                        case 'E': decNumber += 14 * (long)Math.Pow(16, multiplier); break;
                        case 'F': decNumber += 15 * (long)Math.Pow(16, multiplier); break;

                        default: int digit = (int)Char.GetNumericValue(hexNumber[i]);
                                 decNumber += digit * (long)Math.Pow(16, multiplier); break;
                    }               
            }

            Console.WriteLine(decNumber);
        }
    }

