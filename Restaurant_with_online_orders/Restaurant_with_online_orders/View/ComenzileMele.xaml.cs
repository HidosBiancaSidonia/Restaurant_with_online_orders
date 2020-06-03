using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ComenzileMele.xaml
    /// </summary>
    public partial class ComenzileMele : Window
    {
        ComenzileMeleVM comenzi = new ComenzileMeleVM();
        int idU=0;
        public ComenzileMele(int id)
        {

            InitializeComponent();

            idU = id;
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            img.Visibility = Visibility.Hidden;

            toate.Visibility = Visibility.Visible;
            active.Visibility = Visibility.Hidden;
            toate_c.Items.Clear();
            ObservableCollection<ComenzileMeleVM> result = comenzi.GetComenzi(idU);
            foreach (var i in result)
            {
                toate_c.Items.Add(i);
            }
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            img.Visibility = Visibility.Hidden;
            active.Visibility = Visibility.Visible;
            toate.Visibility = Visibility.Hidden;
            cactive.Items.Clear();
            ObservableCollection<ComenzileMeleVM> result2 = comenzi.GetComenziActive(idU);
            foreach (var i in result2)
            {
                cactive.Items.Add(i);
            }
        }
    }
}
