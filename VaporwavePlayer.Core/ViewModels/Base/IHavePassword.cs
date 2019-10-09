using System.Security;

namespace VaporwavePlayer.Core
{
    /// <summary>
    /// Help interface for securestring
    /// </summary>
    public interface IHavePassword
    {
        SecureString securePassword { get; }
    }
}