using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01_04._3DManipulations
{
    static class PathStorage
    {
        static private string firstFilePath = @"C:\Other\Programming\VisualStudioPrograms\Projects\15.DefiningClassesPartI - HW\16.DefiningClassesPart2 - HW\01-04.3DManipulations\TextFiles\firstFile.txt";
        static private string secondFilePath = @"C:\Other\Programming\VisualStudioPrograms\Projects\15.DefiningClassesPartI - HW\16.DefiningClassesPart2 - HW\01-04.3DManipulations\TextFiles\secondFile.txt";

        static public void ReadPathsFromFile(Path path)
        {
            //string fileContents = null;
            using (StreamReader reader = new StreamReader(firstFilePath))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    //double[] currentPoint = new double[3];
                    char[] separators = { ' ', ',', '/', '-' };
                    string[] resultSplit = line.Split(separators);
                    Point3D currentPoint = new Point3D(Convert.ToDouble(resultSplit[0]), Convert.ToDouble(resultSplit[1]), Convert.ToDouble(resultSplit[2]));
                    path.AddPointToList(currentPoint);
                    line = reader.ReadLine();
                }
            }
        }

        static public void WritePathsToFile(Path path)
        {
            using (StreamWriter writer = new StreamWriter(secondFilePath))
            {
                //keep in mind we have overriden the .ToString() method for objects of type Point3D
                string[] array = path.PathListToStringArray();
                string line = null;

                for (int i = 0; i < array.Length; i++)
                {
                    line = array[i];
                    writer.WriteLine(line);
                }
            }
        }

    }
}
