using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DancingBits
{
    class DancingBits
    {
        static void Main(string[] args)
        {
            int k, n, countOnes = 0, countZeroes = 0, countReal = 0;
            string concNumbers = null;
            string sZeroes = "0", sOnes = "1";

            k = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)         // Input
            {
                int a;
                a = int.Parse(Console.ReadLine());

                concNumbers += Convert.ToString(a, 2);
            }

            for (int i = 1; i < k; i++)         //"dancing" bits
            {
                sZeroes += "0";
                sOnes += "1";
            }

            int check = k / 2;

                for (int i = check; i <= concNumbers.Length - check; i++)
                {
                    string compare = null;

                    if (k % 2 != 0)                      // k is odd
                    {

                        int left = i - check;
                        int right = i + 1;

                        do
                        {
                            compare += concNumbers[left];
                            left++;
                        } while (left <= i);
                        do
                        {
                            compare += concNumbers[right];
                            right++;
                        } while (right <= i + check);

                        if (right == concNumbers.Length)    // border case (end of array)
                        {
                            if (compare == sZeroes)
                            {
                                countZeroes++;
                                i = i + k;
                                continue;
                            }
                            if (compare == sOnes)
                            {
                                countOnes++;
                                i = i + k;
                                continue;
                            }
                            break;
                        }

                        if (i == check)                       // border case (beginning of array)
                        {
                            if (compare == sZeroes)
                            {
                                countZeroes++;
                                i = i + k;
                                continue;
                            }
                            if (compare == sOnes)
                            {
                                countOnes++;
                                i = i + k;
                                continue;
                            }
                        }
                        else
                        {
                            left = i - check;
                            if (right > concNumbers.Length) break;
                            if (concNumbers[left] != concNumbers[left - 1] && concNumbers[right] != concNumbers[right - 1])
                            {

                                if (compare == sZeroes)
                                {
                                    countZeroes++;
                                    i = i + k;
                                    continue;
                                }
                                if (compare == sOnes)
                                {
                                    countOnes++;
                                    i = i + k;
                                    continue;
                                }
                            }
                        }
                   
                    }
                    else                                               // k is even
                    {
                        int left = i - check;
                        int right = i;

                        do
                        {
                            compare += concNumbers[left];
                            left++;
                        } while (left < i);

                        do
                        {
                            compare += concNumbers[right];
                            right++;
                        } while (right < i + check);
                        if (right == concNumbers.Length)                       // border case
                        {
                            if (compare == sZeroes)
                            {
                                countZeroes++;
                                i = i + k;
                                continue;
                            }
                            if (compare == sOnes)
                            {
                                countOnes++;
                                i = i + k;
                                continue;
                            }
                            break;
                        }
                        if (i == check)                                           // border case
                        {
                            if (compare == sZeroes)
                            {
                                countZeroes++;
                                i = i + k;
                                continue;
                            }
                            if (compare == sOnes)
                            {
                                countOnes++;
                                i = i + k;
                                continue;
                            }
                        }
                        else
                        {
                            left = i - check;
                            if (right > concNumbers.Length) break;           
                            if (concNumbers[left] != concNumbers[left - 1] && concNumbers[right] != concNumbers[right - 1])
                            {

                                if (compare == sZeroes)
                                {
                                    countZeroes++;
                                    i = i + k - 1;
                                    continue;
                                }
                                if (compare == sOnes)
                                {
                                    countOnes++;
                                    i = i + k - 1;
                                    continue;
                                }
                            }
                        }
                      
                    }

                }
                       
            countReal = countOnes + countZeroes; 

            Console.WriteLine(countReal);
        }
    }
}

        