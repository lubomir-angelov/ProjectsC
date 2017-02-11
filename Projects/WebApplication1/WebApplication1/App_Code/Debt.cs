using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EOSTest2
{
    class Debt
    {
        private string idNumber;
        private double sum;
        private DateTime endDate;
        private string debtor;
        private string creditor;
        private bool expired;

        public string IdNumber
        {
            get;
            private set;
        }
        public double Sum
        {
            get;
            private set;
        }
        public DateTime EndDate
        {
            get;
            private set;
        }
        public string Debtor
        {
            get;
            private set;
        }
        public string Creditor
        {
            get;
            private set;
        }
        public bool Expired
        {
            get;
            private set;
        }

        public Debt()
        { }
        public Debt(double sum, DateTime endDate, string debtor, string creditor)
        {
            this.sum = sum;
            this.endDate = endDate;
            this.debtor = debtor;
            this.creditor = creditor;
            this.idNumber = endDate.ToString() + debtor[0] + creditor[0];
            this.expired = endDate > DateTime.Now;
        }
    }
}
