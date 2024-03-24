using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Training.Factories;
using Training.Models;
using Training.Modules;
using Training.Repositories;

namespace Training.Handlers
{
    public class UserHandler
    {
        public static Response<User> LoginUser(String email, String password)
        {
            User user = UserRepo.GetUser(email);
            if (user == null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "Invalid Credentail",
                    Payload = null
                };
            }
            else if(user.Password != password)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "Invalid Credentail",
                    Payload = null
                };
            }
            else
            {
                return new Response<User>()
                {
                    Success = true,
                    Message = "Login Success",
                    Payload = user
                };
            }
        }

        private static String GenerateIDForUser()
        {
            User lastUser = UserRepo.GetLastUser();
            if(lastUser == null)
            {
                return "US001";
            }
            String id = lastUser.Id;
            int ID = Convert.ToInt32(id.Substring(2)) + 1;
            String returnID = "US" + ID;
            return returnID;
        }

        public static Response<User> RegisterUser(String email, String password)
        {
            String role = "Customer";
            if(email.Contains("admin"))
            {
                role = "Admin";
            }

            String generatedID = GenerateIDForUser();

            Console.WriteLine(generatedID);

            User user = UserFactory.CreateUser(generatedID, email, role, password);

            UserRepo.CreateUser(user);
            return new Response<User>()
            {
                Success = true,
                Message = "register sukses brok",
                Payload = user
            };
        }
        public static Response<User> LoginByCookie(String id)
        {
            User user = UserRepo.GetUserByID(id);

            if (user == null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "Faked cookie bitch",
                    Payload = null
                };
            }
            return new Response<User>()
            {
                Success = true,
                Message = "User is Login",
                Payload = user
            };
        }

        public static Response<User> DeleteUser(String userID)
        {
            User user = UserRepo.DeleteUser(userID);
            if (user == null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "User not found",
                    Payload = null
                };
            }

            return new Response<User>()
            {
                Success = true,
                Message = "User Deleted",
                Payload = user
            };
        }

        public static Response<User> ChangeUserRole(String userID)
        {
            User user = UserRepo.ChangeUserRole(userID);
            if (user == null)
            {
                return new Response<User>()
                {
                    Success = false,
                    Message = "User not found",
                    Payload = null
                };
            }

            return new Response<User>()
            {
                Success = true,
                Message = "User Role Updated",
                Payload = user
            };
        }

        public static Response<List<User>> GetAllUser()
        {
            List<User> users = UserRepo.GetAllUser();
            return new Response<List<User>>()
            {
                Success = true,
                Message = "",
                Payload = users
            };
        }
    }
}