using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Restaurant_with_online_orders.Converters
{
    class NewUserConverters : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null &&
                values[4] != null && values[5] != null)
            {
                return new UserVM()
                {
                    Nume = values[0].ToString(),
                    Prenume = values[1].ToString(),
                    Email = values[2].ToString(),
                    Parola = values[3].ToString(),
                    Nr_telefon = values[4].ToString(),
                    Adresa = values[5].ToString(),
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
            object[] result = new object[6] { user.Nume, user.Prenume, user.Email, user.Parola, user.Nr_telefon, user.Adresa };
            return result;
        }
    }
}
