using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
  

    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;
            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;
                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }
                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        ICollection CreateDataSource()
        {
            DataTable dt = new DataTable();
            DataRow dr;

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

            for (int i = 0; i < 3; i++)
            {
                dr = dt.NewRow();

                dr[0] = debtors[i].IdNumber;
                dr[1] = debtors[i].Sum;
                dr[2] = debtors[i].EndDate;
                dr[3] = debtors[i].Debtor;
                dr[4] = debtors[i].Creditor;
                if (debtors[i].Expired == false)
                {
                    dr[5] = "No";
                }
                else
                {
                    dr[5] = "Yes";
                }
                dt.Rows.Add(dr);
            }

            DataView dv = new DataView(dt);
            return dv;
        }
    }
}