using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://beta.bgcoder.com/Contests/Practice/Index/3

namespace _07.MajorityMultiple
{
    class MajorityMultiple
    {
        static int gcd(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }
            else
            {
                return gcd(y, x % y);
            }
        }
        static int lcm(int x, int y)
        {
            int lcm = (x*y)/gcd(x,y);
            return lcm;
        }

        static int smallestOfThree(int x, int y, int z)
        {
            if(x <= y && x <= z)
            {
                return x;
            }
            else
            {
                if(x >= y && x <= z)
                {
                    return y;
                }
                else
                {
                    return z;
                }
            }
        }       
            

        static void Main(string[] args)
        {
            int a, b, c, d, e;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());

            int[] arrayLcm = new int[11];
            
            
               arrayLcm[0] = lcm(a, lcm(b,c));
               arrayLcm[1] = lcm(a, lcm(b,d));
               arrayLcm[2] = lcm(a, lcm(b,e)); 
               arrayLcm[3] = lcm(a, lcm(c,e));
               arrayLcm[4] = lcm(a, lcm(c,d));
               arrayLcm[5] = lcm(a, lcm(d,e));
               arrayLcm[6] = lcm(b, lcm(c,d));
               arrayLcm[7] = lcm(b, lcm(c,e));
               arrayLcm[8] = lcm(b, lcm(d,e));
               arrayLcm[9] = lcm(c, lcm(d, e));
               arrayLcm[10] = lcm(d, lcm(e, a)); 

               Array.Sort(arrayLcm);
               Console.WriteLine(arrayLcm[0]); 

        }
    }
}
