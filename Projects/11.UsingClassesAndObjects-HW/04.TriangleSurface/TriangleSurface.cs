using System;

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.


namespace _04.TriangleSurface
{
    class TriangleSurface
    {
        static double triAreaSideAlt(double altitude, double side)
        {
            double area = (altitude * side) / 2;
            return area;
        }

        static double triAreThreeSides(double a, double b, double c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        static double triAreaTwoSideAngle(double a, double b, double angle)
        {
            double c = Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angle));
            double area = triAreThreeSides(a, b, c);
            return area;
        }

        static void Main()
        {
            //please figure out your own valid data to test the other methods
            Console.WriteLine("Please a side a and a height ha");
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = triAreaSideAlt(a, h);        
            Console.WriteLine("The are calcuclated with a side and a height is {0}\n", area);
       
        }
    }
}
