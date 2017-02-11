using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1_HW
{
    class GSM
    {
        private string model = "A";
        private string manufacturer = "B";
        private int price = 0;
        private string owner = "Default";
        private List<Call> callHistory = new List<Call>();
        static private string iPhone = "iPhone4S";

        
        Battery battery = new Battery();
        Display display = new Display();
        //Call call = new Call();

        //parameterless constructor
        public GSM()
        {
        }

        //constrructor with parameters
        public GSM(string model, string manufacturer, int price, string owner, Battery battery, Display display)
        {
            if (model == null || model == "")
            {
                Console.WriteLine("The GSM Model value is manditory, it cannot be null or empty.");
                throw new ArgumentException("GSM Model value is null or emtpy.");
            }
            if (manufacturer == null || manufacturer == "")
            {
                Console.WriteLine("The manufacturer of the device cannot be null or empty.");
                throw new ArgumentException("Invalid manufacturer!");
            }
            if (price < 0)
            {
                Console.WriteLine("GSM price must be a postive number.");
                throw new ArgumentException("Invalid price!");
            }
            if (owner == null || owner == "")
            {
                Console.WriteLine("Owner cannot be null or empty");
                throw new ArgumentException("Invalid owner!");
            }
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
            //this.call = call;
        }

        //when called outside returns the static string value, cannot be changed
        public string IPhone
        {
            get { return GSM.iPhone; }
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid Model!");

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("Invalid Manufacturer name!");

                this.manufacturer = value;
            }
        }

        public int Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Price cannot be null or empty.");
                    throw new ArgumentException("Invalid price!");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Onwer cannot be null or empty.");
                    throw new ArgumentException("Invalid owner!");
                }
                this.owner = value;
            }
        }

        public List<Call> CallHistory
        {
            get { return this.callHistory; }
            set { this.callHistory = value; }
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }
        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }
        public void DeleteCall(Call call)
        {
            int indexToDelete = this.callHistory.IndexOf(call);

            if (indexToDelete > -1)
            {
                this.callHistory.RemoveAt(indexToDelete);
            }
        }
        public override string ToString()
        {
            string divider = "\n" + new string('-', 40) + "\n";
            return "\nThese are the properties of" + this.owner + "'s GSM\n" + divider
                    + "Device model = " + this.model + "\n"
                    + "Device manufacturer = " + this.manufacturer + "\n"
                    + "Device price = " + this.price + "\n"
                    + "Device owner = " + this.owner + divider;

            /*
            we can do this : 
            string batteryProperties = battery.PrintBatteryProperties();
            string displayProperties = display.PrintDisplayPorperties(); 
            if we cahnge the print methods to return a string type instead of being void methods
            and then add them in the return value of this method ^
            */

            //we can use a StringBuilder to first build the string we want to print --- save time from concatenation           
        }
        public void printBatteryAndDisplay()
        {
            this.battery.PrintBatteryProperties();
            this.display.PrintDisplayPorperties();
        }
        public double CalculatePrice(double price)
        {
            return this.callHistory.Count * 0.37;
        }
        public void PrintCallhistory()
        {
            int counter = 0;
            foreach (var call in this.callHistory)
            {
                counter++;
                Console.WriteLine("Call number {0}:", counter);
                call.PrintCall();
            }
        }
    }
}
