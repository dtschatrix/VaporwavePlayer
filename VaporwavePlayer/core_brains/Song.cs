using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VaporwavePlayer
{
    public class Song : BaseViewModel
    {
        private string _artist;
        private string _song_name;
        private string _genre;

        public int Id { get; set; }
        public int Duration { get; private set; }


        public Song(int duration, int id)
        {
            this.Id = id;
            this.Duration = duration;
            _artist = "Unknown";
            _song_name = "Unknown";
        }

        public Song(string artist, int duration, int id)
        : this(duration, id)
        {
            this._artist = artist;
        }

        public Song(string artist, int duration, string genre, int id)
        : this(artist,duration, id)
        {
            this._genre = genre;
        }

        public Song(string artist, int duration, string genre, int id, string song_name)
        :this (artist,duration,genre,id)
        {
            this._song_name = song_name;
        }

    }
}
