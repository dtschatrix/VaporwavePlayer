using System;
using System.Runtime.InteropServices;
using System.Security;

namespace VaporwavePlayer.Core
{
    /// <summary>
    /// Helpers for <see cref="SecureString"/> class
    /// </summary>
   public static class SecureStringHelpers
    {
        public static string Unsecure(this SecureString secureString)
        {
            if (secureString == null)
                return String.Empty;

            var unmanagedString = IntPtr.Zero;

            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);

            }
            finally
            {
                //Clean up all memory 
                secureString.Dispose();
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }

        }



    }
}
