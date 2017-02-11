using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FighterAttack
{
    class FighterAttack
    {
        static void Main(string[] args)
        {
            int px1, py1, px2, py2, fx, fy, d, damage = 0;

       //     Console.WriteLine("Please input plant coordinates px1, py1, px2, py2.");
            px1 = int.Parse(Console.ReadLine());
            py1 = int.Parse(Console.ReadLine());
            px2 = int.Parse(Console.ReadLine());
            py2 = int.Parse(Console.ReadLine());
       //     Console.WriteLine("Please insert fighter coordinates fx, fy and d.");
            fx = int.Parse(Console.ReadLine());
            fy = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            int ex1, ex2;
            if (px1 > px2)                    // ensure that px1 holds the top left X coordinate and px2 the bottom right X
            {
                ex1 = px1;
                px1 = px2;
                px2 = ex1;
            }
            if (py1 < py2)                   // ensure that py1 holds the top left Y coordinate and py2 the bottom right Y
            {
                ex2 = py1;
                py1 = py2;
                py2 = ex2;
            }
            

            if (fx + d >= px1 && fx + d <= px2 && fy <= py1 && fy >= py2)                       // check if the missle hits the plant at all 
            {
                damage += 100;
            }

            if ((fy + 1 <= py1 && fy + 1 >= py2) && (fx + d >= px1 && fx + d <= px2)) // check if left cell is hit
            {
                damage += 50;
            }
            if ((fy - 1 <= py1 && fy - 1 >= py2) && (fx + d >= px1 && fx + d <= px2)) // check if right cell is hit  
            {
                damage += 50;
            }
            if ((fx + d + 1 >= px1 && fx + d + 1 <= px2) && (fy <= py1 && fy >= py2))    // check if front cell is hit
            {
                damage += 75;
            }            

            Console.WriteLine("{0}%", damage);
        }
    }
}
