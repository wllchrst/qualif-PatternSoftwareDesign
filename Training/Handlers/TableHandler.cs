using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Web;
using Training.Factories;
using Training.Models;
using Training.Modules;
using Training.Repositories;

namespace Training.Handlers
{
    public class TableHandler
    {
        public static int GenerateID()
        {
            Table lastTable = TableRepositories.GetLastTable();
            if (lastTable == null)
            {
                return 1;
            }
            int id = lastTable.Id;
            return id + 1;
        }
        public static Response<Table> CreateTable(String userID, String songID)
        {
            Table table = TableFactory.CreateTable(GenerateID(), userID, songID);   
            Table t = TableRepositories.CreateTable(table);
            if (t == null) return new Response<Table>()
            {
                Success = false,
                Message = "Failed creating table",
                Payload = t
            };

            return new Response<Table>()
            {
                Success = true,
                Message = "Success creating table",
                Payload = t
            };
        }

        public static Response<List<Table>> GetAllTable()
        {
            List<Table> tables = TableRepositories.GetAllTables();
            return new Response<List<Table>>()
            {
                Success = true,
                Message = "Sucess getting all table",
                Payload = tables
            };
        }

        public static Response<List<Table>> GetAllUserTable(String userID)
        {
            List<Table> tables = TableRepositories.GetAllUserTable(userID);
            return new Response<List<Table>>()
            {
                Success = true,
                Message = "Sucess getting all table",
                Payload = tables
            };
        }

        public static Response<Boolean> GetTableByUserIDSongID(String songID, String userID)
        {
            Table table = TableRepositories.GetTableBySongAndUser(songID, userID);
            if (table == null) return new Response<Boolean>()
            {
                Success = true,
                Message = "",
                Payload = false
            };

            return new Response<Boolean>()
            {
                Success = true,
                Message = "You Already Own This Song.",
                Payload = true
            };
        }

        public static Response<List<Table>> GetUserTransaction(String userID)
        {
            List<Table> tables = TableRepositories.GetAllUserTable(userID);

            return new Response<List<Table>>()
            {
                Success = true,
                Message = "found",
                Payload = tables
            };
        }
    }
}