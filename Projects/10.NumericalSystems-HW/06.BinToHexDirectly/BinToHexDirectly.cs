using System;
using System.Collections.Generic;

//Write a program to convert binary numbers to hexadecimal numbers (directly).
//Note:
//E.g. 1011111 has 7 digits in Bin, it should have 2 digits in Hex, the easisest for processing way to, would be 01011111
//so I will split the "filling"of our result string int wo parts --> first get the first digit, and then all the other digits

    class BinToHexDirectly
    {
        //a method to convert four binary digits into a hex digit
        static string ConvertToHexDigit(string fourDigits)
        {
            string hexNumber = null;
            switch (fourDigits)
            {
                case "0000": hexNumber += '0'; break;
                case "0001": hexNumber += '1'; break;
                case "0010": hexNumber += '2'; break;
                case "0011": hexNumber += '3'; break;
                case "0100": hexNumber += '4'; break;
                case "0101": hexNumber += '5'; break;
                case "0110": hexNumber += '6'; break;
                case "0111": hexNumber += '7'; break;
                case "1000": hexNumber += '8'; break;
                case "1001": hexNumber += '9'; break;
                case "1010": hexNumber += 'A'; break;
                case "1011": hexNumber += 'B'; break;
                case "1100": hexNumber += 'C'; break;
                case "1101": hexNumber += 'D'; break;
                case "1110": hexNumber += 'E'; break;
                case "1111": hexNumber += 'F'; break;
                default: break;
            }

            return hexNumber;
        }
        static void Main()
        {
            Console.WriteLine("Please enter your binary number on a line");
            string input = Console.ReadLine();
            string fourDigits = null;
            string hexNumber = null;

            //assume the user does not input only "perfect" binarynumbers (with divesable by four length, without remainder)
            if (input.Length % 4 != 0)
            {
                //fill the "missing" zeroes
                for (int i = 0; i < 4 - input.Length % 4; i++)
                {
                    fourDigits += '0';
                }

                for (int i = 0; i < input.Length % 4; i++)
                {
                    fourDigits += input[i];
                }

                hexNumber += ConvertToHexDigit(fourDigits);
              
                //now iterate through the rest of the input and convert each binary four digits into a hex digit 
                for (int i = input.Length % 4; i < input.Length; i += 4)
                {
                    //nullify our fourdigits on each step 
                    fourDigits = null;

                    //make a loop to fill our fourdigits

                    for (int j = 0, index = i; j < 4; j++, index++)
                    {
                        fourDigits += input[index];
                    }

                    //add the according hex digit to our result
                    hexNumber += ConvertToHexDigit(fourDigits);
                }
            }

            else //the user loves us and is giving us a nice, easy to operate upon binary number 
            {
                //just iterate through the input on steps by four
                for (int i = 0; i < input.Length; i += 4)
                {
                    //nullify our fourdigits on each step 
                    fourDigits = null;

                    //make a loop to fill our fourdigits string
                    for (int j = 0, index = i; j < 4; j++, index++)
                    {
                        fourDigits += input[index];
                    }

                    //add the according hex digit to our result
                    hexNumber += ConvertToHexDigit(fourDigits);
                }
            }

            Console.WriteLine("The number in hexademical is {0}", hexNumber);
        }
    }



