using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training.Models;

namespace Training.Repositories
{
    public class UserRepo
    {
       
        public static User GetUser(String email)
        {
            Database1Entities db = Database.getInstance();

            User user = db.Users.Where(u => u.Email == email).FirstOrDefault();
            return user;
        }

        public static void CreateUser(User user)
        {
            Database1Entities db = Database.getInstance();
            db.Users.Add(user);
            db.SaveChanges();
        }
        public static User GetLastUser()
        {
            Database1Entities db = Database.getInstance();
            User user = db.Users.ToList().LastOrDefault();
            return user;
        }

        public static User GetUserByID(String id)
        {
            Database1Entities db = Database.getInstance();
            User user = db.Users.Find(id);
            return user;
        }

        public static List<User> GetAllUser()
        {
            Database1Entities db = Database.getInstance();
            List<User> list = db.Users.ToList();
            return list;
        }

        public static User DeleteUser(String userID)
        {
            Database1Entities db = Database.getInstance();
            User deleteUser = db.Users.Find(userID);

            var relatedRecords = db.Tables.Where(r => r.UserID == userID);
            db.Tables.RemoveRange(relatedRecords);

            db.Users.Remove(deleteUser);
            db.SaveChanges();
            return deleteUser;
        }

        public static User ChangeUserRole(String userID)
        {
            Database1Entities db = Database.getInstance();
            User updateUser = db.Users.Find(userID);

            if (updateUser == null) return null;

            updateUser.Role = (updateUser.Role == "Admin" ? "Customer" : "Admin");
            db.SaveChanges();
            return updateUser;
        }
    }
}