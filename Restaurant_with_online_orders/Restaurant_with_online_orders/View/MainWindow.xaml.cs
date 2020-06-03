using Restaurant_with_online_orders.View;
using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Restaurant_with_online_orders
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int idUser;
        public MainWindow(int id,string email)
        {
            InitializeComponent();
            idUser = id;
            meniu1.Visibility = Visibility.Hidden;
            meniu2.Visibility = Visibility.Visible;
            comenzi.Visibility = Visibility.Visible;
            initial.Visibility = Visibility.Hidden;
            creere.Visibility = Visibility.Hidden;
            log.Visibility = Visibility.Hidden;
            border.Visibility = Visibility.Hidden;
            emaill.Content = email.ToString()+"!";
        }

        private void logareBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void creareBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void meniu2_Click(object sender, RoutedEventArgs e)
        {
            Meniu menu = new Meniu(idUser);
            menu.ShowDialog();
        }

        private void comenzi_Click(object sender, RoutedEventArgs e)
        {
             ComenzileMele comenzi = new ComenzileMele(idUser);
            comenzi.ShowDialog();
        }
    }
}
