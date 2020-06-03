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
    public class AngajatConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values[0] != null && values[1] != null && values[2] != null && values[3] != null &&
                values[4] != null && values[5] != null && values[6] != null &&
                values[7] != null && values[8] != null && values[9] != null && values[10] != null &&
                values[11] != null && values[12] != null && values[13] != null && values[14] != null)
            {
                List<string> alergeni = new List<string>();
                alergeni.Add(values[7].ToString());
                alergeni.Add(values[8].ToString());
                alergeni.Add(values[9].ToString());
                alergeni.Add(values[10].ToString());
                alergeni.Add(values[11].ToString());
                alergeni.Add(values[12].ToString());
                alergeni.Add(values[13].ToString());
                alergeni.Add(values[14].ToString());
                alergeni.RemoveAll(item => item == "");
                return new AngajatVM()
                {
                    Id = values[0].ToString(),
                    Denumire = values[1].ToString(),
                    Categorie = values[2].ToString(),
                    Pr = values[3].ToString(),
                    CantitateP = values[4].ToString(),
                    CantitateT = values[5].ToString(),
                    Fotografie = values[6].ToString(),
                    Alergeni = alergeni
                };
            }
            else
            {
                return null;
            }
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            AngajatVM angajat = value as AngajatVM;
            object[] result = new object[8] {angajat.Id, angajat.Denumire, angajat.Categorie,angajat.Pret,angajat.CantitatePortie,angajat.CantitateTotala,angajat.Fotografie,angajat.Alergeni };
            return result;
        }
    }
}
