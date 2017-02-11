/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace _05.Warhead
{
    class Warhead
    {
        /*static void input()
        { 
            
        static void Main(string[] args)
        {
            string input;
            string result = null;
            int[,] Matrix = new int [16,16];
            char hover;
            int countCapacitors = 0;


            for (int rows = 0; rows < 16; rows++)
            {
                input = Console.ReadLine();
                for (int colls = 0; colls < 16; colls++)
                {
                    int digit = int.Parse(input[colls].ToString());
                    Matrix[rows, colls] = digit;
                }
            }

            bool onBorder = false;
            bool in

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    
                }
            }

            while (result == null)
            {
                input = Console.ReadLine();
                    if (input == "hover")
                    {
                        int coordinateX = int.Parse(Console.ReadLine());
                        int coordinateY = int.Parse(Console.ReadLine());
                        if (Matrix[coordinateX, coordinateY] == 1)
                        {
                            hover = '*';
                            Console.WriteLine(hover);
                        }
                        else
                        {
                            hover = '-';
                            Console.WriteLine(hover);
                        }
                    }
                    if(input == "operate")
                    {
                        int coordinateX = int.Parse(Console.ReadLine());
                        int coordinateY = int.Parse(Console.ReadLine());

                        
                        if(Matrix[coordinateX,coordinateY] == 1)
                        {
                            Console.WriteLine("missed");
                            result = "BOOM";
                        }
                }
                
            }

        }
    }
}
        */