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
    public partial class WebForm1 : System.Web.UI.Page
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

            RefreshSongList();
            RefreshUserList();

            User user = Session["user"] as User;

            if (user.Role == "Admin")
            {
                SongsGridView.Columns[3].Visible = true;
                UserGridView.Columns[4].Visible = true;
                CreateContainer.Visible = true;
                ManageUsers.Visible = true;
            }
            else if (user.Role == "Customer")
            {
                CreateContainer.Visible = false;
                ManageUsers.Visible = false;
                SongsGridView.Columns[4].Visible = true;
            }
        }

        public void RefreshSongList()
        {
            Response<List<Song>> response = SongController.GetSongs();

            if (response.Success)
            {
                SongsGridView.DataSource = response.Payload;
                SongsGridView.DataBind();
            }
        }

        public void RefreshUserList()
        {
            Response<List<User>> response = UserController.GetAllUser();

            if (response.Success)
            {
                UserGridView.DataSource = response.Payload;
                UserGridView.DataBind();
            }
        }

        protected void SongsGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow deleted = SongsGridView.Rows[e.RowIndex];
            String id = deleted.Cells[0].Text;

            Response<Song> response = SongController.DeleteSong(id);

            if (response.Success)
            {
                RefreshSongList();
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            RefreshSongList();
        }

        protected void SongsGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow deleted = SongsGridView.Rows[e.NewEditIndex];
            String id = deleted.Cells[0].Text;
            Response.Redirect("~/Views/UpdateSongPage.aspx?ID=" + id);
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String songName = SongNameTextBox.Text;
            int price = Convert.ToInt32(PriceTextBox.Text);

            Response<Song> response = SongController.CreateSong(songName, price);

            if (response.Success)
            {
                RefreshSongList();
                return;
            }
        }

        protected void SongsGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Buy")
            {
                Control sourceControl = e.CommandSource as Control;
                GridViewRow row = sourceControl.NamingContainer as GridViewRow;
                int rowIndex = row.RowIndex;
                String songID = SongsGridView.Rows[rowIndex].Cells[0].Text;

                User currentUser = Session["user"] as User;

                Response<Boolean> check = TableController.IsUserBoughtSong(songID, currentUser.Id);

                if (check.Payload == true)
                {
                    Log.Text = check.Message;
                    return;
                }

                Response<Models.Table> response = TableController.BuySong(currentUser.Id, songID);
            }
        }

        protected void UserGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow deleted = UserGridView.Rows[e.RowIndex];
            String id = deleted.Cells[0].Text;

            Response<User> response = UserController.DeleteUser(id);
            Log.Text = id;
            if (response.Success)
            {
                RefreshUserList();
            }
        }

        protected void UserGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow deleted = SongsGridView.Rows[e.NewEditIndex];
            String id = deleted.Cells[0].Text;
            Response<User> response = UserController.ChangeUserRole(id);

            Log.Text = response.Message;
            if (response.Success)
            {
                RefreshUserList();
            }
        }
    }
}