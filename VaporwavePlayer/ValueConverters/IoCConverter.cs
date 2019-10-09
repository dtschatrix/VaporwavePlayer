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
    public class IoCConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //switch for all pages in application
            switch ((string)value)
            {
                case nameof(ApplicationViewModel):

                    return IoC.Get<ApplicationViewModel>();
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
