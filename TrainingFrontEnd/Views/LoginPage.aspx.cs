using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainingFrontEnd.Controllers;
using TrainingFrontEnd.Models;
using TrainingFrontEnd.Modules;

namespace TrainingFrontEnd.Views
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null ||
                Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            Boolean rememberMe = RememberMeCheck.Checked;
            ErrorLabel.ForeColor = System.Drawing.Color.Red;
            String email = Email.Text;
            String password = Password.Text;

            Response<User> response = UserController.LoginUser(email, password);

            if (!response.Success)
            {
                ErrorLabel.Text = response.Message;
                return;
            }

            ErrorLabel.ForeColor = System.Drawing.Color.Blue; ErrorLabel.Text = response.Message;
            Session["user"] = response.Payload;

            if (rememberMe)
            {
                HttpCookie cookie = new HttpCookie("user_cookie");
                cookie.Value = response.Payload.Id;
                cookie.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("~/Views/HomePage.aspx");
            return;
        }

        protected void RegisterPageLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/RegisterPage.aspx");
        }
    }
}