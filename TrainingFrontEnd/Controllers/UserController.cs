using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using TrainingFrontEnd.Models;
using TrainingFrontEnd.Modules;
namespace TrainingFrontEnd.Controllers
{
    public class UserController
    {
        public static Response<User> LoginUser(String email, String password)
        {
            String error = "";
            if (email.Equals("") || password.Equals(""))
            {
                error = "Isi Semau Field";
            }
            else if (!email.Contains("@"))
            {
                error = "harus ada @";
            }

            if (error.Equals(""))
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                UserService.UserService us = new UserService.UserService();
                String jsonResponse = us.LoginUser(email, password);
                return Json.Decode<Response<User>>(jsonResponse);
            }

            return new Response<User>()
            {
                Success = false,
                Message = error,
                Payload = null
            };
        }

        public static Response<User> RegisterUser(String email, String password)
        {
            String error = "";
            if (email.Equals("") || password.Equals(""))
            {
                error = "Isi Semau Field";
            }
            else if (!email.Contains("@"))
            {
                error = "harus ada @";
            }

            if (error.Equals(""))
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                UserService.UserService us = new UserService.UserService();
                String jsonResponse = us.RegisterUser(email, password);
                return Json.Decode<Response<User>>(jsonResponse);
            }


            return new Response<User>()
            {
                Success = false,
                Message = error,
                Payload = null
            };
        }

        public static Response<User> LoginByCookie(String cookie)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            UserService.UserService us = new UserService.UserService();
            String jsonResponse = us.LoginByCookie(cookie);
            return Json.Decode<Response<User>>(jsonResponse);
        }

        public static Response<User> DeleteUser(String userID)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            UserService.UserService us = new UserService.UserService();
            String jsonResponse = us.DeleteUser(userID);
            return Json.Decode<Response<User>>(jsonResponse);
        }

        public static Response<User> ChangeUserRole(String userID)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            UserService.UserService us = new UserService.UserService();
            String jsonResponse = us.ChangeUserRole(userID);
            return Json.Decode<Response<User>>(jsonResponse);
        }

        public static Response<List<User>> GetAllUser()
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            UserService.UserService us = new UserService.UserService();
            String jsonResponse = us.GetAllUser();
            return Json.Decode<Response<List<User>>>(jsonResponse);
        }
    }
}