using System;
using System.Collections.Generic;
using System.Text;

using System.Globalization;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml;

namespace TestConsoleDead.Shared.Converters
{
    public class FalseToVisibleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((value != null) && (value is Boolean) &&
                (System.Convert.ToBoolean(value) == false))
                return Visibility.Visible;

            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if ((value != null) && (value is Visibility) &&
                (((Visibility)value) == Visibility.Collapsed))
                return true;

            return false;
        }
    }
}
