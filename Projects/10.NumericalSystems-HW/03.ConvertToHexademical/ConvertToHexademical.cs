using System;

//Write a program to convert decimal numbers to their hexadecimal representation.

    class ConvertToHexademical
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string hexNumber = null;
       
            while (input != 0)
            {
                    switch (input % 16)
                    {
                        case 10: hexNumber += 'A'; break;
                        case 11: hexNumber += 'B'; break;
                        case 12: hexNumber += 'C'; break;
                        case 13: hexNumber += 'D'; break;
                        case 14: hexNumber += 'E'; break;
                        case 15: hexNumber += 'F'; break;
                        default: hexNumber += input % 16; break;
                    }

                    input /= 16;
            }

            char[] result = new char[hexNumber.Length];

            //reverse our result
            for (int indexString = hexNumber.Length - 1, indexChar = 0; indexString >= 0; indexString--, indexChar++)
            {
                result[indexChar] = hexNumber[indexString];
            }

            Console.Write("The number in hexademical:");
            foreach(char digit in result)
            Console.Write(digit);
            Console.WriteLine();
        }
    }

