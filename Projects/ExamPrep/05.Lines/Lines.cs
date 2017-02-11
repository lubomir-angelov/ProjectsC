using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Lines
{
    class Lines
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8,8];

            for (int i = 0; i < 8; i++)
            {
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {
                    int bit = (n >> j) & 1;
                    matrix[i, j] = bit;
                }
            }

            int realCounter = 0, linesCounter = 0;
            for (int rows = 0; rows < 8; rows++)
            {
                for (int colls = 0; colls < 8; colls++)
                {
                    int counter = 0;
                    if (matrix[rows, colls] == 1)
                    {
                        counter++;
                        int currentColl = colls;
                        int currentRow = rows;

                       for (int j = colls; j < 8; j++)
                            {
                                currentColl++;
                                if (currentColl == 8)
                                {
                                    break;
                                }
                                if (matrix[currentRow, currentColl] == 1)
                                {
                                    counter++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            if(counter > 1) linesCounter++;
                            if (counter > realCounter)
                            {
                                realCounter = counter;
                                linesCounter--;
                            }
                            for (int i = rows; i < 8; i++)
                            {
                            
                                counter = 0;
                                currentColl = colls;
                                currentRow++;

                                if (currentRow == 8)
                                {
                                    break;
                                }
                                if (matrix[currentRow, currentColl] == 1)
                                {
                                    counter++;
                                }
                                if(counter > 1) linesCounter++;
                                if (counter > realCounter)
                                {
                                    realCounter = counter;
                                    linesCounter--;
                                }
                            }
                           
                        }
                    }
                }

             Console.WriteLine("{0}\n{1}", realCounter, linesCounter);

            }

           
            
        }
    }

