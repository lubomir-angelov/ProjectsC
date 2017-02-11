namespace _01_03.StudentCatalog
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable<Student>
    {
        #region Inside fields
        private string firstName;
        private string secondName;
        private string lastName;
        private long ssn;
        private string address;
        private string phoneNumber;
        private string email;
        private int course;
        private int uniChoice;
        private int facChoice;
        private int specChoice;
        private Specialities speciality;
        private Universities university;
        private Faculties faculty;
        #endregion
        #region Properties
        public Specialities Speciality { get { return this.speciality; } }
        public Universities University { get { return this.university; } }
        public Faculties Faculty { get { return this.faculty; } }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string SecondName
        {
            get { return this.secondName; }
            set { this.secondName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public string Name
        {
            get { return this.firstName + " " + this.secondName + " " + this.lastName; }
        }
        public long SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }
        #endregion
        #region Enumerations
        public enum Specialities
        {
            Law,
            History,
            Medicine,
            Informatics,
            Mathematics
        }

        public enum Universities
        {
            Oxford,
            Stanford,
            Sofia,
            UCL,
            UCLA
        }

        public enum Faculties
        {
            Law,
            History,
            Biological,
            Mathematics,
        }
        #endregion

        #region TypeConstructors
        public Student()
        { 
        }
        public Student(string firstName, string secondName, string lastName, long studentSecNum, string address, string phoneNumber, string email, int course, int university, int faculty, int speciality)
        {
            if (university < 0 || university > 4)
            {
                throw new ArgumentException("Please choose a number between 0 and 4.");
            }
            if(faculty < 0 || faculty > 3)
            {
                throw new ArgumentException("Please choose a number between 0 and 3.");
            }
            if (speciality < 0 || speciality > 4)
            {
                throw new ArgumentException("Please choose a number between 0 and 4.");
            }

            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.ssn = studentSecNum;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.course = course;
            this.uniChoice = university;
            this.facChoice = faculty;
            this.specChoice = speciality;

            switch (university)
            {
                case 0: this.university = Universities.Oxford; break;
                case 1: this.university = Universities.Stanford; break;
                case 2: this.university = Universities.Sofia; break;
                case 3: this.university = Universities.UCL; break;
                case 4: this.university = Universities.UCLA; break;
                default: break;
            }

            switch (faculty)
            {
                case 0: this.faculty = Faculties.Law; break;
                case 1: this.faculty = Faculties.History; break;
                case 2: this.faculty = Faculties.Biological; break;
                case 3: this.faculty = Faculties.Mathematics; break;
                default: break;
            }
            switch (speciality)
            {
                case 0: this.speciality = Specialities.Law; break;
                case 1: this.speciality = Specialities.History; break;
                case 2: this.speciality = Specialities.Medicine; break;
                case 3: this.speciality = Specialities.Informatics; break;
                case 4: this.speciality = Specialities.Mathematics; break;
                default: break;
            }
        }
        #endregion
        #region Framework Methods Overrides
        //students are equal if they are at the same university, faculty, speciality and course
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Student student = obj as Student;
            if((System.Object) student == null)
            {
                return false;
            }
            return (this.university == student.University) && (this.faculty == student.Faculty) && (this.speciality == student.Speciality) && (this.course == student.Course);
        }
        public bool Equals(Student student)
        {
            if ((object)student == null)
            {
                return false;
            }
            return (this.university == student.University) && (this.faculty == student.Faculty) && (this.speciality == student.Speciality) && (this.course == student.Course);
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;

               /* int uni = (int)this.university;
                int fac = (int)this.faculty;
                int spec = (int)this.speciality; */

                //values for university, faculty, speciality and course cannot be null or equal to 0 so we don't have to check?
                //gethashcode, basic rules for overriding  http://blogs.msdn.com/b/ericlippert/archive/2011/02/28/guidelines-and-rules-for-gethashcode.aspx

                hash = hash * 23 + this.course.GetHashCode();
                hash = hash * 23 + this.university.GetHashCode();
                hash = hash * 23 + this.faculty.GetHashCode();
                hash = hash * 23 + this.speciality.GetHashCode();

                return hash;
            }
        } 
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append("Students name: ");
            result.Append(Name);
            result.Append("\n");
            result.Append("SSN: ");
            result.Append(SSN + "\n");
            result.Append("Address: " + address + "\n");
            result.Append("Mobile phone number: " + PhoneNumber + "\n");
            result.Append("Email: " + email + "\n");
            result.Append("Course: " + this.course + "\n");
            result.Append("University: " + university + "\n");
            result.Append("Faculty of " + faculty + "\n");
            result.Append("Speciality: " + speciality + "\n");

            return result.ToString();
        }
        public static bool operator ==(Student a, Student b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return (a.university == b.university) && (a.faculty == b.faculty) && (a.speciality == b.speciality) && (a.course == b.course);
        }
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }
        #endregion
        #region Interface Implementation
        //as stated in the main comment purposely left the return type of copy to be object not Student/ ?correct implementation?
        //IClonable has no IClonable<T> thus we should not directly give the return type?
        public object Clone()
        {
            Student Copy = new Student(this.firstName, this.secondName, this.lastName, this.ssn, this.address, this.phoneNumber, this.email, this.course, this.uniChoice, this.facChoice, this.specChoice);
            return Copy;
        }
        public int CompareTo(Student studentToCompare)
        {
            if (studentToCompare == null)
            {
                return 1;
            }

            //Student studentToCompare = obj as Student;

           // if (studentToCompare != null)
           // {
                //first condition for comparison
                if (this.Name.CompareTo(studentToCompare.Name) != 0)
                    return this.Name.CompareTo(studentToCompare.Name);
                //second condition for comparison
                else
                    return (this.SSN.CompareTo(studentToCompare.SSN));    
            //}
          /*  else
            {
                throw new ArgumentException("Object cannot be converted to type Student");
            } */
        }
        #endregion
    }
}
