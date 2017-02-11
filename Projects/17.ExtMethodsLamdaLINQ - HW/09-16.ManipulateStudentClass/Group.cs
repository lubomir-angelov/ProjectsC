using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_16.ManipulateStudentClass
{
    class Group
    {
        enum Department
        {
            History = 1,
            Mathematics,
            Physics,
            Informatics,
        }

        private byte groupNumber = 0;
        private string departmentName = "Default";

        public byte GroupNumber
        {
            get {return this.groupNumber;}
        }
        public string DepartmentName
        {
            get { return this.departmentName; }
            set { this.DepartmentName = value; }
        }

        public Group()
        { 
        }
        //create a group department according to group number
        public Group(byte groupNumber)
        {
            this.groupNumber = groupNumber;
            switch (groupNumber)
            {
                case 1: this.departmentName = Department.History.ToString(); break;
                case 2: this.departmentName = Department.Mathematics.ToString(); break;
                case 3: this.departmentName = Department.Physics.ToString(); break;
                case 4: this.departmentName = Department.Informatics.ToString(); break;
                default: break;
            }
        }


    }
}
