using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using TrainingFrontEnd.Models;
using TrainingFrontEnd.Modules;

namespace TrainingFrontEnd.Controllers
{
    public class SongController
    {
        public static Response<List<Song>> GetSongs()
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            SongService.SongService ss = new SongService.SongService();
            String jsonResponse = ss.GetAllSongs();
            return Json.Decode<Response<List<Song>>>(jsonResponse);
        }

        public static Response<Song> GetSong(String id)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            SongService.SongService ss = new SongService.SongService();
            String jsonResponse = ss.GetSong(id);
            return Json.Decode<Response<Song>>(jsonResponse);
        }

        public static Response<Song> UpdateSong(String id, String songName, int price)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            SongService.SongService ss = new SongService.SongService();
            String jsonResponse = ss.UpdateSong(id, songName, price);
            return Json.Decode<Response<Song>>(jsonResponse);
        }

        public static Response<Song> CreateSong(String songName, int price)
        {
            String error = "";
            if (songName.Equals(""))
            {
                error = "Song name must be filled";
            }
            if (error.Equals(""))
            {
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

                SongService.SongService ss = new SongService.SongService();
                String jsonResponse = ss.CreateSong(songName, price);
                return Json.Decode<Response<Song>>(jsonResponse);
            }

            return new Response<Song>()
            {
                Success = false,
                Message = error,
                Payload = null
            };
        }

        public static Response<Song> DeleteSong(String id)
        {
            ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            SongService.SongService ss = new SongService.SongService();
            String jsonResponse = ss.DeleteSong(id);
            return Json.Decode<Response<Song>>(jsonResponse);
        }
    }
}