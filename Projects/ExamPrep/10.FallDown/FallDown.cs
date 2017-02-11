using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//http://beta.bgcoder.com/Contests/Practice/Index/3

namespace _10.FallDown
{
    class FallDown
    {
        static void Main(string[] args)
        {
            int n;
            int[,] matrix = new int[8,8];

            for (int i = 0; i < 8; i++)
			{
                n = int.Parse(Console.ReadLine());
                for (int j = 0; j < 8; j++)
                {
                    int bit = (n >> j) & 1;
                    matrix[i, j] = bit;
                }
            }
            for (int row = 7; row >= 0; row --)
            {
                for (int col = 7; col >= 0; col --)
                {
                    if (matrix[row, col] == 1)
                    {
                        int currentRow = row;
                        for (int i = currentRow; i < 8; i++)
                        {
                            currentRow++;
                            if (currentRow == 8)
                            {
                                break;
                            }
                            if (matrix[currentRow, col] == 1)
                            {
                                break;
                            }
                            else
                            {
                                matrix[currentRow - 1, col] = 0;
                                matrix[currentRow, col] = 1;
                            }
                        }
                    }
                }
            }

            int output = 0 ;
            for (int i = 0; i < 8; i++)
            {
                output = 0;
                for (int j = 0; j < 8; j++)
                {                  
                    output = output + (matrix[i,j]*(int)Math.Pow(2, j));                   
                }
                Console.WriteLine(output);
            }

        }
    }
}
