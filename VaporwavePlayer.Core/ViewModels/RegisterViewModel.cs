using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VaporwavePlayer.Core
{
    /// <summary>
    /// The View Model for the register page
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {
        #region Private Member


        #endregion

        #region Public Properties

        //local login for user of player which could storage locally and haven't any connection with p2p in future
        public string LocalLogin { get; set; }

        public bool RegisterIsRunning { get; set; }

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
        public RegisterViewModel()
        {
            RegisterCommand = new RelayCommandParameterized(async(parameter) => await Register(parameter));
            LoginCommand = new RelayCommand(async()=> await Login());
        }

        
        #endregion

        /// <summary>
        /// Attempts to create local user
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public async Task Register(object parameter)
        {
            await RunCommand(() => this.RegisterIsRunning, async () =>
            {
                await Task.Delay(500);
                var register = LocalLogin;
                //TODO overwrite this.
               // var pass = (parameter as IHavePassword)?.securePassword.Unsecure();
            });

        }

        /// <summary>
        /// Takes the user to login page
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public async Task Login()
        {
            //IoC.Get<ApplicationViewModel>().SideMenuVisible ^= true;
            //return;

            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Login);
            await Task.Delay(1);

        }

    }
}