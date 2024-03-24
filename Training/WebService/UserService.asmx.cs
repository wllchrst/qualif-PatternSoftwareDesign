using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Training.Handlers;
using Training.Models;
using Training.Modules;

namespace Training.WebService
{
    /// <summary>
    /// Summary description for UserService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class UserService : System.Web.Services.WebService
    {

        [WebMethod]
        public String LoginUser(String email, String password)
        {
            return Json.Encode(UserHandler.LoginUser(email, password));
        }

        [WebMethod]
        public String RegisterUser(String email, String password)
        {
            return Json.Encode(UserHandler.RegisterUser(email, password));
        }

        [WebMethod]
        public String LoginByCookie(String id)
        {
            return Json.Encode(UserHandler.LoginByCookie(id));
        }

        [WebMethod]
        public String DeleteUser(String userID)
        {
            return Json.Encode(UserHandler.DeleteUser(userID));
        }

        [WebMethod]
        public String ChangeUserRole(String userID)
        {
            return Json.Encode(UserHandler.ChangeUserRole(userID));
        }

        [WebMethod]
        public String GetAllUser()
        {
            return Json.Encode(UserHandler.GetAllUser());

        }
    }
}
