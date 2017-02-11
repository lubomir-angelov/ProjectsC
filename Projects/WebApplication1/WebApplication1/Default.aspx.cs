using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace WebApplication1
{
    protected class Debt
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
        public Debt(string idNumber, double sum, DateTime endDate, string debtor, string creditor)
        {
            this.idNumber = idNumber;
            this.sum = sum;
            this.endDate = endDate;
            this.debtor = debtor;
            this.creditor = creditor;
            this.expired = endDate > DateTime.Now;
        }
    }
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dropList.DataSource = CreateDataSource();
            dropList.DataValueField = "IDNumber";
            dropList.DataTextField = "IDNumber";
            dropList.DataBind();
            //Populate();
        }
        public void Populate()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM [tblOne]", 
                new SqlConnection(ConfigurationManager.AppSettings["DefaultConnection"]));
            cmd.Connection.Open();

            SqlDataReader ddlValues;
            ddlValues = cmd.ExecuteReader();

            dropList.DataSource = CreateDataSource();
            dropList.DataValueField = "theName";
            dropList.DataTextField = "theName";
            dropList.DataBind();

            cmd.Connection.Close();
            cmd.Connection.Dispose();
        }

        protected DataTable CreateDataSource()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add(new DataColumn("IDNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("Sum", typeof(double)));
            dt.Columns.Add(new DataColumn("EndDate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Debtor", typeof(string)));
            dt.Columns.Add(new DataColumn("Collector", typeof(string)));
            dt.Columns.Add(new DataColumn("Expired", typeof(string)));

            DateTime firstDate = new DateTime(2014, 03, 14);
            DateTime secondDate = new DateTime(2014, 03, 24);
            DateTime thirdDate = new DateTime(2014, 2, 14);
            DateTime fourthDate = new DateTime(2013, 03, 10);
            DateTime fifthDate = new DateTime(2014, 03, 8);

            Debt firstPerson = new Debt("ABC123ABC123", 500.00, firstDate, "Длъжник 1", "Кредитор 1");
            Debt secondPerson = new Debt("DULGOVE11MUL", 600.60, secondDate, "Длъжник 2", "Кредитор 1");
            Debt thirdPerson = new Debt("RERESDA12343", 704.00, thirdDate, "Длъжник 3", "Кредитор 3");
            Debt fourthPerson = new Debt("ABC000ABC000", 801.00, fourthDate, "Длъжник 4", "Кредитор 77");
            Debt fifthPerson = new Debt("BEZALEN11SIE", 900.10, fifthDate, "Генади МС", "Кредитор 1");

            List<Debt> debtors = new List<Debt>();
            debtors.Add(firstPerson);
            debtors.Add(secondPerson);
            debtors.Add(thirdPerson);
            debtors.Add(fourthPerson);
            debtors.Add(fifthPerson);

            for (int i = 0; i < debtors.Count; i++)
            {
                dt.Rows.Add(debtors[i]);
            }

            return dt;
        }
    }
}