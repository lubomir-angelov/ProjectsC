using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

namespace IsSomeSubsetOf5NumbersZero
{
    class IsSomeSubsetOf5NumbersZero
    {

        static void Main(string[] args)
        {
            int n = 5;                                   

            int[] A = new int[n];
            int totalSum = 0;

            Console.WriteLine("Please input the sequence of numbers you would like to check, one number per row.");
            for (int i = 0; i < n; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
                totalSum += A[i];
            }
            for (int i = 0; i < n - 2; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (A[i] + A[j] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", A[i], A[j]); 
                    }
                    for (int k = j + 1; k < n; k++)
                    {
                        if (A[i] + A[j] + A[k] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", A[i], A[j], A[k]); 
                        }
                        for (int l = k + 1; l < n; l++)
                        {
                            if (A[i] + A[j] + A[k] + A[l] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", A[i], A[j], A[k], A[l]); 
                            }
                        }
                    }
                }
            }

                if (totalSum == 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("{0} +", A[i]);
                    }
                    Console.Write("= 0\n");
                }                
            }
        }
    }

