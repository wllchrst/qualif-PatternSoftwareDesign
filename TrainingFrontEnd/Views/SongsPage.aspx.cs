using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TrainingFrontEnd.Controllers;
using TrainingFrontEnd.Datasets;
using TrainingFrontEnd.Models;
using TrainingFrontEnd.Modules;
using TrainingFrontEnd.Reports;

namespace TrainingFrontEnd.Views
{
    public partial class SongsPage : System.Web.UI.Page
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

            if (user.Role == "Admin")
            {
                TransactionGridView.Visible = true;
            }
            else if (user.Role == "Customer")
            {
                UserTransactionGridView.Visible = true;
            }

            RefreshTransactions();
        }


        public void RefreshTransactions()
        {
            User user = Session["user"] as User;

            if (user.Role == "Customer")
            {
                Response<List<Models.Table>> response = TableController.GetUserTable(user.Id);

                if (response.Success)
                {
                    TableReport report = new TableReport();
                    CrystalReportViewer1.ReportSource = report;
                    report.SetDataSource(GetDataSet(response.Payload));
                    return;
                }
                UserTransactionGridView.DataSource = response.Payload;
                UserTransactionGridView.DataBind();
            }
            else if (user.Role == "Admin")
            {
                Response<List<Models.Table>> response = TableController.GetAllTable();

                if (response.Success)
                {
                    TableReport report = new TableReport();
                    CrystalReportViewer1.ReportSource = report;
                    report.SetDataSource(GetDataSet(response.Payload));
                    return;
                }
                TransactionGridView.DataSource = response.Payload;
                TransactionGridView.DataBind();
            }
        }

        public TableDataset GetDataSet(List<Models.Table> tables)
        {
            TableDataset dataset = new TableDataset();
            var tableTable = dataset._Tables;
            var songTable = dataset.Songs;
            foreach (Models.Table t in tables)
            {
                var tableRow = tableTable.NewRow();

                tableRow["Id"] = t.Id;
                tableRow["SongID"] = t.SongID;
                tableTable.Rows.Add(tableRow);

                var songRow = songTable.NewRow();
                Song s = t.Song;
                songRow["Id"] = s.Id;
                songRow["Price"] = s.Price;
                songRow["SongName"] = s.SongName;
                songTable.Rows.Add(songRow);
            }
            return dataset;
        }
    }
}