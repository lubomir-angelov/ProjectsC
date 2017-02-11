//Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitExchangeP_Q
{
    static void Main()
    {
        uint n;
        Console.WriteLine("Please input number:");
        bool isInt = uint.TryParse(Console.ReadLine(), out n);
        Console.WriteLine("This is the number in binary representation :{0}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(new String('-', 40));
        int p, q, k;

        Console.WriteLine("Please input the number for the first line of bits you want to exchange (p):");
        bool isPInt = int.TryParse(Console.ReadLine(), out p);
        Console.WriteLine("Please input the number of the second line of bits you wat to exchange with (q):");
        bool isQInt = int.TryParse(Console.ReadLine(), out q);
        Console.WriteLine("Please input the total number of bits you would like to be exchanged (k):");
        bool isKInt = int.TryParse(Console.ReadLine(), out k);


        string nString = Convert.ToString(n, 2).PadLeft(32, '0'); // If we use PadRight to "reverse" the string the value is not correct
        char[] nArray = new char[32];
        // Console.WriteLine("The binary represatation of the number is:\n{0}", nString);


        if (isInt && isPInt && isQInt && isKInt && p < q)
        {
            int j = 31;
            for (int i = 0; i < 32; i++)   
            {
                nArray[i] = nString[j];     // nString is "reversed" (PadLeft is used) nString[31] = nArray[0]
                j--;
            }


            for (int i = p; i < p + k; i++)
            {
                char a = nArray[q];
                nArray[q] = nArray[i];
                nArray[i] = a;
                q++;
            }
            Console.WriteLine("The new number is:");
            for (int i = 31; i >= 0; i--)                           // start printing from the 31st Binary digit --> to 0 digit
            Console.Write("{0}", nArray[i]);
            Console.WriteLine();
        }
        else Console.WriteLine("Invalid input!");
    }
}

