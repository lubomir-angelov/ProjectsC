using System;
using System.Text;

namespace _06.SumNumbersFromString
{
    class SumNumbersFromString
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static long SumNumbers(string[] ourString)
        {
            long sum = 0;
            for (int i = 0; i < ourString.Length; i++)
            {
                //if we want to skip the entries (existing because of the ourString[input.Length] initialization we can add sth like
                //if(ourString[i] == 0 && i + 1 <= ourString.Length && ourString[i + 1] == 0) {break;}
                //note this way we can skip some numbers if the user entered sth like "25 0 0 0 30" etc.
                int tempNumber;
                tempNumber = Convert.ToInt32(ourString[i]);
                sum += tempNumber;
            }

            return sum;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] ourNumbers = new string[input.Length];
            int indexStrArr = 0;
            int indexBackwards = 0;

            for (int indexStr = 0; indexStr < input.Length; indexStr++)
            {
                if (input[indexStr] == ' ' || indexStr == input.Length - 1)
                {
                    if (indexStr < input.Length - 1)
                    {
                        indexBackwards = indexStr - 1;
                    }
                    else
                    {
                        indexBackwards = indexStr;
                    }
                    string number = null;
                    while (indexBackwards >= 0 && input[indexBackwards] != ' ')
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append(number);
                        sb.Append(input[indexBackwards]);
                        number = sb.ToString();

                        indexBackwards--;
                    }

                    if (number.Length > 1)
                    {
                        number = ReverseString(number);
                    }
                    ourNumbers[indexStrArr] = number;
                    indexStrArr++;
                }

            }

            Console.WriteLine("The sum is {0}", SumNumbers(ourNumbers));
        }
    }
}
