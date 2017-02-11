using System;

namespace CommonLibrary
{
    public class Class1
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        public static long BinToDec(string binNumber)
        {
            long decimalNumber = 0;
            
            //string decnumber = Convert.ToString(Convert.ToInt32(input, 2), 10);
            //Console.WriteLine(decnumber);  this also works;

            char[] tempArray = new char[binNumber.Length];

            //assuming the input was in the format 00000 ... 101 = 5, we have to reverse the input 
            for (int indexString = binNumber.Length - 1, indexChar = 0; indexString >= 0; indexString--, indexChar++)
            {
                tempArray[indexChar] = binNumber[indexString];
            }

            for (int i = 0; i < tempArray.Length; i++)
            {
                if (tempArray[i] == '1')
                {
                    decimalNumber += (long)Math.Pow(2, i);
                }
            }

            return decimalNumber;
        }

        public static long TernToDec(string number)
        {
            long result = 0;
            ReverseString(number); 

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] != '0')
                {
                    result += (long) (Char.GetNumericValue(number, i) * Math.Pow(3, i));
                }
                    
            }

            return result;
        }

    }
}
