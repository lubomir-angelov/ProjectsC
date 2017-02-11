using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Doge
{
    class Doge
    {
        static int[,] matrix;
        static int boneX;
        static int boneY;
        static int count = 0;
        static int n;
        static int m;

        static int CountPaths(int x, int y)
        {
            //So assuming you start at (0,0) you remember this and then check if you can go right or down, 
            //if yes for both then you recursively call this same method for (0,1) and (1,0).
            if (x == boneX && y == boneY)
            {
                count++;
                return count;
            }
            if (x + 1 < n && y + 1 < m)
            {
                if (matrix[x + 1, y] != 1 || matrix[x, y + 1] != 1)
                {
                    return CountPaths(x + 1, y) + CountPaths(x, y + 1);
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            n = (int)char.GetNumericValue(line[0]);
            m = (int)char.GetNumericValue(line[2]);

            matrix = new int[n, m];

            line = Console.ReadLine();
            boneX = (int)char.GetNumericValue(line[0]);
            boneY = (int)char.GetNumericValue(line[2]);

            int dogEnemies = int.Parse(Console.ReadLine());

            int[] enemyCoordinates = new int[dogEnemies * 2];
            int indexEnemyCoordinates = 0;

            for (int i = 0; i < dogEnemies; i++)
            {		
                line = Console.ReadLine();
                enemyCoordinates[indexEnemyCoordinates] = (int)char.GetNumericValue(line[0]);
                indexEnemyCoordinates++;
                enemyCoordinates[indexEnemyCoordinates] = (int)char.GetNumericValue(line[2]);
                indexEnemyCoordinates++;
            }

            //fill enemy coordinates in the matrix with ones
            for (int i = 0; i < enemyCoordinates.Length; i += 2)
            {
                matrix[enemyCoordinates[i], enemyCoordinates[i+1]] = 1;
            }

            int counter = CountPaths(0, 0);

            Console.WriteLine();
        }
    }
}


//The easiest (for me) would be to do it recursively:

//1) the stop condition would be arriving at (i,i)

//2) you would try two next moves at each recursion level:

//can you go down
//can you go right
//Assuming that your current position is (x,y): You cannot go right if your current "y" plus 1 would be bigger than "i" in the (i,i). You cannot go down if your current "x" plus 1 would be bigger than "i" in the (i,i).

//You'd just have to remember the path in some variable or pass it downwards and print it when the stop condition occurs.

//So assuming you start at (0,0) you remember this and then check if you can go right or down, 
//if yes for both then you recursively call this same method for (0,1) and (1,0).