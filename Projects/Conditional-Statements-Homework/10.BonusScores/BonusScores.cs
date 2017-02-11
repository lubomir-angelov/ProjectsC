using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that applies bonus scores to given scores in the range [1..9]. The program reads a digit as an input. 
//If the digit is between 1 and 3, the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100; 
//if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value is not a digit, the program must report an error.
//		Use a switch statement and at the end print the calculated new value in the console.

namespace _10.BonusScores
{
    class BonusScores
    {
        static void Main(string[] args)
        {
            int digit;

            Console.WriteLine("Please input your digit.");
            digit = int.Parse(Console.ReadLine());

            switch (digit)
            {
                case 1: digit *= 10; Console.WriteLine("The new number is {0}", digit); break;
                case 2: digit *= 10; Console.WriteLine("The new number is {0}", digit); break;
                case 3: digit *= 10; Console.WriteLine("The new number is {0}", digit); break;
                case 4: digit *= 100; Console.WriteLine("The new number is {0}", digit); break;
                case 5: digit *= 100; Console.WriteLine("The new number is {0}", digit); break;
                case 6: digit *= 100; Console.WriteLine("The new number is {0}", digit); break;
                case 7: digit *= 1000; Console.WriteLine("The new number is {0}", digit); break;
                case 8: digit *= 1000; Console.WriteLine("The new number is {0}", digit); break;
                case 9: digit *= 1000; Console.WriteLine("The new number is {0}", digit); break;
                default: Console.WriteLine("Error, please input a valid digit (1-9)."); break;
            }          
        }
    }
}
