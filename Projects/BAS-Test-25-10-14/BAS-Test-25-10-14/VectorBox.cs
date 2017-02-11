using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAS_Test_25_10_14
{
    class VectorBox
    {
        public class Vector
        {
            public float X { get; set; }
            public float Y { get; set; }

            public Vector() 
            {
            }

            public Vector(float x, float y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        public class Ray
        {
            public Vector Origin { get; set; }
            public Vector Direction { get; set; }

            public Ray() { }
            public Ray(Vector origin, Vector direction)
            {
                this.Origin = origin;
                this.Direction = direction;
            }
        }

        public class Box 
        {
            public Vector Min { get; set; }
            public Vector Max { get; set; }

            public Box() { }

            public Box(Vector min, Vector max)
            {
                this.Min = min;
                this.Max = max;
            }
        }

        //not really necessary
        static double getCoord(double max, double min)
        {
            return max - min;
        }
        static double calcLength(double X, double Y)
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
        static double calculateRotation(Ray myRay, Box myBox)
        {
            double rayX = getCoord(myRay.Direction.X, myRay.Origin.X);//better with no function
            double rayY = getCoord(myRay.Direction.Y, myRay.Origin.Y);
            double rayLength = calcLength(rayX, rayY);//or a in cos theorem
            double centerX = (myBox.Max.X - myBox.Min.X) / 2;
            double centerY = (myBox.Max.Y - myBox.Min.Y) / 2;
            double rotLength = Math.Sqrt(Math.Pow(centerX, 2) + Math.Pow(centerY, 2));//or c in cos theorem
            double thirdSideX = myRay.Direction.X - centerX;
            double thirdSideY = myRay.Direction.Y - centerY;
            double thirdSideLen = Math.Sqrt(Math.Pow(thirdSideX, 2) + Math.Pow(thirdSideY, 2));//or b in cos theorem
            double cosAng = (rotLength * rotLength + thirdSideLen * thirdSideLen - rayLength * rayLength) / (2 * thirdSideLen * rotLength);

            return Math.Cos(cosAng*Math.PI/180);//converting to radians
        }
        static void Main(string[] args)
        {
            //declaration
            Vector origin = new Vector(2, 1);
            Vector direction = new Vector(3, 0);
            Vector min = new Vector(-2, -2);
            Vector max = new Vector(1, -1);
            Ray myRay = new Ray(origin, direction);
            Box myBox = new Box(min, max);

            //test
            Console.WriteLine(calculateRotation(myRay, myBox));
        }
    }
}
