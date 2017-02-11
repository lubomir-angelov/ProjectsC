using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart1_HW
{
    class Display
    {
        private int size = 0;
        private int numberOfColours = 0;

        //paramtereless constructor
        public Display()
        {
        }

        //constructor with parameters
        public Display(int size, int numberOfColours)
        {
            if (size < 1)
            {
                Console.WriteLine("Display size must be a positive number <= 1");
                throw new ArgumentException("Ivalid display size!");
            }
            if (numberOfColours < 1)
            {
                Console.WriteLine("Number of colurs must be a positive number <= 1");
                throw new ArgumentException("Invalid number of colours!");
            }
            this.size = size;
            this.numberOfColours = numberOfColours;
        }

        public int Size
        {
            get { return this.size; }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Display size must be a positive number <= 1");
                    throw new ArgumentException("Ivalid display size!");
                }
                this.size = value;
            }
        }

        public int NumberOfColours
        {
            get { return this.numberOfColours; }
            set
            {
                if (numberOfColours < 1)
                {
                    Console.WriteLine("Number of colurs must be a positive number <= 1");
                    throw new ArgumentException("Invalid number of colours!");
                }
                this.numberOfColours = value;
            }
        }

        public void PrintDisplayPorperties()
        {
            Console.WriteLine("\nThese are the current device's display proeprties:\n");
            Console.WriteLine("Display size = {0}", this.size);
            Console.WriteLine("Display colors = {0}", this.NumberOfColours);
        }
    }
}
