using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
    class Worker : Human
    {
        private int weekSalary = 0;
        private int workHoursPerDay = 0;

        public int WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public Worker()
        { }
        public Worker(int weekSalary, int workHoursPerDay)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public int MoneyPerHour(int weekSalary, int workHoursPerDay)
        {
            return weekSalary / 7 / workHoursPerDay;
        }
    }
}
