using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training.Models;

namespace Training.Factories
{
    public class TableFactory
    {
        public static Table CreateTable(int id, String userID, String songID)
        {
            Table table = new Table()
            {
                Id = id,
                UserID = userID,
                SongID = songID,
            };
            return table;
        }
    }
}