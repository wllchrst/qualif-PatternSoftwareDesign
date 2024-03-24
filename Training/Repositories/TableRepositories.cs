using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training.Models;

namespace Training.Repositories
{
    public class TableRepositories
    {
        public static Table CreateTable(Table table)
        {
            Database1Entities db = Database.getInstance();
            db.Tables.Add(table);
            db.SaveChanges();
            return table;
        }

        public static List<Table> GetAllTables()
        {
            Database1Entities db = Database.getInstance();
            return db.Tables.ToList();
        }

        public static List<Table> GetAllUserTable(String userID)
        {
            Database1Entities database = Database.getInstance();
            return database.Tables.Where(t => t.UserID == userID).ToList();
        }

        public static Table GetLastTable()
        {
            Database1Entities database = Database.getInstance();
            return database.Tables.ToList().LastOrDefault();
        }

        public static Table GetTableBySongAndUser(String songID, String userID)
        {
            Database1Entities database = Database.getInstance();
            Table table = database.Tables.Where(t => t.UserID == userID &&  t.SongID == songID).FirstOrDefault();
            return table;
        }
    }
}