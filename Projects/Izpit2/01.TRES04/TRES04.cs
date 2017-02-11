using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.TRES04
{
    class TRES04
    {
        static void Main(string[] args)
        {
            string[] dictionary = {"LON+", "VK-", "*ACAD", "^MIM",
                                   "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };

            BigInteger number = BigInteger.Parse(Console.ReadLine());
            string newNumber = null;

            while (number > 0)
            {
                newNumber += (number % 9);
                number /= 9;
            }

            StringBuilder sb = new StringBuilder();
            //string numberInNineS = newNumber.ToString();

            for (int i = newNumber.Length - 1; i >= 0; i--)
            {
                char digit = newNumber[i];
                int digitInt = (int) char.GetNumericValue(digit);
                sb.Append(dictionary[digitInt]);
            }

            string result = sb.ToString();

            Console.WriteLine(result);
        }
    }
}


//