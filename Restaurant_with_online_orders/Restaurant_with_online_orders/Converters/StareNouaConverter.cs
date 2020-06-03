using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Restaurant_with_online_orders.Converters
{
    class StareNouaConverter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null)
            {
                return new ToateComenzileVM()
                {
                    Id = values[0].ToString(),
                    Stare = values[1].ToString(),
                };
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            ToateComenzileVM comenzi = value as ToateComenzileVM;
            object[] result = new object[2] { comenzi.Id, comenzi.Stare };
            return result;
        }
    }
}
