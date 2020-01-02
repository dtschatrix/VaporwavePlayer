using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VaporwavePlayer.Core;
using VaporwavePlayer;

namespace VaporwavePlayer
{
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType = null, object parameter = null, CultureInfo culture = null)
        {
            //switch for all pages in application
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new PlayerLoginPage();
                case ApplicationPage.MainPlayerWindow:
                    return new MainPlayerWindow();
                case ApplicationPage.Register:
                    return new PlayerRegisterPage();
    

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
