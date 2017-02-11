using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//* Write a program that reads a positive integer number N (N < 20) from console and outputs in the console the numbers 1 ... N 
//numbers arranged as a spiral.

namespace _14.NSpiralMatrix
{
    class NSpiralMatrix
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Please input the number n.");
            n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            int member = 1, count;

            for (int i = 0; i < n; i++)
            {
                count = i;
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                    {
                        matrix[i, j] = member;
                        member++;
                    }
                    else
                    {
                        if(i == 1)
                        {
                            matrix[i, n-1] = member; 
                            member ++;
                            matrix[count + 1, n-1] = member;
                            member ++;
                        }
                        if(i == 2)
                        {


                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
