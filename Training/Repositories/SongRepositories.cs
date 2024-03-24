using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training.Models;

namespace Training.Repositories
{
    public class SongRepositories
    {
        public static List<Song> GetSongs()
        {
            Database1Entities db = Database.getInstance();
            List<Song> list = db.Songs.ToList();
            return list;
        }

        public static Song GetLastSong()
        {
            return Database.getInstance().Songs.ToList().LastOrDefault();
        }

        public static Song GetSongByID(String id)
        {
            Database1Entities database = Database.getInstance();
            Song song = database.Songs.Find(id);
            return song;
        }

        public static Song CreateSong(Song song)
        {
            Database1Entities database1Entities = Database.getInstance();
            database1Entities.Songs.Add(song);
            database1Entities.SaveChanges();
            return song;
        }

        public static Song UpdateSong(Song song)
        {
            Database1Entities db = Database.getInstance();
            Song updateSong = db.Songs.Find(song.Id);

            if(updateSong == null)
            {
                return null;
            }
            updateSong.SongName = song.SongName;
            updateSong.Price = song.Price;
            db.SaveChanges();

            return updateSong;
        }

        public static Song DeleteSong(String id)
        {
            Database1Entities db = Database.getInstance();
            Song deleteSong = db.Songs.Find(id);

            if (deleteSong == null) return null;
            var relatedRecords = db.Tables.Where(r => r.SongID == deleteSong.Id);
            db.Tables.RemoveRange(relatedRecords);
            db.Songs.Remove(deleteSong);
            db.SaveChanges();
            return deleteSong;
        }
    }
}