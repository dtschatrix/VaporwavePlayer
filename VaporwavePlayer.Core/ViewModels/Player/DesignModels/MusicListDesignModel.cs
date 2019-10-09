using System;
using System.Collections.Generic;
using VaporwavePlayer.Core;


namespace VaporwavePlayer.Core
{
    public class MusicListDesignModel : MusicListViewModel
    {

        #region Singleton

        public static MusicListDesignModel Instance => new MusicListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public MusicListDesignModel()
        {
            Items = new List<MusicListItemViewModel>
            {
                new MusicListItemViewModel
                {
                    SongName = @"リサフランク420 / 現代のコンピュ",
                    ArtistName = "Macintosh Plus",
                    SongDuration = "0:00 – 4:20",
                    PathToAlbumImage = @"/resources/backgrounds/floralshoppe.jpg",
                    SongIsChosen = true,
                    
                },
                new MusicListItemViewModel
                {
                    SongName = @"花の専門店",
                    ArtistName = "Macintosh Plus",
                    SongDuration = "0:00 – 13:37",
                    PathToAlbumImage = @"/resources/backgrounds/floralshoppe.jpg"
                },
                new MusicListItemViewModel
                {
                    SongName = @"ライブラリ",
                    ArtistName = "Macintosh Plus",
                    SongDuration = "0:00 – 19:10",
                    PathToAlbumImage = @"/resources/backgrounds/floralshoppe.jpg",
                    IsSelected = true
                    
                },
            };

        }

        #endregion
    }
}
