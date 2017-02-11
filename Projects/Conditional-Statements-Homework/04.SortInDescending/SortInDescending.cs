using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sort 3 real values in descending order using nested if statements.

namespace _04.SortInDescending
{
    class SortInDescending
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;

            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());

            if (number1 > number2 && number1 > number3 && number2 > number3)
            {
                Console.WriteLine("{0}, {1}, {2}", number1, number2, number3);
            }
            else
            {
                if (number1 < number2 && number1 > number3 && number2 > number3)
                {
                    Console.WriteLine("{0}, {1}, {2}", number2, number1, number3);
                }
                else
                {
                    if (number1 < number3 && number1 < number2 && number2 < number3)
                    {
                        Console.WriteLine("{0}, {1}, {2}", number3, number2, number1);
                    }
                    else
                    {
                        if (number2 > number1 && number2 > number3 && number1 < number3)
                        {
                            Console.WriteLine("{0}, {1}, {2}", number2, number3, number1);
                        }
                        else
                        {
                            if (number2 > number1 && number2 < number3 && number1 < number3)
                            {
                                Console.WriteLine("{0}, {1}, {2}", number3, number2, number1);
                            }
                            else
                            {
                                if (number1 > number2 && number1 > number3 && number2 < number3)
                                {
                                    Console.WriteLine("{0}, {1}, {2}", number1, number3, number2);
                                }
                                else
                                {
                                    Console.WriteLine("{0}, {1}, {2}", number3, number1, number2);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
