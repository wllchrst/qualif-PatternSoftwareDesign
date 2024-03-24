using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Training.Handlers;
using Training.Modules;

namespace Training.WebService
{
    /// <summary>
    /// Summary description for TableService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TableService : System.Web.Services.WebService
    {

        [WebMethod]
        public String GetTableByUserIDSongID(String songID, String userID)
        {
            return Json.Encode(TableHandler.GetTableByUserIDSongID(songID, userID));
        }

        [WebMethod]
        public String CreateTable(String userID, String songID)
        {
            return Json.Encode(TableHandler.CreateTable(songID, userID));
        }

        [WebMethod]
        public String GetUserTransaction(String userID)
        {
            return Json.Encode(TableHandler.GetUserTransaction(userID));
        }

        [WebMethod]
        public String GetAllTable()
        {
            return Json.Encode(TableHandler.GetAllTable());
        }
    }
}
