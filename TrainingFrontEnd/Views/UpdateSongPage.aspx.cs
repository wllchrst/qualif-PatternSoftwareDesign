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
    public partial class UpdateSongPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null &&
                Request.Cookies["user_cookie"] == null)
            {
                Response.Redirect("~/Views/LoginPage.aspx");
                return;
            }

            if (Session["user"] == null)
            {
                String cookie = Request.Cookies["user_cookie"].Value;
                Response<User> response = UserController.LoginByCookie(cookie);

                if (!response.Success)
                {
                    Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-100);
                    return;
                }

                Session["user"] = response.Payload;
            }

            User user = Session["user"] as User;
            String userRole = user.Role;

            if (userRole == "Customer")
            {
                Response.Redirect("~/Views/HomePage.aspx");
                return;
            }

            if (!IsPostBack)
            {
                String id = Request["ID"];

                Response<Song> response = SongController.GetSong(id);

                if (!response.Success)
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                    return;
                }

                SongNameTextBox.Text = response.Payload.SongName;
                PriceTextBox.Text = Convert.ToString(response.Payload.Price);
            }
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            String songName = SongNameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);
            String id = Request["ID"];

            Response<Song> response = SongController.UpdateSong(id, songName, price);

            Response.Redirect("~/Views/HomePage.aspx");
        }
    }
}