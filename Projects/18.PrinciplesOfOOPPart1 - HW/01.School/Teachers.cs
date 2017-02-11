using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.School
{
    class Teachers : People
    {
        private string name = "Default";
        private string textBlock = "Default";
        Disciplines discipline;

        public Disciplines Discipline
        {
            get {return this.discipline;}
            set { this.discipline = value; }
        }
        public string TextBlock
        {
            get { return this.textBlock; }
            set { this.textBlock = value; }
        }
        public string Name
        {
            get { return this.name; }
        }

        public Teachers()
        { 
        }
        public Teachers(string name)
        {
            this.name = name;
        }
    }
}
