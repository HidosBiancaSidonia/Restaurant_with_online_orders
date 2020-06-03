using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restaurant_with_online_orders.View
{
    /// <summary>
    /// Interaction logic for Cos.xaml
    /// </summary>
    public partial class Cos : Window
    {
        ComenziVM comenzi = new ComenziVM();
        public static Cos CosWindows;
        public Cos()
        {
            InitializeComponent();

            int j = 0;
            ObservableCollection<ComenziVM> result = comenzi.Get();
            foreach (var i in result)
            {
                list.Items.Add(result[j]);
                j++;
            }
            string[] lines = File.ReadAllLines(@"..\..\..\PretTotal.txt");
            pretTotal.Text = lines[0]+"  lei";
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (File.Exists(@"..\..\..\PretTotal.txt"))
                File.WriteAllText(@"..\..\..\PretTotal.txt", String.Empty);
            if (File.Exists(@"..\..\..\PretCuDiscount.txt"))
                File.WriteAllText(@"..\..\..\PretCuDiscount.txt", String.Empty);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            comenzi.GetPretCuDiscount();
            string[] lines = File.ReadAllLines(@"..\..\..\PretCuDiscount.txt");
            pretTotalCuFaraD.Text= lines[0] + "  lei";
            comanda.IsEnabled = true;
        }

        private void comanda_Click(object sender, RoutedEventArgs e)
        {
            comanda.IsEnabled = false;
            discount.IsEnabled = false;
        }
    }
}
