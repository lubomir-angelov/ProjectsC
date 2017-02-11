using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            int n;
            long beersM = 0, beersV = 0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                long inputInt = long.Parse(input);
                long check = inputInt, numberLength = input.Length;
                
                    int count = 0;
                    while (count < numberLength)
                    {
                        check /= 10;
                        count++;
                        if (count >= numberLength / 2)
                        {
                            beersM += check % 10;
                        }
                    }
                    count = 0;
                    check = inputInt;
                    while (count < numberLength / 2)
                    {
                        if (count < numberLength / 2)
                        {
                            beersV += check % 10;
                        }
                        count++;
                        check /= 10;
                        if (numberLength % 2 != 0)
                        {
                            if (count == numberLength / 2)
                            {
                                beersV += check % 10;
                                break;
                            }
                        }
                    }
                    if (numberLength == 1)
                    {
                        beersV += inputInt;
                        beersM += inputInt;
                    }

                
            }

            if(beersM > beersV)
            {
                Console.WriteLine("M {0}", beersM - beersV);
            }
            if(beersM == beersV)
            {
                if (beersM == 1)
                {
                    Console.WriteLine("No {0}", beersM);
                }
                else
                {
                    Console.WriteLine("No {0}", beersM + beersV);
                }
            }
            if(beersM < beersV)
            {
                Console.WriteLine("V {0}", beersV - beersM);
            }
                
            
        }
    }
}
