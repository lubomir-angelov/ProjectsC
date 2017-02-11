using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_04._3DManipulations
{
    struct Point3D
   {
       public double x { get; set; }
       public double y { get; set; }
       public double z { get; set; }

       public Point3D(double x, double y, double z) : this()
       {
           this.x = x;
           this.y = y;
           this.z = z;
       }

        
       public override string ToString()
       {
           return "Coordinates:\n" + "X = " + this.x + "\n" + "Y = " + this.y + "\n" + "Z = " + this.z + "\n";
       }
        
    }
}
