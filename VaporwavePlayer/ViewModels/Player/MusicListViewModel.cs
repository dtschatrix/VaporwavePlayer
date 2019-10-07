using System;
using System.Collections.Generic;
using System.Windows.Documents;

namespace VaporwavePlayer.ViewModels
{
    /// <summary>
    /// A view model for the overview music list
    /// </summary>
    public class MusicListViewModel : BaseViewModel
    {
       public List<MusicListItemViewModel> Items { get; set; }

    }
}
