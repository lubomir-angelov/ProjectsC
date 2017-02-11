using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of 
//if statements.


namespace _02.ShowSign
{
    class ShowSign
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());

            if (number1 < 0 && number2 < 0)
            {
                if (number3 < 0)
                {
                    Console.WriteLine("The sign is -");
                }
                else
                {
                    Console.WriteLine("The sign is +");
                }
            }
            else
            {
                if (number1 < 0 && number3 < 0)
                {
                    Console.WriteLine("The sign is +");
                }
                else
                {
                    if (number3 < 0 && number2 < 0)
                    {
                        Console.WriteLine("The sign is +");
                    }
                    else
                    {
                        if (number3 < 0)
                        {
                            Console.WriteLine("The sign is -");
                        }
                        else
                        {
                            Console.WriteLine("The sign is +");
                        }
                     }
                
               
                }
            }
        }
    }
}
