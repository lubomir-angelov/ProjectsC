using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://beta.bgcoder.com/Contests/Practice/Index/1

namespace _12.MissCat
{
    class MissCat
    {
        static void Main(string[] args)
        {
            int n;            
            n = int.Parse(Console.ReadLine());
            int[] cat = new int[11];
            int check = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                cat[input]++;
                if (cat[input] > check) check = cat[input];
            }
            for (int i = 0; i < 11; i++)
            {
                if (cat[i] == check)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
			    
                            
        }
    }
}
