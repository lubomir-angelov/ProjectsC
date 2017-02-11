using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TheHorror
{
    class TheHorror
    {
        static void Main(string[] args)
        {
            string input;
            int countEvenDigits = 0;
            long sum = 0;

            input = Console.ReadLine();
            char[] text = input.ToCharArray();

            for(int i = 0; i < input.Length; i++)
            {
                          
                if((i % 2 == 0 || i == 0) && (text[i] >= '0') && (text[i] <= '9'))
                {
                    int currentDigit = int.Parse(text[i].ToString());
                    sum += currentDigit;
                    countEvenDigits ++;
                }
            }

            Console.WriteLine("{0} {1}", countEvenDigits, sum);

        }
    }
}
