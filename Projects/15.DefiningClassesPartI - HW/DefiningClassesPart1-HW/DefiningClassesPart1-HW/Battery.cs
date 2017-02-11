using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1_HW
{
    class Battery
    {
        public enum BatteryType
        {
            LiIon, NiMH, NiCd
        }

        private string model = "Default battery model";
        private int hoursIdle = 0, hoursTalk = 0;
        private BatteryType type;

        //parametereless constructor
        public Battery()
        {
        }

        //construcotr with parameters
        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType type)
        {
            if (model == null || model == "")
            {
                Console.WriteLine("The Battery Model value is manditory, it cannot be null or empty.");
                throw new ArgumentException("Ivalid Battery Model!");
            }
            if (hoursIdle < 0)
            {
                Console.WriteLine("Hours cannot be lesser than zero");
                throw new ArgumentException("Hours Idle cannot be less than zero");
            }
            if (hoursTalk < 0)
            {
                Console.WriteLine("Hours cannot be lesser than zero");
                throw new ArgumentException("Hours Talk cannot be less than zero");
            }
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        public string Model
        {
            get { return this.model; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Battery Model cannot be null or emtpy.");
                    throw new ArgumentException("Invalid Battery type!");
                }
                this.model = value;
            }
        }
        public int HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hours cannot be lesser than zero");
                    throw new ArgumentException("Hours Idle cannot be less than zero");
                }
                this.hoursIdle = value;
            }
        }

        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hours cannot be lesser than zero");
                    throw new ArgumentException("Hours talked cannot be less than zero");
                }
                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        //use the newly declared enumerator
        /*  public BatteryType type;//declare a new variable 

          public Battery(BatteryType type)
          {
              this.type = type;//allow the newly declared variable in this class to be accessed in other classes
          }

          public BatteryType Type
          {
              get { return type; } //when called outside of this class return the value of the "type" variable declared ^
          }
          //this should do it */

        public void PrintBatteryProperties()
        {
            Console.WriteLine("\nThese are the properties of the battery of the current device:\n");
            Console.WriteLine("Battery model = {0}", this.model);
            Console.WriteLine("Hours Idle = {0}", this.hoursIdle);
            Console.WriteLine("Hours Talking = {0}", this.hoursTalk);
            Console.WriteLine("Battery type = {0}", this.type);
        }

        //override the ToString()
        /* public override string ToString()
         {
             return string.Format("Battery Type: {0}.", this.type);
         } */
    }
}
