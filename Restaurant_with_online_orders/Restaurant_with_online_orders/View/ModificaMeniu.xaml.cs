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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Restaurant_with_online_orders.View
{
    /// <summary>
    /// Interaction logic for ModificaMeniu.xaml
    /// </summary>
    public partial class ModificaMeniu : UserControl
    {
        AngajatVM angajat = new AngajatVM();
        public ModificaMeniu()
        {
            InitializeComponent();
            preparateGrid.Items.Clear();
            int j = 0;
            ObservableCollection<AngajatVM> result = angajat.Preparate();
            foreach (var i in result)
            {
                preparateGrid.Items.Add(result[j]);
                j++;
            }

          
        }

        private void unu_Checked(object sender, RoutedEventArgs e)
        {
            if (unu.IsChecked == true)
            {
                unutxt.Text = "nu contine alergeni";
                doitxt.Text = "";
                treitxt.Text = "";
                patrutxt.Text = "";
                cincitxt.Text = "";
                sasetxt.Text = "";
                saptetxt.Text = "";
                opttxt.Text = "";

                doi.IsChecked = false;
                trei.IsChecked = false;
                patru.IsChecked = false;
                cinci.IsChecked = false;
                sapte.IsChecked = false;
                sase.IsChecked = false;
                opt.IsChecked = false;
            }
            else
                unutxt.Text = "";
        }

        private void doi_Checked(object sender, RoutedEventArgs e)
        {
            if(doi.IsChecked==true)
            {
                doitxt.Text = "gluten";
                unutxt.Text = "";
                unu.IsChecked = false;
            }
            else
            {
                doitxt.Text = "";
            }
        }

        private void trei_Checked(object sender, RoutedEventArgs e)
        {
            if (trei.IsChecked == true)
            {
                treitxt.Text = "oua";
                unutxt.Text = "";
                unu.IsChecked = false;
            }
            else
            {
                treitxt.Text = "";
            }
        }

        private void patru_Checked(object sender, RoutedEventArgs e)
        {
            if(patru.IsChecked==true)
            {
                patrutxt.Text = "lactoza";
                unutxt.Text = "";
                unu.IsChecked = false;
            }
            else
            {
                patrutxt.Text = "";
            }
            
        }

        private void cinci_Checked(object sender, RoutedEventArgs e)
        {
            if(cinci.IsChecked==true)
            {
                cincitxt.Text = "mustar";
                unutxt.Text = "";
                unu.IsChecked = false;
            }
            else
            {
                cincitxt.Text = "";
            }
        }

        private void opt_Checked(object sender, RoutedEventArgs e)
        {
            if(opt.IsChecked==true)
            {
                opttxt.Text = "peste";
                unutxt.Text = "";
                unu.IsChecked = false;
            }
            else
            {
                opttxt.Text = "";
            }
        }

        private void sase_Checked(object sender, RoutedEventArgs e)
        {
            if(sase.IsChecked==true)
            {
                sasetxt.Text = "crustacee";
                unutxt.Text = "";
                unu.IsChecked = false;
            }
            else
            {
                sasetxt.Text = "";
            }
            
        }

        private void sapte_Checked(object sender, RoutedEventArgs e)
        {
            if(sapte.IsChecked==true)
            {
                saptetxt.Text = "telina";
                unutxt.Text = "";
                unu.IsChecked = false;
            }
            else
            {
                saptetxt.Text = "";
            }
            
        } 
    }
}
