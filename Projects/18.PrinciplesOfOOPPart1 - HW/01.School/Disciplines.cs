using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Disciplines : Teachers
    {
        private string name = "Default";
        private byte numberOfTeachers = 0;
        private byte numberOfExcercises = 0;
        private string freeText = "Default";

        public string Name
        {
            get { return this.name; }
        }
        public byte NumberOfteachers
        {
            get { return this.numberOfTeachers; }
            //set { this.numberOfTeachers = value; }
        }
        public byte NumberOFExercises
        {
            get { return this.numberOfExcercises; }
            //set { this.numberOfExcercises = value; }
        }
        public string FreeText
        {
            get { return this.freeText; }
            set { this.freeText = value; }
        }

        public Disciplines()
        { 
        }
        public Disciplines (string name, byte numberOfteachers, byte numbeOfExercises )
        {
            this.name = name;
            this.numberOfTeachers = numberOfteachers;
            this.numberOfExcercises = numbeOfExercises;
        }
    }
}
