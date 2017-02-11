using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that reads two arrays from the console and compares them element by element.

namespace _02.CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the range of the first array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the range of the second array");
            int m = int.Parse(Console.ReadLine());

            int[] array1 = new int[n], array2 = new int[m];
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0 ; i < m; i ++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            bool areArraysIdentical = true;
            if (n == m)
            {

                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] != array2[i])
                    {
                        areArraysIdentical = false;
                    }
                }
            }

            else
            {
                areArraysIdentical = false;
            }

            Console.WriteLine("The arrays are identccal : {0}", areArraysIdentical);
        

        }
    }
}
