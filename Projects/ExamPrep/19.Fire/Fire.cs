using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Fire
{
    class Fire
    {
        static void handle(int x)
        {
            string dots, dashLeft, dashRight;
            int countDots = 0, countDash = x / 2;

            for (int i = 0; i < x / 2; i++)
            {
                dots = new string('.', countDots);
                dashLeft = new string('\\', countDash);
                dashRight = new string('/', countDash);

                Console.WriteLine(dots + dashLeft + dashRight + dots);
                countDots++;
                countDash--;
            }
        }
        static void torch(int x)
        {
            string line;
            line = new string('.', x);
            int diPositionLeft = x / 2 - 1, diPositionRight = x / 2;
            for (int i = 1; i <= x / 2 - 1; i++)
            {
                
                char[] workingString;
                workingString = line.ToCharArray();
                workingString[diPositionLeft] = '#';
                workingString[diPositionRight] = '#';
                Console.WriteLine(workingString);
                diPositionLeft--;
                diPositionRight++;
            }

            diPositionLeft = 0;
            diPositionRight = x - 1;
            char[] middle;
            middle = line.ToCharArray();
            middle[diPositionLeft] = '#';
            middle[diPositionRight] = '#';
            Console.WriteLine(middle);
            Console.WriteLine(middle);
            
            for (int i = 1; i <= (x / 2 - 1) / 2; i++)
            {             
                diPositionLeft++;
                diPositionRight--;
                
                char[] workingString;
                workingString = line.ToCharArray();
                workingString[diPositionLeft] = '#';
                workingString[diPositionRight] = '#';
                Console.WriteLine(workingString);
            }
        }
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());

            torch(n);
            string line = new string('-', n);
            Console.WriteLine(line);
            handle(n);

        }
    }
}
