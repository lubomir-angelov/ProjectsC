using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace EOSTest2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            DateTime firstDate = new DateTime(2015, 10, 10);
            DateTime secondDate = new DateTime(2016, 1, 1);
            DateTime thirdDate = new DateTime(2014, 3, 3);

            Debt firstPerson = new Debt(500, firstDate, "IvanIvanov", "UNCR");
            Debt secondPerson = new Debt(100, secondDate, "PetarPetrov", "KTB");
            Debt thirdPerson = new Debt(1000, thirdDate, "JohnSmith", "PCR");

            List<Debt> debtors = new List<Debt>();
            debtors.Add(firstPerson);
            debtors.Add(secondPerson);
            debtors.Add(thirdPerson);

        }
    }
}
