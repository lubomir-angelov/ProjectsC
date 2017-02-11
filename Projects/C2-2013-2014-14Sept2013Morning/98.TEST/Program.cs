using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98.TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            static int elementLevel = -1;
        static int numberOfElements;
        static int[] permutationValue = new int[0];

        static char[] inputSet;
      

        static int permutationCount = 0;
        

        public static char[] MakeCharArray(string InputString)
        {
            char[] charString = InputString.ToCharArray();
            Array.Resize(ref permutationValue, charString.Length);
            numberOfElements = charString.Length;
            return charString;
        }

        public static StringBuilder CalcPermutation(int k)
        {
            StringBuilder result = new StringBuilder();

            elementLevel++;
            permutationValue.SetValue(elementLevel, k);

            if (elementLevel == numberOfElements)
            {
                result = OutputPermutation(permutationValue);
            }
            else
            {
                for (int i = 0; i < numberOfElements; i++)
                {
                    if (permutationValue[i] == 0)
                    {
                        CalcPermutation(i);
                    }
                }
            }
            elementLevel--;
            permutationValue.SetValue(0, k);
            return result;
        }

        public static StringBuilder OutputPermutation(int[] value)
        {
            StringBuilder sb = new StringBuilder();
            foreach (int i in value)
            {
                sb.Append(inputSet.GetValue(i - 1));
            }
            //Console.WriteLine();
            permutationCount++;
           
            return sb;
        }
        }
    }
}
