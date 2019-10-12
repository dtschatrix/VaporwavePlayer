using System.Security;
using VaporwavePlayer.Core;

namespace VaporwavePlayer
{
    /// <summary>
    /// Interaction logic for PlayerLoginPage.xaml
    /// </summary>
    public partial class PlayerRegisterPage: BasePage<RegisterViewModel>, IHavePassword
    {
        public PlayerRegisterPage()
        {
            InitializeComponent();
            

        }


        public SecureString securePassword => PasswordText.SecurePassword;
    }
}
