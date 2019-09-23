using System.Security;

namespace VaporwavePlayer
{
    /// <summary>
    /// Help interface for securestring
    /// </summary>
    public interface IHavePassword
    {
        SecureString securePassword { get; }
    }
}