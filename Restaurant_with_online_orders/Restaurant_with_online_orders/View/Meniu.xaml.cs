using Restaurant_with_online_orders.Model;
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
using System.Windows.Forms.Design;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Restaurant_with_online_orders.View
{
    /// <summary>
    /// Interaction logic for Meniu.xaml
    /// </summary>
    public partial class Meniu : Window
    {
        MenuVM menu = new MenuVM();
        MeniuriVM meniu = new MeniuriVM();
        public static Meniu MeniuWindow;
        public Meniu()
        {
            InitializeComponent();
            vreau_sa_comand.Visibility = Visibility.Visible;
        }
        public int ID;
        public Meniu(int id)
        {
            InitializeComponent();
            ID = id;
            vreau_sa_comand.Visibility = Visibility.Hidden;
            catre_comanda.Visibility = Visibility.Visible;
            adauga_la_comanda1.Visibility = Visibility.Visible;
            adauga_la_comanda2.Visibility = Visibility.Visible;
            adauga_la_comanda3.Visibility = Visibility.Visible;
            adauga_la_comanda4.Visibility = Visibility.Visible;
            adauga_la_comanda5.Visibility = Visibility.Visible;
            adauga_la_comanda6.Visibility = Visibility.Visible;
            adauga_la_comanda7.Visibility = Visibility.Visible;
            adauga_la_comanda8.Visibility = Visibility.Visible;

            if (!File.Exists(@"..\..\..\Comanda.txt"))
                File.CreateText(@"..\..\..\Comanda.txt");
        }

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            if (File.Exists(@"..\..\..\Comanda.txt"))
                File.Delete(@"..\..\..\Comanda.txt");
        }

        private void MicDejun_click(object sender, RoutedEventArgs e)
        {
            int id = 1;

            restaurantIMG.Visibility = Visibility.Hidden;
            btnmicdejun.IsEnabled = false;
            btnbautura.IsEnabled = true;
            btndesert.IsEnabled = true;
            btngarnitura.IsEnabled = true;
            btnmeniuri.IsEnabled = true;
            btnsalata.IsEnabled = true;
            btnsupe.IsEnabled = true;
            btncarne.IsEnabled = true;

            MicDejun.Visibility = Visibility.Visible;
            Carne.Visibility = Visibility.Hidden;
            carneGrid.Items.Clear();
            Supa.Visibility = Visibility.Hidden;
            supaGrid.Items.Clear();
            Desert.Visibility = Visibility.Hidden;
            desertGrid.Items.Clear();
            Bautura.Visibility = Visibility.Hidden;
            bauturaGrid.Items.Clear();
            Meniuri.Visibility = Visibility.Hidden;
            meniuriGrid.Items.Clear();
            Garnitura.Visibility = Visibility.Hidden;
            garnituraGrid.Items.Clear();
            Salata.Visibility = Visibility.Hidden;
            salataGrid.Items.Clear();

            int j = 0;
            ObservableCollection<MenuVM> result = menu.GetVariabile(id,ID);
            foreach (var i in result)
            {
                micdejunGrid.Items.Add(result[j]);
                j++;
            }
        }

        private void Carne_click(object sender, RoutedEventArgs e)
        {
            int id = 2;

            restaurantIMG.Visibility = Visibility.Hidden;

            btnmicdejun.IsEnabled = true;
            btnbautura.IsEnabled = true;
            btndesert.IsEnabled = true;
            btngarnitura.IsEnabled = true;
            btnmeniuri.IsEnabled = true;
            btnsalata.IsEnabled = true;
            btnsupe.IsEnabled = true;
            btncarne.IsEnabled = false;

            Carne.Visibility = Visibility.Visible;
            MicDejun.Visibility = Visibility.Hidden;
            micdejunGrid.Items.Clear();
            Supa.Visibility = Visibility.Hidden;
            supaGrid.Items.Clear();
            Desert.Visibility = Visibility.Hidden;
            desertGrid.Items.Clear();
            Bautura.Visibility = Visibility.Hidden;
            bauturaGrid.Items.Clear();
            Meniuri.Visibility = Visibility.Hidden;
            meniuriGrid.Items.Clear();
            Garnitura.Visibility = Visibility.Hidden;
            garnituraGrid.Items.Clear();
            Salata.Visibility = Visibility.Hidden;
            salataGrid.Items.Clear();

            int j = 0;
            ObservableCollection<MenuVM> result = menu.GetVariabile(id, ID);
            foreach (var i in result)
            {
                carneGrid.Items.Add(result[j]);
                j++;
            }
        }

        private void SupaCiorba_click(object sender, RoutedEventArgs e)
        {
            int id = 3;

            restaurantIMG.Visibility = Visibility.Hidden;

            btnmicdejun.IsEnabled = true;
            btnbautura.IsEnabled = true;
            btndesert.IsEnabled = true;
            btngarnitura.IsEnabled = true;
            btnmeniuri.IsEnabled = true;
            btnsalata.IsEnabled = true;
            btnsupe.IsEnabled = false;
            btncarne.IsEnabled = true;

            Carne.Visibility = Visibility.Hidden;
            carneGrid.Items.Clear();
            MicDejun.Visibility = Visibility.Hidden;
            micdejunGrid.Items.Clear();
            Supa.Visibility = Visibility.Visible;
            Desert.Visibility = Visibility.Hidden;
            desertGrid.Items.Clear();
            Bautura.Visibility = Visibility.Hidden;
            bauturaGrid.Items.Clear();
            Meniuri.Visibility = Visibility.Hidden;
            meniuriGrid.Items.Clear();
            Garnitura.Visibility = Visibility.Hidden;
            garnituraGrid.Items.Clear();
            Salata.Visibility = Visibility.Hidden;
            salataGrid.Items.Clear();

            int j = 0;
            ObservableCollection<MenuVM> result = menu.GetVariabile(id, ID);
            foreach (var i in result)
            {
                supaGrid.Items.Add(result[j]);
                j++;
            }
        }

        private void Garnitura_click(object sender, RoutedEventArgs e)
        {
            int id = 7;

            restaurantIMG.Visibility = Visibility.Hidden;
            btnmicdejun.IsEnabled = true;
            btnbautura.IsEnabled = true;
            btndesert.IsEnabled = true;
            btngarnitura.IsEnabled = false;
            btnmeniuri.IsEnabled = true;
            btnsalata.IsEnabled = true;
            btnsupe.IsEnabled = true;
            btncarne.IsEnabled = true;

            Carne.Visibility = Visibility.Hidden;
            carneGrid.Items.Clear();
            MicDejun.Visibility = Visibility.Hidden;
            micdejunGrid.Items.Clear();
            Supa.Visibility = Visibility.Hidden;
            supaGrid.Items.Clear();
            Desert.Visibility = Visibility.Hidden;
            desertGrid.Items.Clear();
            Bautura.Visibility = Visibility.Hidden;
            bauturaGrid.Items.Clear();
            Meniuri.Visibility = Visibility.Hidden;
            meniuriGrid.Items.Clear();
            Garnitura.Visibility = Visibility.Visible;
            //garnituraGrid.Items.Clear();
            Salata.Visibility = Visibility.Hidden;
            salataGrid.Items.Clear();

            int j = 0;
            ObservableCollection<MenuVM> result = menu.GetVariabile(id, ID);
            foreach (var i in result)
            {
                garnituraGrid.Items.Add(result[j]);
                j++;
            }
        }

        private void Salata_click(object sender, RoutedEventArgs e)
        {
            int id = 8;

            restaurantIMG.Visibility = Visibility.Hidden;

            btnmicdejun.IsEnabled = true;
            btnbautura.IsEnabled = true;
            btndesert.IsEnabled = true;
            btngarnitura.IsEnabled = true;
            btnmeniuri.IsEnabled = true;
            btnsalata.IsEnabled = false;
            btnsupe.IsEnabled = true;
            btncarne.IsEnabled = true;

            Carne.Visibility = Visibility.Hidden;
            carneGrid.Items.Clear();
            MicDejun.Visibility = Visibility.Hidden;
            micdejunGrid.Items.Clear();
            Supa.Visibility = Visibility.Hidden;
            supaGrid.Items.Clear();
            Desert.Visibility = Visibility.Hidden;
            desertGrid.Items.Clear();
            Bautura.Visibility = Visibility.Hidden;
            bauturaGrid.Items.Clear();
            Meniuri.Visibility = Visibility.Hidden;
            meniuriGrid.Items.Clear();
            Garnitura.Visibility = Visibility.Hidden;
            garnituraGrid.Items.Clear();
            Salata.Visibility = Visibility.Visible;
            //salataGrid.Items.Clear();

            int j = 0;
            ObservableCollection<MenuVM> result = menu.GetVariabile(id, ID);
            foreach (var i in result)
            {
                salataGrid.Items.Add(result[j]);
                j++;
            }
        }

        private void Bautura_click(object sender, RoutedEventArgs e)
        {
            int id = 5;

            restaurantIMG.Visibility = Visibility.Hidden;

            btnmicdejun.IsEnabled = true;
            btnbautura.IsEnabled = false;
            btndesert.IsEnabled = true;
            btngarnitura.IsEnabled = true;
            btnmeniuri.IsEnabled = true;
            btnsalata.IsEnabled = true;
            btnsupe.IsEnabled = true;
            btncarne.IsEnabled = true;

            Carne.Visibility = Visibility.Hidden;
            carneGrid.Items.Clear();
            MicDejun.Visibility = Visibility.Hidden;
            micdejunGrid.Items.Clear();
            Supa.Visibility = Visibility.Hidden;
            supaGrid.Items.Clear();
            Desert.Visibility = Visibility.Hidden;
            desertGrid.Items.Clear();
            Bautura.Visibility = Visibility.Visible;
            //bauturaGrid.Items.Clear();
            Meniuri.Visibility = Visibility.Hidden;
            meniuriGrid.Items.Clear();
            Garnitura.Visibility = Visibility.Hidden;
            garnituraGrid.Items.Clear();
            Salata.Visibility = Visibility.Hidden;
            salataGrid.Items.Clear();

            int j = 0;
            ObservableCollection<MenuVM> result = menu.GetVariabile(id, ID);
            foreach (var i in result)
            {
                bauturaGrid.Items.Add(result[j]);
                j++;
            }
        }

        private void Desert_click(object sender, RoutedEventArgs e)
        {
            int id = 4;

            restaurantIMG.Visibility = Visibility.Hidden;

            btnmicdejun.IsEnabled = true;
            btnbautura.IsEnabled = true;
            btndesert.IsEnabled = false;
            btngarnitura.IsEnabled = true;
            btnmeniuri.IsEnabled = true;
            btnsalata.IsEnabled = true;
            btnsupe.IsEnabled = true;
            btncarne.IsEnabled = true;

            Carne.Visibility = Visibility.Hidden;
            carneGrid.Items.Clear();
            MicDejun.Visibility = Visibility.Hidden;
            micdejunGrid.Items.Clear();
            Supa.Visibility = Visibility.Hidden;
            supaGrid.Items.Clear();
            Desert.Visibility = Visibility.Visible;
            //desertGrid.Items.Clear();
            Bautura.Visibility = Visibility.Hidden;
            bauturaGrid.Items.Clear();
            Meniuri.Visibility = Visibility.Hidden;
            meniuriGrid.Items.Clear();
            Garnitura.Visibility = Visibility.Hidden;
            garnituraGrid.Items.Clear();
            Salata.Visibility = Visibility.Hidden;
            salataGrid.Items.Clear();

            int j = 0;
            ObservableCollection<MenuVM> result = menu.GetVariabile(id, ID);
            foreach (var i in result)
            {
                desertGrid.Items.Add(result[j]);
                j++;
            }
        }

        private void Meniuri_click(object sender, RoutedEventArgs e)
        {
            restaurantIMG.Visibility = Visibility.Hidden;

            btnmicdejun.IsEnabled = true;
            btnbautura.IsEnabled = true;
            btndesert.IsEnabled = true;
            btngarnitura.IsEnabled = true;
            btnmeniuri.IsEnabled = false;
            btnsalata.IsEnabled = true;
            btnsupe.IsEnabled = true;
            btncarne.IsEnabled = true;

            Carne.Visibility = Visibility.Hidden;
            carneGrid.Items.Clear();
            MicDejun.Visibility = Visibility.Hidden;
            micdejunGrid.Items.Clear();
            Supa.Visibility = Visibility.Hidden;
            supaGrid.Items.Clear();
            Desert.Visibility = Visibility.Hidden;
            desertGrid.Items.Clear();
            Bautura.Visibility = Visibility.Hidden;
            bauturaGrid.Items.Clear();
            Meniuri.Visibility = Visibility.Visible;
            //meniuriGrid.Items.Clear();
            Garnitura.Visibility = Visibility.Hidden;
            garnituraGrid.Items.Clear();
            Salata.Visibility = Visibility.Hidden;
            salataGrid.Items.Clear();

            int j = 0;
            ObservableCollection<MeniuriVM> result = meniu.GetVariabile(ID);
            foreach (var i in result)
            {
                meniuriGrid.Items.Add(result[j]);
                j++;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LogIn logIn = new LogIn();
            logIn.ShowDialog();
        }

        private void detalii_alergent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void detalii_Click(object sender, RoutedEventArgs e)
        {
            lbl.Visibility = Visibility.Visible;
        }

        private void listbox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            lbl.Visibility = Visibility.Hidden;

        }

        private void detaliiB_Click(object sender, RoutedEventArgs e)
        {
            lbl.Visibility = Visibility.Visible;
            lbl1.Visibility = Visibility.Visible;
            lbl2.Visibility = Visibility.Visible;
            lbl3.Visibility = Visibility.Visible;
            lbl4.Visibility = Visibility.Visible;
            lbl5.Visibility = Visibility.Visible;
            lbl6.Visibility = Visibility.Visible;
            lbl7.Visibility = Visibility.Visible;
        }
    }
}
