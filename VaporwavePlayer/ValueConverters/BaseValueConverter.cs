using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace VaporwavePlayer
{
	/// <summary>
	/// Base value converter to change one value to another
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class BaseValueConverter<T> : MarkupExtension, IValueConverter
	where T : class, new()
	{
		#region Private Methods
		private static T mConverter = null;


		#endregion
		#region Markup Extension Methods
		public override object ProvideValue(IServiceProvider serviceProvider)
		{
			return mConverter ?? (mConverter = new T());
		}

		#endregion

		#region Value Converters Method
		/// <summary>
		/// Converting values
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

		/// <summary>
		/// Converting values back to it base 
		/// </summary>
		/// <param name="value"></param>
		/// <param name="targetType"></param>
		/// <param name="parameter"></param>
		/// <param name="culture"></param>
		/// <returns></returns>
		public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);


		#endregion

	}
}
