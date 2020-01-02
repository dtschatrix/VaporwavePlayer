using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace VaporwavePlayer.Core
{
    public class MusicListItemViewModel : BaseViewModel
    {
        #region Public Properties

       
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

        #endregion

        #region Public Commands

        public ICommand OpenSongCommand { get; set; }

        #endregion

        #region Constructor
   /*     public MusicListItemViewModel()
        {
            OpenSongCommand = new RelayCommand(OpenSong);


        } */


        #endregion

        #region Command Methods

      /*  public void OpenSong()
        {
            IoC.Application.GoToPage(ApplicationPage.MainPlayerWindow, new MusicListViewModel()
            {
                Items = new List<MusicListItemViewModel>
                {
                    new MusicListItemViewModel()
                    {
                        SongName = SongName,
                        SongDuration = SongDuration,
                        ArtistName = ArtistName,
                        PathToAlbumImage = PathToAlbumImage
                    }
                }
            });
        }*/

        #endregion

    }
}
