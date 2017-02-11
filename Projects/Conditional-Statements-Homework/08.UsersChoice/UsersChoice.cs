using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that, depending on the user's choice inputs int, double or string variable. If the variable is integer or double,
//increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output.
//Use switch statement.

namespace _08.UsersChoice
{
    class UsersChoice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input 'i', 'd' or 's' for int, double or string.");

            char a = char.Parse(Console.ReadLine());
            int n;
            double d;
            string s;

            switch (a)
            {
                case 'i': n = int.Parse(Console.ReadLine()); Console.WriteLine("You have chosen int, {0}", n + 1); break;
                case 'd': d = double.Parse(Console.ReadLine()); Console.WriteLine("You have chosen double, {0}", d + 1); break;
                case 's': s = Console.ReadLine(); Console.WriteLine("You have chosen string, " + s + "*"); break;
            }
        }
    }
}
