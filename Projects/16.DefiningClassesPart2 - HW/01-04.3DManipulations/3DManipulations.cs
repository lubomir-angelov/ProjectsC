using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. Create a structure Point3D to hold a 3D - coordinate {X,Y,Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.

//2. Add a private static read-only field to hold the start 
//of the coordinate system – the point O{0, 0, 0}. 
//Add a static property to return the point O.

//03. Write a static class with a static method to calculate the distance between two points in the 3D space.

//4. Create a class Path to hold a sequence of points in the 3D space. Create a static class PathStorage with static methods 
//to save and load paths from a textfile. Use a file format of your choice.

namespace _01_04._3DManipulations
{
 
    class Program
    {
        private static readonly Point3D start = new Point3D(0, 0, 0);

        public static Point3D Start
        {
            get {return start;}
        }

        static void Main(string[] args)
        {
            Point3D Point = new Point3D(3.3, 2.5, 4);
            Console.WriteLine(Point); // works without .ToString() (static member)
            Console.WriteLine(Start); 

            Point3D secondPoint = new Point3D(-2.2, 1.3, -1);
            double distance = 0;

            //we call a member of a static class (E.g. a method) like so : ClassName.MethodNeeded(ifanyparameters)
            distance = CalculateDistanceBetween2Points.CalculateDistance(Point, secondPoint);
            Console.WriteLine("The distance between the two points:\n{0}\nand\n\n{1}\nis {2}", Point, secondPoint, distance);

            Path path = new Path();
            PathStorage.ReadPathsFromFile(path);
            PathStorage.WritePathsToFile(path);
        }
    }
}
