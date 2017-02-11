using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Define abstract class Shape with only one abstract 
method CalculateSurface() and fields width 
and height. Define two new classes Triangle and 
Rectangle that implement the virtual method 
and return the surface of the figure (height*width for 
rectangle and height*width/2 for triangle). Define 
class Circle and suitable constructor so that at 
initialization height must be kept equal to width 
and implement the CalculateSurface() method. 
Write a program that tests the behavior of the 
CalculateSurface() method for different shapes
(Circle, Rectangle, Triangle) stored in an array.
*/
namespace _01.Shapes
{
    abstract class Shape
    {
        private double width, height;

        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public abstract double CalculateSurface();
    }

    class Triangle : Shape
    {
        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateSurface()
        {
            return Width * Height / 2;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double CalculateSurface()
        {
            return Width * Height;
        }
    }

    class Circle : Shape
    {
        public Circle(double diameter)
        {
            Width = Height = diameter;
        }

        public override double CalculateSurface()
        {
            return 2 * Math.PI * Height / 2 * Width / 2; 
        }
    }
    class Shapes
    {
        static void Main(string[] args)
        {
            Shape myTriangle = new Triangle(10, 4);
            Shape myRectangle = new Rectangle(3, 5);
            Shape myCircle = new Circle(4);

            Shape[] shapes = new Shape[3] {myTriangle, myRectangle, myCircle};

            foreach (var shape in shapes)
            {
                double result = shape.CalculateSurface();
                Console.WriteLine(result);
            }
        }
    }
}
