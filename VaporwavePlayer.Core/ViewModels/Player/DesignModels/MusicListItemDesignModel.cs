using System;


namespace VaporwavePlayer.Core
{
    public class MusicListItemDesignModel : MusicListItemViewModel
    {

        #region Singleton

        public static MusicListItemDesignModel Instance => new MusicListItemDesignModel();

        #endregion

        #region Constructor

        public MusicListItemDesignModel()
        {
            ArtistName = "Macintosh Plus";
            SongName = @"リサフランク420 / 現代のコンピュ";
            SongDuration = "0:00 – 4:20";

        }

        #endregion
    }
}
