using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training.Models;

namespace Training.Factories
{
    public class UserFactory
    {
        public static User CreateUser(String id, String email, String role, String password)
        {
            User user = new User() { 
                Id = id,
                Email = email,
                Role = role,
                Password = password
            };

            return user;
        }
    }
}