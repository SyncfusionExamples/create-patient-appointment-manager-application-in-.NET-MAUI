using System.Globalization;

namespace ManageAppointments
{
    /// <summary>
    /// Converter used to convert agenda view month header.
    /// </summary>
    internal class MonthToImageConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var monthName = String.Format("{0:MMMM}", value).ToLower() + ".png";
                return ImageSource.FromFile(monthName);
            }

            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }
    }
}


