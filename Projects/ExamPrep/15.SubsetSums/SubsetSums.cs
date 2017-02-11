using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            long s, n;
            

            s = long.Parse(Console.ReadLine());
            n = long.Parse(Console.ReadLine());

            long[] array = new long[n];
            int countSum = 0;
            int combinations = (int) Math.Pow(2, n);

            for (int i = 0; i < n; i++)
            {
                array[i] = long.Parse(Console.ReadLine());
            }

            for (int i = 1; i < combinations; i++)
            {
                long tempSum = 0;
                
                for (int j = 0; j < n; j++)
                {
                   
                    int mask = 1 << j;
                    int iAndMask = mask & i;
                    int bit = iAndMask >> j;

                    if (bit == 1)
                    {
                        tempSum += array[j];
                    }                   
                }
                if (tempSum == s)
                {
                    countSum++;                    
                }
            }

            Console.WriteLine(countSum);
        }
    }
}
