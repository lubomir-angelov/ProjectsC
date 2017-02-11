//Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

using System;

    class IsPointInCircle
    {
        static void Main()
        {            
            double x0, y0;
            int R;
            double X, Y;

            Console.WriteLine("Please input coordinates for the center of the circle:");
            Console.WriteLine("x0="); 
            bool isDouble = double.TryParse(Console.ReadLine(), out x0);
            Console.WriteLine("y0=");            
            bool isDouble2 = double.TryParse(Console.ReadLine(), out y0);

            Console.WriteLine("Please input radius, R:");
            bool isInt = int.TryParse(Console.ReadLine(), out R);

            Console.WriteLine("Please input point coordinates, X:");
            bool isDouble3 = double.TryParse(Console.ReadLine(), out X);

            Console.WriteLine("Please input point coordinates, Y:");
            bool isDouble4 = double.TryParse(Console.ReadLine(), out Y);
            
            if (isDouble && isDouble2&&isInt)                            // checking for correct input Circle Coordinates and Radius
            {
                if (isDouble3 && isDouble4)                              // checking for correct input Point Coordinates
                {
                    if (X <= x0 + R && Y <= y0 + R)
                    Console.WriteLine("The point with coordinates [{0},{1}] is in the circle.", X, Y);

                    else Console.WriteLine("The point with coordinates [{0},{1}] is not in the circle.", X, Y);
                }
                else Console.WriteLine("Invalid input for point coordinates!");
            }
            else                                                         // If there is no input for the center of the circle coordinates
            {                
                if (isDouble3 && isDouble4&&isInt)
                {
                    Console.WriteLine("Coordinates for the center of the circle will be automaticaly chosen as [0,0]");
                    if (X <= x0 + R && Y <= y0 + R)
                    Console.WriteLine("The point with coordinates [{0},{1}] is in the circle.", X, Y);

                    else Console.WriteLine("The point with coordinates [{0},{1}] is not in the circle.", X, Y);
                }
                else Console.WriteLine("Invalid input for point coordinates and/or radius!");
            }
        }
    }

