using System;

namespace VaporwavePlayer.Core
{
    public class MusicListItemViewModel : BaseViewModel
    {
        /// <summary>
        /// Display the artist name
        /// </summary>
        public string ArtistName { get; set; }
        /// <summary>
        /// Display the song name
        /// </summary>
        public string SongName { get; set; }

        /// <summary>
        /// Display the duration of the song
        /// </summary>
        public string SongDuration { get; set; }

        //TODO send images from another projects 
        /// <summary>
        /// Display the image of the album
        /// </summary>
        public string PathToAlbumImage { get; set; }
        
        /// <summary>
        /// True if current song is playing
        /// </summary>
        public bool SongIsChosen { get; set; }
        /// <summary>
        /// True if item is selected
        /// </summary>
        public bool IsSelected { get; set; }

    }
}
