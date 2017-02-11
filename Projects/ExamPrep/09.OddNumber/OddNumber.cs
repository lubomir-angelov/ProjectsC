using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            long[] a = new long[n];
            int count1 = 0, count2 = 0;

            for (int i = 0; i < n; i++)
            {
                a[i] = long.Parse(Console.ReadLine());
            }

            if (n == 1) Console.WriteLine(a[0]);

            Array.Sort(a);
           
            for (int i = 1; i < n; i ++)
            {
                if (a[i] != a[i - 1])
                {
                    if (i == 1)
                    {
                        Console.WriteLine(a[0]);
                        break;
                    }
                    if (i == n - 1)
                    {
                        Console.WriteLine(a[i]);
                        break;
                    }
                    int index1 = i+1;
                    int index2 = i - 2;
                    do 
                    {
                        if (a[i] != a[index1])
                        {
                            Console.WriteLine(a[i]);
                            goto breakOut;
                        }
                        if(a[i] == a[index1]) count1++;
                        if (a[i - 1] == a[index2]) count2++;
                        index1++;
                        index2--;
                        if (index2 < 0)
                        {
                            if (a[i] == a[index1]) count1++;
                        }
                        if (index1 == n)
                        {
                            if (a[i - 1] == a[index2]) count2++;
                        }
                    } while (index1 < n && index2 > 0); 

                    if (count1 % 2 != 0)
                    {
                        Console.WriteLine(a[i]);
                        goto breakOut;
                    }
                    if (count2 % 2 != 0)
                    {
                        Console.WriteLine(a[i - 1]);
                        goto breakOut;
                        
                    }
                }
            }
        breakOut: ;

        }
    }
}
