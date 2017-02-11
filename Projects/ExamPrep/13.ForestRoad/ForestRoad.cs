using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ForestRoad
{
    class ForestRoad
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            int dotCountLeft = 0, dotCountRight = n-1;
            string dotsLeft, dotsRight, asterisk = "*";

            for (int i = 0; i < n; i++)
            {
                
                dotsLeft = new string('.', dotCountLeft);
                dotsRight = new string('.', dotCountRight);
                Console.WriteLine(dotsLeft + asterisk + dotsRight);
                dotCountLeft++;
                dotCountRight--;
                if (dotCountRight == -1)
                {
                    dotCountRight++;
                    dotCountLeft --;
                    for (int j = i + 1; j < 2 * n - 1; j++)
                    {
                        dotCountLeft--;
                        dotCountRight++;
                        dotsLeft = new string('.', dotCountLeft);
                        dotsRight = new string('.', dotCountRight);
                        Console.WriteLine(dotsLeft + asterisk + dotsRight);
                    }
                    break;
                }
            }

        }
    }
}
