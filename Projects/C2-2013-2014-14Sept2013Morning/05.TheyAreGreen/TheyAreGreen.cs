using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheyAreGreen
{
    class TheyAreGreen
    {
        public static string input;
        public static int n;

        static StringBuilder result = new StringBuilder();
        static int elementLevel = -1;
        static int numberOfElements;
        static int[] permutationValue;

        static char[] inputSet;

        static int permutationCount = 0;

        public static void CalcPermutation(int k)
        {
            numberOfElements = input.Length;
            elementLevel++;
            permutationValue[k] = elementLevel;

            if (elementLevel == numberOfElements)
            {
                OutputPermutation(permutationValue);
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
            permutationValue[k] = 0;
        }

        public static void OutputPermutation(int[] value)
        {
            foreach (int i in value)
            {
                result.Append(inputSet[i - 1]);
            }
            //Console.WriteLine();

            permutationCount++;
           // return result;
        }
        
        static void Main(string[] args)
        {
            input = Console.ReadLine();
            n = input.Length;
            permutationValue = new int[input.Length];
            inputSet = input.ToCharArray();
            CalcPermutation(0);
            int count = 0;
            string working = result.ToString();

            for (int i = 0; i <= working.Length - n; i += n)
            {
                string currentString = working.Substring(i, n);
                bool isValid = true;

                for (int j = 0; j < currentString.Length - 1; j++)
                {
                    if (currentString[j] == currentString[j + 1])
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid) count++;
            }

            Console.WriteLine(count);
        }
    }
}




//private int n;
//public int N
//{
//    get { return n; }
//    set { n = value; }
//}

//public int getN()
//{ return N; }