using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Expression
{
    class Expression
    {
        static double result = 0;
        static bool HasZerosOnly(string str)
        {
            foreach (char c in str)
            {
                if (c != '0')
                    return false;
            }

            return true;
        }
        //a = new string(input);
        static double expression(string a)
        {          
            char sum = '+';
            char subtract = '-';
            char divide = '/';
            char multiply = '*';

            char[] input = a.ToCharArray();

            bool check = HasZerosOnly(a);

                if (!check)
                {

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
                                        result += digit1 / digit2;

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
                                        result += digit1 * digit2;

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
                                        result += digit1 + digit2;

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
                                        result += digit1 - digit2;

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

                    a = new string(input);

                  double result2 = 0;

                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] == divide)
                        {                            
                            if(input[j-1] == '0')
                            {
                                double digit0 = double.Parse(input[j + 1].ToString());
                                result /= digit0;
                            }
                            double digit1 = double.Parse(input[j - 1].ToString());
                            double digit2 = double.Parse(input[j + 1].ToString());
                            result2 += digit1 / digit2;

                            input[j - 1] = '0';
                            input[j] = '0';
                            input[j + 1] = '0';
                        }
                    }
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] == multiply)
                        {
                            if (input[j - 1] == '0')
                            {
                                double digit0 = double.Parse(input[j + 1].ToString());
                                result *= digit0;
                            }
                            int digit1 = int.Parse(input[j - 1].ToString());
                            int digit2 = int.Parse(input[j + 1].ToString());
                            result2 += digit1 * digit2;

                            input[j - 1] = '0';
                            input[j] = '0';
                            input[j + 1] = '0';
                        }
                    }

                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] == sum)
                        {
                            int digit1 = int.Parse(input[j - 1].ToString());
                            int digit2 = int.Parse(input[j + 1].ToString());
                            result2 += digit1 + digit2;

                            input[j - 1] = '0';
                            input[j] = '0';
                            input[j + 1] = '0';
                        }
                    }
                    for (int j = 0; j < input.Length; j++)
                    {
                        if (input[j] == subtract)
                        {
                            int digit1 = int.Parse(input[j - 1].ToString());
                            int digit2 = int.Parse(input[j + 1].ToString());
                            result2 += digit1 - digit2;

                            input[j - 1] = '0';
                            input[j] = '0';
                            input[j + 1] = '0';
                        }
                    }

                    result += result2;
                    a = new string(input);

                    return expression(a);
                }
                else
                {
                    return result;
                }
            }
        
        static void Main(string[] args)
        {
            string inputLine;
            inputLine = Console.ReadLine();

            double output;

            output = expression(inputLine);

            Console.WriteLine("{0:0.00}", output);
        }
    }
}
