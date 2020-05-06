using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FindMyFood.Views
{
    public class ExpirationdateValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch(((DateTime)value-DateTime.Now).Days)
                {
                     case 0:
                        return Color.Red;
                    case 1:
                    return Color.Yellow;
                case 2:
                    return Color.Yellow;
                //case default:
                    

            }
            return Color.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
