using System;
using System.Linq;
using System.Collections;
//* Write a program that shows the internal binary representation of given 32-bit signed floating-point number in IEEE 754 format 
//(the C# type float). Example: -27,25  sign = 1, exponent = 10000011, mantissa = 10110100000000000000000.
//IEE 754 info http://en.wikipedia.org/wiki/Floating_point#Internal_representation
//bitconverter.getbytes works with float values - http://msdn.microsoft.com/en-us/library/yhwsaf3w(v=vs.110).aspx
//bitarray creates a bitarray from a byte array - http://stackoverflow.com/questions/11204666/converting-c-sharp-byte-to-bitarray
//we can check our results with http://www.binaryconvert.com/result_float.html?decimal=051046050055

namespace IEEEformat
{
    class IEEEformat
    {
        static void Main()
        {
            
            //Console.WriteLine(sizeof(float));
            //Console.WriteLine(sizeof(uint));

            float a = 3.27f;
            BitArray myBA = new BitArray(BitConverter.GetBytes(a).ToArray());
            
            int[] digitArray = new int[myBA.Length];

            Console.WriteLine("This is the raw binary representation:");
            for (int i = 0; i < myBA.Length; i++)
            {
                if (myBA[i] == true)
                    digitArray[i] = 1;
                else digitArray[i] = 0;

                Console.Write(digitArray[i]);
            }
      
            //don't forget we have to reverse our array
            Array.Reverse(digitArray);

            Console.WriteLine("\n\nThe reversed binary number, so that it's indexes correspond to the formatting");
            foreach(int digit in digitArray)
                Console.Write(digit);

            //now create a user friendly output

            Console.WriteLine("\n\nThe number in binary separated accordingly, to the IEEE 754 format:");
            string signbit = "Sign Bit = ";
            string exponent = "Exponent = ";
            string mantissa = "Mantissa (a.k.a. significand) = ";

            for (int i = 0; i < digitArray.Length; i++)
            {
                if (i == 0)
                {
                    signbit += digitArray[i];
                }

                if (i > 0 && i < 8)
                {
                    exponent += digitArray[i];
                }

                if(i >= 8)
                {
                    mantissa += digitArray[i];
                }

            }

            Console.WriteLine(signbit);
            Console.WriteLine(exponent);
            Console.WriteLine(mantissa);
        }
    }
}
