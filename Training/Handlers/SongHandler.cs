using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training.Factories;
using Training.Models;
using Training.Modules;
using Training.Repositories;

namespace Training.Handlers
{
    public class SongHandler
    {
        public static Response<List<Song>> GetAllSongs()
        {
            List<Song> songs = SongRepositories.GetSongs();

            return new Response<List<Song>>()
            {
                Success = true,
                Message = "Retrieved all books",
                Payload = songs
            };
        }

        public static Response<Song> GetSong(String id)
        {
            Song song = SongRepositories.GetSongByID(id);

            if (song == null) return new Response<Song>() {
                Success = false,
                Message = "Song Not Found",
                Payload = null
            };

            return new Response<Song>()
            {
                Success = true,
                Message = "Song Found",
                Payload = song
            };
        }

        public static String generateSongID()
        {
            Song lastSong = SongRepositories.GetLastSong();
            if (lastSong == null)
            {
                return "SO001";
            }
            String id = lastSong.Id;
            int ID = Convert.ToInt32(id.Substring(2)) + 1;
            String returnID = "SO" + ID;
            return returnID;
        }

        public static Response<Song> CreateSong(String songName, int price)
        {
            String id = generateSongID();
            Song song = SongFactory.CreateSong(id, songName, price);
            Song createdSong = SongRepositories.CreateSong(song);

            return new Response<Song>()
            {
                Success = true,
                Message = "Created Song",
                Payload = createdSong
            };
        }

        public static Response<Song> UpdateSong(String id, String songName, int price)
        {
            Song song = SongFactory.CreateSong(id, songName, price);
            Song updated = SongRepositories.UpdateSong(song);
            if (updated == null) return new Response<Song>()
            {
                Success = false,
                Message = "SOng not found",
                Payload = updated,
            };
            return new Response<Song>()
            {
                Success = true,
                Message = "Successfully updated song",
                Payload = updated,
            };
        }

        public static Response<Song> DeleteSong(String id)
        {
            Song deleted = SongRepositories.DeleteSong(id);
            if (deleted == null) return new Response<Song>()
            {
                Success = false,
                Message = "Song not found",
                Payload = deleted,
            };
            return new Response<Song>()
            {
                Success = true,
                Message = "Successfully deleted song",
                Payload = deleted,
            };
        }
    }
}