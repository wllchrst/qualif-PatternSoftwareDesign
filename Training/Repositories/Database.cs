using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Training.Models;

namespace Training.Repositories
{
    public class Database
    {
        private static Database1Entities instance = null;
        public static Database1Entities getInstance()
        {
            if(instance == null)
            {
                instance = new Database1Entities();
            }
            return instance;
        }
    }
}