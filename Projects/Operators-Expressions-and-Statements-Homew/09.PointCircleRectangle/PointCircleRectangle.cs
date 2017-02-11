// Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the
// rectangle R(top=1, left=-1, width=6, height=2).

using System;

class IsPointInCircle
{
    static void Main()
    {
        double x0, y0;
        int R;
        int X, Y;
        int top, left, width, height;

        Console.WriteLine("Please input coordinates for the center of the circle:");
        Console.WriteLine("x0=");
        bool isDouble = double.TryParse(Console.ReadLine(), out x0);
        Console.WriteLine("y0=");
        bool isDouble2 = double.TryParse(Console.ReadLine(), out y0);

        Console.WriteLine("Please input radius, R:");
        bool isInt = int.TryParse(Console.ReadLine(), out R);

        Console.WriteLine("Please input point coordinates, X:");
        bool isIntX = int.TryParse(Console.ReadLine(), out X);
        Console.WriteLine("Please input point coordinates, Y:");
        bool isIntY = int.TryParse(Console.ReadLine(), out Y);

        Console.WriteLine("Please input rectangle values");
        Console.WriteLine("Please input top");
        bool isInt2 = int.TryParse(Console.ReadLine(), out top);
        Console.WriteLine("Please input left");
        bool isInt3 = int.TryParse(Console.ReadLine(), out left);
        Console.WriteLine("Please input width:");
        bool isInt4 = int.TryParse(Console.ReadLine(), out width);
        Console.WriteLine("Please input height:");
        bool isInt5 = int.TryParse(Console.ReadLine(), out height);


        if (isDouble && isDouble2 && isInt && isInt2 && isInt3 && isInt4 && isInt5)
        {       
            if (isIntX && isIntY)
            {
                if (X <= x0+R && Y <= y0 + R)
                    Console.WriteLine("The point with coordinates [{0},{1}] is in the circle.", X, Y);

                else Console.WriteLine("The point with coordinates [{0},{1}] is not in the circle.", X, Y);

                if ((X < top) || (X > top + width) || (Y > left) || (Y < left - height))
                    Console.WriteLine("The point with coordinates [{0},{1}] is out of the rectangle.", X, Y);

                else Console.WriteLine("The point with coordinates [{0},{1}] is in the rectangle.", X, Y);
                
            }
            else Console.WriteLine("Invalid input!");
        }
        else
        {
            if (isIntX && isIntY && isInt && isInt2 && isInt3 && isInt4 && isInt5)
            {
                Console.WriteLine("Coordinates for the center of the circle will be automaticaly chosen as [0,0]");

                if (X <= x0 + R && Y <= y0 + R)
                    Console.WriteLine("The point with coordinates [{0},{1}] is in the circle.", X, Y);

                else Console.WriteLine("The point with coordinates [{0},{1}] is not in the circle.", X, Y);

                if ((X < top) || (X > top + width) || (Y > left) || (Y < left - height))
                    Console.WriteLine("The point with coordinates [{0},{1}] is out of the rectangle.", X, Y);

                else Console.WriteLine("The point with coordinates [{0},{1}] is in the rectangle.", X, Y);
            }
            else Console.WriteLine("Invalid input!");
         }       
    }
}

