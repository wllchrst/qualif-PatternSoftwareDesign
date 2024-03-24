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
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null ||
                Request.Cookies["user_cookie"] != null)
            {
                Response.Redirect("~/Views/HomePage.aspx");
            }
        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            InfoLabel.ForeColor = System.Drawing.Color.Blue;
            String email = Email.Text;
            String password = Password.Text;

            Response<User> response = UserController.RegisterUser(email, password);

            if (response.Success)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
                return;
            }

            InfoLabel.ForeColor = System.Drawing.Color.Red
                ; InfoLabel.Text = response.Message;
            return;
        }

        protected void LoginLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/LoginPage.aspx");
        }
    }
}