using System;

namespace VaporwavePlayer.ViewModels
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

    }
}
