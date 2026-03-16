using StudentApp.Models;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace StudentApp.Converters
{
    public class StreamToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            StreamType stream = (StreamType)value;

            switch (stream)
            {
                case StreamType.Arts:
                    return Brushes.Yellow;

                case StreamType.Commerce:
                    return Brushes.Gray;

                case StreamType.Science:
                    return Brushes.Blue;

                default:
                    return Brushes.Transparent;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}