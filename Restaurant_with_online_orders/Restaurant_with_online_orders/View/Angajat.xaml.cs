using Restaurant_with_online_orders.Model;
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
    /// Interaction logic for Angajat.xaml
    /// </summary>
    public partial class Angajat : Window
    {
        public static Angajat AngajatWindow;
        public Angajat()
        {
            InitializeComponent();
        }
        AngajatVM angajat = new AngajatVM();
        AproapedeTermenVM toate = new AproapedeTermenVM();
        ToateComenzileVM toateVM = new ToateComenzileVM();

        private void ModificaMeniu_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Visibility = Visibility.Visible;
            MainFrame.Children.Clear();
            MainFrame.Children.Add(new ModificaMeniu());
            comenzi.Visibility = Visibility.Hidden;
            comenziActive.Visibility = Visibility.Hidden;
            totalGrid.Visibility = Visibility.Hidden;

        }

        private void VizualizareComenzi_Click(object sender, RoutedEventArgs e)
        {
            listcomenzi.Items.Clear();
            MainFrame.Visibility = Visibility.Hidden;
            img.Visibility = Visibility.Hidden;
            comenzi.Visibility = Visibility.Visible;
            comenziActive.Visibility = Visibility.Hidden;
            totalGrid.Visibility = Visibility.Hidden;

            ObservableCollection<ToateComenzileVM> result = toateVM.Get();
            foreach (var i in result)
            {
                listcomenzi.Items.Add(i);
            }
        }

        private void VizualizareComenziActive_Click(object sender, RoutedEventArgs e)
        {
            text.Text = "";
            unu.IsChecked = false;
            doi.IsChecked = false;
            trei.IsChecked = false;
            patru.IsChecked = false;
            cinci.IsChecked = false;

            unu.IsEnabled = true;
            doi.IsEnabled = true;
            trei.IsEnabled = true;
            patru.IsEnabled = true;
            cinci.IsEnabled = true;

            listcomenziActive.Items.Clear();
            MainFrame.Visibility = Visibility.Hidden;
            img.Visibility = Visibility.Hidden;
            comenzi.Visibility = Visibility.Hidden;
            comenziActive.Visibility = Visibility.Visible;
            totalGrid.Visibility = Visibility.Hidden;

            ObservableCollection<ToateComenzileVM> result = toateVM.GetActive();
            foreach (var i in result)
            {
                listcomenziActive.Items.Add(i);
            }
  
        }

        private void Preparate_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Visibility = Visibility.Hidden;
            img.Visibility = Visibility.Hidden;
            comenzi.Visibility = Visibility.Hidden;
            comenziActive.Visibility = Visibility.Hidden;
            totalGrid.Visibility = Visibility.Visible;

            total.Items.Clear();
            ObservableCollection<AproapedeTermenVM> result = toate.Get();
            foreach (var i in result)
            {
                total.Items.Add(i);
            }
        }

        private void inregistrata_Checked(object sender, RoutedEventArgs e)
        {
            unu.IsEnabled = false;
            doi.IsEnabled = true;
            trei.IsEnabled = true;
            patru.IsEnabled = true;
            cinci.IsEnabled = true;

            doi.IsChecked = false;
            trei.IsChecked = false;
            patru.IsChecked = false;
            cinci.IsChecked = false;

            text.Text = "inregistrata";
        }

        private void pregateste_Checked(object sender, RoutedEventArgs e)
        {
            unu.IsEnabled = true;
            doi.IsEnabled = false;
            trei.IsEnabled = true;
            patru.IsEnabled = true;
            cinci.IsEnabled = true;

            unu.IsChecked = false;
            trei.IsChecked = false;
            patru.IsChecked = false;
            cinci.IsChecked = false;

            text.Text = "se pregateste";
        }

        private void aplecat_Checked(object sender, RoutedEventArgs e)
        {
            unu.IsEnabled = true;
            doi.IsEnabled = true;
            trei.IsEnabled = false;
            patru.IsEnabled = true;
            cinci.IsEnabled = true;

            doi.IsChecked = false;
            unu.IsChecked = false;
            patru.IsChecked = false;
            cinci.IsChecked = false;

            text.Text = "a plecat la client";
        }

        private void livrata_Checked(object sender, RoutedEventArgs e)
        {
            unu.IsEnabled = true;
            doi.IsEnabled = true;
            trei.IsEnabled = true;
            patru.IsEnabled = false;
            cinci.IsEnabled = true;

            doi.IsChecked = false;
            trei.IsChecked = false;
            unu.IsChecked = false;
            cinci.IsChecked = false;

            text.Text = "livrata";
        }

        private void anulata_Checked(object sender, RoutedEventArgs e)
        {
            unu.IsEnabled = true;
            doi.IsEnabled = true;
            trei.IsEnabled = true;
            patru.IsEnabled = true;
            cinci.IsEnabled = false;

            doi.IsChecked = false;
            trei.IsChecked = false;
            patru.IsChecked = false;
            unu.IsChecked = false;

            text.Text = "anulata";
        }
    }
}
