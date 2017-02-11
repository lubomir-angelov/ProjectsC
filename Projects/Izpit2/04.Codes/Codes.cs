using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Codes
{
    class Codes
    {
        public static char[] baseChars = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static long FromAnyBaseToDec(int fromBase, string number)
        {
            long result = 0;
            string s = ReverseString(number);

            for (int i = 0; i < s.Length; i++)
            {
                switch (s[i])
                {
                    case 'A': result += 10 * (long)Math.Pow(fromBase, i); break;
                    case 'B': result += 11 * (long)Math.Pow(fromBase, i); break;
                    case 'C': result += 12 * (long)Math.Pow(fromBase, i); break;
                    case 'D': result += 13 * (long)Math.Pow(fromBase, i); break;
                    case 'E': result += 14 * (long)Math.Pow(fromBase, i); break;
                    case 'F': result += 15 * (long)Math.Pow(fromBase, i); break;
                    default: result += (long)(Char.GetNumericValue(s, i) * Math.Pow(fromBase, i)); break;
                }
            }

            return result;
        }

        public static string FromDecToAny(long value, char[] baseChars)
        {
            string result = string.Empty;
            int targetBase = baseChars.Length;

            do
            {
                result = baseChars[value % targetBase] + result;
                value = value / targetBase;
            }
            while (value > 0);

            if (result.Length < 8)
                result = result.PadLeft(8, '0');

            return result;
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.TrimEnd(' ');
            int l = int.Parse(Console.ReadLine());
            string[] table = new string[l];

            for (int i = 0; i < l; i++)
            {
                table[i] = Console.ReadLine();
            }

            string[] numbersStr = input.Split(' ');
          

            int[] numbersInt = new int[numbersStr.Length];

            for (int i = 0; i < numbersStr.Length; i++)
            {
                if(numbersStr[i] != "")
                numbersInt[i] = Convert.ToInt32(numbersStr[i]);
            }

            string binNumberToDecode = null;
            char[] chosenBase = new char[2];
            Array.Copy(baseChars, chosenBase, 2);

            //convert our numbers from int to bin
            for (int i = 0; i < numbersInt.Length; i++)
            {
                string binaryNumber = null;
                binaryNumber = FromDecToAny(numbersInt[i], chosenBase);
                binNumberToDecode += binaryNumber;
            }

            //trim the trailing zeroes in the concatenated string
            int trimFrom = binNumberToDecode.Length;
            int trimCount = 0;

            for (int i = binNumberToDecode.Length - 1; i >= 0; i--)
            {
                if (binNumberToDecode[i] != '0')
                {
                    break;
                }
                if (binNumberToDecode[i] == '0')
                {
                    trimCount++;
                    trimFrom = i;
                }
            }

            if(trimFrom != binNumberToDecode.Length)
            binNumberToDecode = binNumberToDecode.Remove(trimFrom, trimCount);
            //we have the string to decode

            string result = null;

            for (int indexInBinNumber = 0; indexInBinNumber < binNumberToDecode.Length; indexInBinNumber++)
            {
                int countOnes = 0;
                if (binNumberToDecode[indexInBinNumber] == '1')
                {
                    countOnes++;

                    int currentIndex = indexInBinNumber + 1;
                    while (currentIndex < binNumberToDecode.Length && binNumberToDecode[currentIndex] == '1')
                    {
                        currentIndex++;
                        countOnes++;
                    }

                    indexInBinNumber = currentIndex;

                    for (int i = 0; i < table.Length; i++)
                    {
                        string numberOfOnes = table[i].Substring(1, table[i].Length - 1);
                        int numberOfonesToInt = Convert.ToInt32(numberOfOnes);
                        if (countOnes == numberOfonesToInt)
                        {
                            string character = table[i];
                            result += character[0];
                            break;
                        }
                    }
                }
            }
     
            Console.WriteLine(result);
        }
    }
}
