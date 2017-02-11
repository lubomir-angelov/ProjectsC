using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SandGlass
{
    class SandGlass
    {
        static void Main(string[] args)
        {
            int number;
            number = int.Parse(Console.ReadLine());

            string asterisk;
            string dots;
            int numberOfAsterisks = number, numberOfDots = 0;

            for (int i = 0; i < number; i++)
            {
                asterisk = new string('*', numberOfAsterisks);
                dots = new string('.', numberOfDots);

                if (i < number / 2)
                {
                    numberOfAsterisks -= 2;
                    numberOfDots ++;
                }
                else
                {
                    numberOfAsterisks += 2;
                    numberOfDots --;
                }
                
                Console.Write(dots + asterisk + dots);
                Console.WriteLine();
                
            }

         }
      }
}
