using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * The astrological digit of a given number N is a digit calculated by the number's digits by a special algorithm. 
 * The algorithm performs the following steps:
(1)	Sums the digits of the number N and stores the result back in N.
(2)	If the obtained result is bigger than 9, step (1) is repeated, otherwise the algorithm finishes.
The last obtained value of N is the result, calculated by the algorithm.
Input
The input data should be read from the console.
The only line in the input contains a number N, which can be integer or real number (decimal fraction).
The input data will always be valid and in the format described. There is no need to check it explicitly.
Output
The output data should be printed on the console.
You must print the calculated astrological digit of the number N on the first and only line of the output.
Constraints
•	The number N will be in range [-1.7 × 10−308… 1.7 × 10308]
•	N will have no more than 300 digits before and after the decimal point.
•	The decimal separator will always be the "." symbol.
•	Allowed working time for your program: 0.2 seconds.
•	Allowed memory: 16 MB.
*/

namespace _03.AstrologicalDigits
{
    class AstrologicalDigits
    {
        static void Main(string[] args)
        {
            int sum = 0, realSum = 0;
            string number;
           

            number = Console.ReadLine();

            for(int i = 0; i < number.Length; i++)
            {
               char character = number[i];
               if (character != '-' && character != '.')
               {
                   int digit = int.Parse(character.ToString());   
                   sum += digit;
               }
            }

           
            do
            {
                if (sum > 9)
                {
                    do
                    {
                        realSum += sum % 10;
                        sum /= 10;
                    }
                    while (sum != 0);
                }
                if (realSum > 9)
                {
                    sum = realSum;
                    realSum = 0;
                }
                else break;
            } while(sum !=0);


            if (realSum != 0)
            {
                Console.WriteLine(realSum);
            }
            else Console.WriteLine(sum);
        }
    }
}
