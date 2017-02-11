using System;

//Write a program to convert hexadecimal numbers to binary numbers (directly).

    class HexToBinDirectly
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Note: Please use only capital letters for your entry.");
            string hexNumber = Console.ReadLine();
            string[] binaryNumber = new string[hexNumber.Length];

            for (int i = 0; i < hexNumber.Length; i++)
            {
                    string temp = null;
                    switch (hexNumber[i])
                    {
                        case 'A': temp = "1010"; binaryNumber[i] = temp; break;
                        case 'B': temp = "1011"; binaryNumber[i] = temp; break;
                        case 'C': temp = "1100"; binaryNumber[i] = temp; break;
                        case 'D': temp = "1101"; binaryNumber[i] = temp; break;
                        case 'E': temp = "1110"; binaryNumber[i] = temp; break;
                        case 'F': temp = "1111"; binaryNumber[i] = temp; break;
                        default: int digit = (int)Char.GetNumericValue(hexNumber[i]);
                                 temp = Convert.ToString(digit, 2).PadLeft(4, '0');
                                 binaryNumber[i] = temp; break;
                    }
            }

            Console.WriteLine("This is the number* in binary representation:\n");
            //*note the result does not have the leading zeores cut out
            foreach(string bindigit in binaryNumber)
                Console.Write(bindigit);
            Console.WriteLine();
        }
    }

