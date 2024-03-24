using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Training.Models;

namespace Training.Factories
{
    public class SongFactory
    {
        public static Song CreateSong(String id, String songName, int price)
        {
            Song song = new Song()
            {
                Id = id,
                SongName = songName,
                Price = price
            };

            return song;
        }
    }
}