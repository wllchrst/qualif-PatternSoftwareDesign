using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;
using TrainingFrontEnd.Models;
using TrainingFrontEnd.Modules;
namespace TrainingFrontEnd.Controllers
{
    public class TableController
    {
        public static Response<Boolean> IsUserBoughtSong(String songID, String userID)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            TableService.TableService tt = new TableService.TableService();
            String jsonResponse = tt.GetTableByUserIDSongID(songID, userID);
            return Json.Decode<Response<Boolean>>(jsonResponse);
        }

        public static Response<Models.Table> BuySong(String userID, String songID)
        {
            String errors = "";
            if (userID.Equals("") || songID.Equals(""))
            {
                errors = "User ID and Song ID cannot be empty";
            }

            if (errors.Equals(""))
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                TableService.TableService tt = new TableService.TableService();
                String jsonResponse = tt.CreateTable(songID, userID);
                return Json.Decode<Response<Models.Table>>(jsonResponse);
            }

            return new Response<Models.Table>()
            {
                Success = false,
                Message = errors,
                Payload = null
            };
        }

        public static Response<List<Models.Table>> GetUserTable(String userID)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            TableService.TableService tt = new TableService.TableService();
            String jsonResponse = tt.GetUserTransaction(userID);
            return Json.Decode<Response<List<Models.Table>>>(jsonResponse);
        }
        public static Response<List<Models.Table>> GetAllTable()
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            TableService.TableService tt = new TableService.TableService();
            String jsonResponse = tt.GetAllTable();
            return Json.Decode<Response<List<Models.Table>>>(jsonResponse);
        }
    }
}