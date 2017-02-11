using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.dada
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine;
            inputLine = Console.ReadLine();

            char sum = '+';
            char subtract = '-';
            char divide = '/';
            char multiply = '*';
            double result1 = 0, result2 = 0;
            char[] input = inputLine.ToCharArray();

            for (int i = 0; i < inputLine.Length; i++)
            {
                if (input[i] == sum)
                {
                    int digit1 = int.Parse(input[i - 1].ToString());
                    int digit2 = int.Parse(input[i + 1].ToString());
                    result2 += digit1 + digit2;

                    input[i - 1] = '0';
                    input[i] = '0';
                    input[i + 1] = '0';
                }
                for (int p = 0; p < input.Length; p++)
                {
                    if (input[p] == '=')
                    {
                        input[p] = '0';
                    }

                    if (input[p] == '(')
                    {
                        input[p] = '0';
                        int index = p;
                        do
                        {
                            for (int j = index; j < input.Length; j++)
                            {
                                if (input[j] == divide)
                                {
                                    double digit1 = double.Parse(input[j - 1].ToString());
                                    double digit2 = double.Parse(input[j + 1].ToString());
                                    result1 += digit1 / digit2;

                                    input[j - 1] = '0';
                                    input[j] = '0';
                                    input[j + 1] = '0';
                                }
                                if (input[j] == ')') break;
                            }
                            for (int j = index; j < input.Length; j++)
                            {
                                if (input[j] == multiply)
                                {
                                    int digit1 = int.Parse(input[j - 1].ToString());
                                    int digit2 = int.Parse(input[j + 1].ToString());
                                    result1 += digit1 * digit2;

                                    input[j - 1] = '0';
                                    input[j] = '0';
                                    input[j + 1] = '0';

                                }
                                if (input[j] == ')') break;
                            }
                            for (int j = index; j < input.Length; j++)
                            {
                                if (input[j] == sum)
                                {
                                    int digit1 = int.Parse(input[j - 1].ToString());
                                    int digit2 = int.Parse(input[j + 1].ToString());
                                    result1 += digit1 + digit2;

                                    input[j - 1] = '0';
                                    input[j] = '0';
                                    input[j + 1] = '0';
                                }
                                if (input[j] == ')') break;
                            }
                            for (int j = index; j < input.Length; j++)
                            {
                                if (input[j] == subtract)
                                {
                                    int digit1 = int.Parse(input[j - 1].ToString());
                                    int digit2 = int.Parse(input[j + 1].ToString());
                                    result1 += digit1 - digit2;

                                    input[j - 1] = '0';
                                    input[j] = '0';
                                    input[j + 1] = '0';
                                }
                                if (input[j] == ')') break;
                            }


                            index++;

                        } while (input[index] != ')');

                        input[index] = '0';
                    }
                }
            }
                result1 += result2;
                Console.WriteLine(result1);

        }
    }
}
