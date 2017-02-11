using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Bunnies
{
    class Bunnies
    {
        static int GetDigitFromString(string number, int indexOfDigit)
        {
            char chdigit = number[indexOfDigit];
            int digit = (int)char.GetNumericValue(chdigit);
            return digit;
        }
  
        static void Main(string[] args)
        {
            int cycles = 1;
            int sum = 0;
            BigInteger product = 1;

            //input
       
            string input = null;
            List<int> cages = new List<int>();

            while (input != "END")
            {
                input = Console.ReadLine();
                if (input != "END") 
                cages.Add(int.Parse(input));
            }

            if (input.Length > 1)
            {

                while (true)
                {
                    sum = 0;

                    for (int i = 0; i < cycles; i++)
                    {
                        sum += cages[i];
                    }

                    if (sum > cages.Count)
                    {
                        break;
                    }

                    int count = 0;
                    for (int i = 0; i < cycles; i++)
                    {
                        cages.RemoveAt(i);
                        count++;
                        i--;
                        if (count == cycles) break;
                    }

                    int sumToAppend = 0;
                    product = 1;

                    for (int i = 0; i < sum; i++)
                    {
                        sumToAppend += cages[i];
                        product *= cages[i];
                        cages[i] = int.MinValue;
                    }
                    for (int i = 0; i < sum; i++)
                    {
                        cages.Remove(int.MinValue);
                    }

                    string newCages = null;
                    newCages += sumToAppend;
                    newCages += product;
                    for (int i = 0; i < cages.Count; i++)
                    {
                        newCages += cages[i];
                    }

                    cages.Clear();

                    for (int i = 0; i < newCages.Length; i++)
                    {
                        int digit = GetDigitFromString(newCages, i);
                        if (digit != 1 && digit != 0)
                            cages.Add(digit);
                    }

                    cycles++;
                }

                for (int i = 0; i < cages.Count; i++)
                {
                    Console.Write("{0} ", cages[i]);
                }
            }
            else
            {
                Console.WriteLine(input);
            }
          
        }
    }
}
