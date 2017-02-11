using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1_HW
{
    class Call
    {
        private string date = DateTime.Today.ToString();
        private string time = DateTime.Now.ToString();
        private string dialedPhoneNumber = "none";
        private int duration = 0;

        public Call()
        { 
        }

        public Call(string date, string time, string dialedPhoneNumber, int duration)
        {
            this.date = date;
            this.time = time;
            this.dialedPhoneNumber = dialedPhoneNumber;
            this.duration = duration;
        }
        public string Date
        {
            get { return this.date; }
            set { this.date = value; }
        }

        public string Time
        {
            get { return this.time; }
            set { this.time = value; }
        }

        public string DialedPhoneNumber
        {
            get { return this.dialedPhoneNumber; }
            set { this.dialedPhoneNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        public void PrintCall()
        {
            Console.WriteLine("Call details:");
            Console.WriteLine("Date: {0}", this.date);
            Console.WriteLine("Time: {0}", this.time);
            Console.WriteLine("Dialed number: {0}", this.dialedPhoneNumber);
            Console.WriteLine("Call duration: {0}", this.duration);
        }
    }
}
