using System;
using System.Collections.Generic;
using System.Windows;

namespace VaporwavePlayer.Core
{
    /// <summary>
    /// A view model for the overview music list
    /// </summary>
    public class MusicListViewModel : BaseViewModel
    {
       public List<MusicListItemViewModel> Items { get; set; }

    }
}
