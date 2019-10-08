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
        /// <summary>
        /// Command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }
        /// <summary>
        /// Command to register
        /// </summary>
        public ICommand RegisterCommand { get; set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginPageViewModel()
        {
            LoginCommand = new RelayCommandParameterized(async(parameter) => await Login(parameter));
            RegisterCommand = new RelayCommand(async()=> await Register());
        }

        
        #endregion

        /// <summary>
        /// Takes the user to login page
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(500);
                var login = LocalLogin;
                //TODO overwrite this.
               // var pass = (parameter as IHavePassword)?.securePassword.Unsecure();
            });

        }

        /// <summary>
        /// Takes the user to register page
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public async Task Register()
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                //TODO: go to register page
                ((WindowViewModel) ((MainWindow) Application.Current.MainWindow).DataContext).CurrentPage =
                        ApplicationPage.Register;
                await Task.Delay(1);
            });

        }

    }
}