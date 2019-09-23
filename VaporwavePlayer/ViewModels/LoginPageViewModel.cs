using System;
using System.Security;
using System.Threading.Tasks;
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
        public string LocalLogin { get; set; }

        public bool LoginIsRunning { get; set; }

        // local password for user of player 
        public SecureString LocalPassword { get; set; }

        #endregion

        #region Commands

        public ICommand LoginCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginPageViewModel()
        {
            LoginCommand = new RelayCommandParameterized(async(parameter) => await Login(parameter));

        }

        
        #endregion

        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(500);
                var login = this.LocalLogin;
                //TODO overwrite this.
               // var pass = (parameter as IHavePassword)?.securePassword.Unsecure();
            });

        }


    }
}