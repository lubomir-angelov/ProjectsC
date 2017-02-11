//Write an expression that calculates rectangle’s area by given width and height.

using System;

    class RectangleArea
    {
        static void Main(string[] args)
        {
            int width, height;

            Console.WriteLine("Please input Width:");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Please input Height:");
            height = int.Parse(Console.ReadLine());

            int Area = width * height;
            Console.WriteLine("The Area of the rectangle is: {0}", Area);
        }
    }

