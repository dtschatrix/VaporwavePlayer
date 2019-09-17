using System.Windows;
using System.Windows.Input;

namespace VaporwavePlayer
{
    /// <summary>
    /// The View Model for the login page
    /// </summary>
    public class LoginPageViewModel : BaseViewModel
    {
        #region Private Member

        
        #endregion

        #region Public Properties
        //local login for user of player which could storage locally and haven't any connection with p2p in future
        public string Login { get; set; }
        #endregion

        #region Commands

        public ICommand MenuCommand { get; set; }
       
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginPageViewModel(Window window)
        {
         }
        }

        #endregion

       
    }