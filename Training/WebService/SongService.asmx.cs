using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services;
using Training.Handlers;
using Training.Modules;

namespace Training.WebService
{
    /// <summary>
    /// Summary description for SongService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SongService : System.Web.Services.WebService
    {

        [WebMethod]
        public String GetAllSongs()
        {
            return Json.Encode(SongHandler.GetAllSongs());
        }
        [WebMethod]
        public String GetSong(String id)
        {
            return Json.Encode(SongHandler.GetSong(id));
        }
        [WebMethod]
        public String UpdateSong(String id, String songName, int price)
        {
            return Json.Encode(SongHandler.UpdateSong(id, songName, price));
        }
        [WebMethod]
        public String CreateSong(String songName, int price)
        {
            return Json.Encode(SongHandler.CreateSong(songName, price));
        }
        [WebMethod]
        public String DeleteSong(String id)
        {
            return Json.Encode(SongHandler.DeleteSong(id));
        }
    }
}
