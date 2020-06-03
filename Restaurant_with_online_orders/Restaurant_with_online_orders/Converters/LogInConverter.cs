using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Restaurant_with_online_orders.Converters
{
    class LogInConverter : IMultiValueConverter
    {
       
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null)
            {
                return new UserVM()
                {

                    Email = values[0].ToString(),
                    Parola = values[1].ToString()
                };
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            UserVM user = value as UserVM;
            object[] result = new object[2] { user.Email, user.Parola };
            return result;
        }
    }
}
