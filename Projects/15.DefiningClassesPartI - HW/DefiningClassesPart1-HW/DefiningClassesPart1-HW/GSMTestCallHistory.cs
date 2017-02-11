using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1_HW
{
    class GSMTestCallHistory
    {
        GSM gsm = new GSM();
        Call call1 = new Call("29/09/2013", "18:53:40", "0888555666", 360);
        Call call2 = new Call("2/5/2014", "19:17:20", "0886928312", 87);
        double price = 0.37;

        public void DoStuff()
        {
            gsm.AddCall(call1);
            gsm.AddCall(call2);

            gsm.PrintCallhistory();
            price = gsm.CalculatePrice(price);

            Console.WriteLine("The total price of the calls is: {0}", price);
            if (call1.Duration > call2.Duration)
            {
                gsm.DeleteCall(call1);
            }
            else gsm.DeleteCall(call2);

            Console.WriteLine("Print History again:");
            gsm.PrintCallhistory();

            price = gsm.CalculatePrice(price);

            Console.WriteLine("The price without the longest call is: {0}", price);
        }

    }
}
