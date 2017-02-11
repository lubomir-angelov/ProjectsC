using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1_HW
{
    class DefiningClassesPart1_HW
    {
        static void Main(string[] args)
        {
            //GSMTest test = new GSMTest();
            //test.PrintProperties();

            GSMTestCallHistory testCall = new GSMTestCallHistory();
            testCall.DoStuff();
        }
    }
}
