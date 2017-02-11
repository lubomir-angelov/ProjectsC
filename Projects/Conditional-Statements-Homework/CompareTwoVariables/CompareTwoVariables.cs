using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

namespace CompareTwoVariables
{
    class CompareTwoVariables
    {
        static void Main(string[] args)
        {
            int a, b, helpVariable = 0;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                helpVariable = a;
                a = b;
                b = helpVariable;

                Console.WriteLine("Now a= {0}, b= {1}", a, b);
            }
            else
            {
                Console.WriteLine("The first value is not greater than the second");
            }
               
        }
    }
}
