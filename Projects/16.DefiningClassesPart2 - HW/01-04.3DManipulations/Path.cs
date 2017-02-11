using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04._3DManipulations
{
    class Path
    {
        private List<Point3D> pointsList = new List<Point3D>();

        public Path()
        {
        }

        public Path(List<Point3D> pointsList)
        {
           this.pointsList = pointsList;
        }

        public void AddPointToList(Point3D Point)
        {
            this.pointsList.Add(Point);
        }

        public void DeletePoint(Point3D Point)
        {
            int index = this.pointsList.IndexOf(Point);
            this.pointsList.RemoveAt(index);
        }

        public int ListCount()
        {
            return this.pointsList.Count;
        }

       
        public string[] PathListToStringArray()
        {
            string[] result = new string[pointsList.Count];
            for (int i = 0; i < pointsList.Count; i++)
            {
                Point3D currentPoint = new Point3D();
                currentPoint = pointsList[i];
                string temp = null;
                //keep in mind we have overriden the .ToString() method for objects of type Point3D
                string s = currentPoint.ToString();
                for(int j = 1; j < s.Length; j ++)
                {
                    
                    char currentChar = s[j];
                    
                    if (Char.GetNumericValue(currentChar) > -1 || currentChar == '.')
                    {
                        temp += currentChar;
                    }
                    //add a space between numbers
                    if (currentChar == '\n' && Char.GetNumericValue(s[j - 1]) != -1)
                    {
                        temp += " ";
                    }
                }

                if (temp != null)
                {
                    result[i] = temp;
                }
            }

            return result;
        }

    }
}
