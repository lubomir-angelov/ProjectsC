using System;

//Write a program to convert binary numbers to their decimal representation.

    class ConvertToBinary
    {
        static void Main(string[] args)
        {
            long decimalNumber = 0;
            string input = Console.ReadLine();

            //string decnumber = Convert.ToString(Convert.ToInt32(input, 2), 10);
            //Console.WriteLine(decnumber);  this also works;

            char[] tempArray = new char[input.Length];
           
            //assuming the input was in the format 00000 ... 101 = 5, we have to reverse the input 
            for (int indexString = input.Length - 1, indexChar = 0; indexString >= 0; indexString--, indexChar++)
            {
                tempArray[indexChar] = input[indexString];
            }
          
            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] == '1')
                {
                    decimalNumber += (long) Math.Pow(2, i);
                }
            }

            Console.WriteLine(decimalNumber);
        }
    }

