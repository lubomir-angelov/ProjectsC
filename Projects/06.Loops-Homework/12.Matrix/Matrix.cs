using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following...

namespace _12.Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Please input n.");
            n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];
            int count = 0, k;

            if (n > 0 && n <= 20)
            {
                for (int i = 0; i < n; i++)
                {
                    count = i;
                    for (int j = 0; j < n; j++)
                    {
                        do
                        {
                            k = count + 1;
                            matrix[i, j] = k;
                            break;
                        } while (k < j + count); // not always a valid condition, creates an infinite loop => use break
                        count++;
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please input 0<n<=20!");
            }
        }
    }
}
