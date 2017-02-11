//Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_With_0._001_Accuracy
{
    class Sum_With_0_001_Accuracy
    {
        static void Main()
        {
            int n = 2;
            double sum = 1;
            double sumCheck = 0;
          //  double sumMinus = 1;

            do
            {
                sumCheck = sum;
                if (n % 2 == 0)
                {
                    sum = sum + (1.0 / n);
                }
                else sum = sum - (1.0 / n);
                n++;
               // sumMinus = sum - sumCheck;
            } while (Math.Abs(sum - sumCheck) >= 0.001); 
            Console.WriteLine("The sum is {0:0.000}", sum); 


        }
    }
}
