using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        SearchVM searchMV = new SearchVM();
        public Search()
        {
            InitializeComponent();
            this.DataContext = searchMV;
        }

        private void alergenClick(object sender, RoutedEventArgs e)
        {
            poza.Visibility = Visibility.Hidden;
            list.Visibility = Visibility.Visible;
            alergeni.Visibility = Visibility.Visible;
            alergen.IsEnabled = false;
            list.Items.Clear();
            nu_alergen.IsChecked = false;
            nu_alergen.IsEnabled = true;
            ingredient.IsChecked = false;
            ingredient.IsEnabled = true;
            nu_ingredient.IsChecked = false;
            nu_ingredient.IsEnabled = true;

            if (Regex.IsMatch(text.Text.ToString(), @"[\p{L} ]+$") != true)
            {
                MessageBox.Show("Va rugam introduceti doar litere!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                alergen.IsChecked = false;
            }
            else
            {
                int j = 0;
                ObservableCollection<SearchVM> result = searchMV.AvailableMethod(1,text.Text.ToString());
                foreach (var i in result)
                {
                    list.Items.Add(result[j]);
                    j++;
                }
                
            }
        }

        private void nu_alergenClick(object sender, RoutedEventArgs e)
        {
            poza.Visibility = Visibility.Hidden;
            list.Visibility = Visibility.Visible;
            alergeni.Visibility = Visibility.Visible;
            list.Items.Clear();
            nu_alergen.IsEnabled = false;
            alergen.IsEnabled = true;
            alergen.IsChecked = false;
            ingredient.IsChecked = false;
            ingredient.IsEnabled = true;
            nu_ingredient.IsChecked = false;
            nu_ingredient.IsEnabled = true;
            if (Regex.IsMatch(text.Text.ToString(), @"[\p{L} ]+$") != true)
            {
                MessageBox.Show("Va rugam introduceti doar litere!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                nu_alergen.IsChecked = false;
            }
            else
            {
                int j = 0;
                ObservableCollection<SearchVM> result = searchMV.AvailableMethod(2, text.Text.ToString());
                foreach (var i in result)
                {
                    list.Items.Add(result[j]);
                    j++;
                }
            }
        }

        private void ingredientClick(object sender, RoutedEventArgs e)
        {
            poza.Visibility = Visibility.Hidden;
            list.Visibility = Visibility.Visible;
            alergeni.Visibility = Visibility.Visible;
            list.Items.Clear();
            ingredient.IsEnabled = false;
            alergen.IsChecked = false;
            alergen.IsEnabled = true;
            nu_alergen.IsChecked = false;
            nu_alergen.IsEnabled = true;
            nu_ingredient.IsChecked = false;
            nu_ingredient.IsEnabled = true;
            if (Regex.IsMatch(text.Text.ToString(), @"[\p{L} ]+$") != true)
            {
                MessageBox.Show("Va rugam introduceti doar litere!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                ingredient.IsChecked = false;
            }
            else
            {
                int j = 0;
                ObservableCollection<SearchVM> result = searchMV.AvailableMethod(3, text.Text.ToString());
                foreach (var i in result)
                {
                    list.Items.Add(result[j]);
                    j++;
                }
            }
        }

        private void nu_ingredientClick(object sender, RoutedEventArgs e)
        {
            poza.Visibility = Visibility.Hidden;
            list.Visibility = Visibility.Visible;
            alergeni.Visibility = Visibility.Visible;
            list.Items.Clear();
            nu_ingredient.IsEnabled = false;
            alergen.IsChecked = false;
            alergen.IsEnabled = true;
            nu_alergen.IsChecked = false;
            nu_alergen.IsEnabled = true;
            ingredient.IsChecked = false;
            ingredient.IsEnabled = true;
            if (Regex.IsMatch(text.Text.ToString(), @"[\p{L} ]+$") != true)
            {
                MessageBox.Show("Va rugam introduceti doar litere!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                nu_ingredient.IsChecked = false;
            }
            else
            {
                int j = 0;
                ObservableCollection<SearchVM> result = searchMV.AvailableMethod(4, text.Text.ToString());
                foreach (var i in result)
                {
                    list.Items.Add(result[j]);
                    j++;
                }
            }
        }
    }
}
