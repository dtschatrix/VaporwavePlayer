using System;
using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace VaporwavePlayer
{


    /// <summary>
    /// Path to Image source converter. Now only from the folder "resources/backgrounds".
    /// TODO have to changed it to take from existing files if possible/>
    /// </summary>
    public class StringToImageSourceConverter : BaseValueConverter<StringToImageSourceConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                string imagename = value as string;
                return new BitmapImage(new Uri(imagename ?? throw new InvalidOperationException(), UriKind.Relative));
                   
            }

            return null;

        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
