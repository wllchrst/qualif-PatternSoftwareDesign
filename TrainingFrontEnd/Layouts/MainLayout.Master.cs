using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrainingFrontEnd.Layouts
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HomeButtonLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/HomePage.aspx");
        }

        protected void LogOutButtonLink_Click(object sender, EventArgs e)
        {
            // log out.
            HttpCookie cookie = Request.Cookies["user_cookie"];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddDays(-100);
                Response.Cookies.Add(cookie);
            }

            Session.Remove("user");
            Response.Redirect("~/Views/LoginPage.aspx");
        }

        protected void SongsButtonLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/SongsPage.aspx");

        }
    }
}