using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BinaryDigitsCount
{
    class BinaryDigitsCount
    {
        static void Main(string[] args)
        {
            int n, b;
            b = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            int[] binaryCount = new int[n];
            for (int i = 0; i < n; i++)
            {
                long input;
                input = long.Parse(Console.ReadLine());
                string binaryInput = Convert.ToString(input, 2);
                for (int j = 0; j < binaryInput.Length; j++)
                {
                    int binaryDigit = int.Parse(binaryInput[j].ToString());
                    if (binaryDigit == b)
                    {
                        binaryCount[i]++;
                    }
                }
            }
            for (int i = 0; i < binaryCount.Length; i++)
            {
                Console.WriteLine(binaryCount[i]);
            }
        }
    }
}
