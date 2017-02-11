using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1_HW
{
    class GSMTest
    {
        static Battery.BatteryType type1 = Battery.BatteryType.NiCd;
        static Battery.BatteryType type2 = Battery.BatteryType.LiIon;
        static Battery battery1 = new Battery("BCB", 0, 2, type1);
        static Display display1 = new Display(7, 20);
        static Battery battery2 = new Battery("LkO", 2, 4, type2);
        static Display display2 = new Display(5, 10);

        static private GSM gsm1 = new GSM("AS2", "Sony", 500, "Ivan", battery1, display1);
        static private GSM gsm2 = new GSM("AS3", "Sony", 550, "Petar", battery2, display2);

        GSM[] gsms = new GSM[] { gsm1, gsm2 };

        public void PrintProperties()
        {
            //int counter = 0;
            foreach (var device in gsms)
            {
                Console.WriteLine(device.ToString());
                device.printBatteryAndDisplay();
            }
        }
    }
}
