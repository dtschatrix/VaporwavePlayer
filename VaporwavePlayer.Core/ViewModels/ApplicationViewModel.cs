using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaporwavePlayer.Core
{
    //TODO: Architecture troubles.
    //ASAP Think about the sql tables with music and other stuff. (Because of fucking course project okay).
    //TODO:Design the p2p connection(watch goddamn video on youtube).
    //Make it asynchronous.

    //TEST TEST TEST


    //Design troubles with vapormemory.
    //ASAP After login user have to see the song list and all.After user press the song the controls appear and the album cover too.

    public class ApplicationViewModel : BaseViewModel
    {
        public ApplicationPage CurrentPage { get; private set; } = ApplicationPage.Login;

        public bool SideMenuVisible { get; set; } = false;

        public BaseViewModel CurrentPageViewModel { get; set; }

        public void GoToPage(ApplicationPage page)
        {
            CurrentPage = page;

            
            SideMenuVisible = page == ApplicationPage.MainPlayerWindow;
        }

    }
}
