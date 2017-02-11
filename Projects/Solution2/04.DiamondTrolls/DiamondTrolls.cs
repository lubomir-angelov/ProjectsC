using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main(string[] args)
        {
            string asterisk;
            string dotsLeft, dotsRight;
            //string upperLines;

            byte n;
            n = byte.Parse(Console.ReadLine());

            int width = n *2 + 1, height = 6 + (((n - 3) / 2) * 3);

            asterisk = new string('*', n);
            dotsLeft = new string('.', (width - n) / 2);
            dotsRight = new string('.', (width - n) / 2);

            Console.WriteLine(dotsLeft + asterisk + dotsRight);

            int countDots = ((width - n) / 2) - 1;
            int middleRow = height - n;
           
          /*  int middleColl;
            if (width / 2 == 0)
            {
                middleColl = width / 2;
            }
            else
            {
                middleColl = width / 2 - 1;
            } */

            int countDotsLeft = countDots;
            int countDotsRight = countDots;

            for (int i = 2; i < middleRow; i++)
            {
                
                    
                    dotsLeft = new string('.', countDotsLeft);
                    dotsRight = new string('.', countDotsRight);
                    asterisk = "*";

                    Console.WriteLine(dotsLeft + asterisk + dotsRight + asterisk + dotsRight + asterisk + dotsLeft);

                    countDotsLeft --;
                    countDotsRight ++;               

            }

            Console.WriteLine(new string ('*', width));

            countDotsLeft ++;
            countDotsRight --;

            for (int i = middleRow + 1; i < height; i++)
            {
                                    
                dotsLeft = new string('.', countDotsLeft);
                dotsRight = new string('.', countDotsRight);
                asterisk = "*";

                Console.WriteLine(dotsLeft + asterisk + dotsRight + asterisk + dotsRight + asterisk + dotsLeft);

                countDotsLeft++;
                if (countDotsRight > 0)
                {
                    countDotsRight--;
                }
            }

            asterisk = "*";
            dotsLeft = new string('.', (width - 1) / 2);
            dotsRight = new string('.', (width - 1) / 2);

            Console.WriteLine(dotsLeft + asterisk + dotsRight);
        }
    }
}
