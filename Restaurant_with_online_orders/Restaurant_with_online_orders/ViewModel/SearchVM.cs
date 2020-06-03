using Restaurant_with_online_orders.Model.Actions;
using Restaurant_with_online_orders.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Restaurant_with_online_orders.ViewModel
{
    class SearchVM : BaseVM
    {
        public SearchActions searchaction;
        public SearchVM()
        {
            searchaction = new SearchActions(this);
        }

        private int id;
        private string categorie;
        private string denumire;
        private double pret;
        private int cantitate;
        private string img;
        private List<string> listaAlergeni = new List<string>();

        ObservableCollection<SearchVM> listPreparate;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string Categorie
        {
            get
            {
                return categorie;
            }
            set
            {
                categorie = value;
                OnPropertyChanged("Categorie");
            }
        }

        public string Denumire
        {
            get
            {
                return denumire;
            }
            set
            {
                denumire = value;
                OnPropertyChanged("Denumire");
            }
        }

        public double Pret
        {
            get
            {
                return pret;
            }
            set
            {
                pret = value;
                OnPropertyChanged("Pret");
            }
        }

        public int Cantitate
        {
            get
            {
                return cantitate;
            }
            set
            {
                cantitate = value;
                OnPropertyChanged("Cantitate");
            }
        }

        public string Img
        {
            get
            {
                return @img;
            }
            set
            {
                img = value;
                OnPropertyChanged("Img");
            }
        }

        public ObservableCollection<SearchVM> ListPreparate
        {
            get
            {
                return listPreparate;
            }
            set
            {
                listPreparate = value;
                OnPropertyChanged("ListPreparate");
            }
        }

        public List<string> ListAlergeni
        {
            get
            {
                return listaAlergeni;
            }
            set
            {
                listaAlergeni = value;
                OnPropertyChanged("ListAlergeni");
            }
        }

        public ObservableCollection<SearchVM> AvailableMethod(int i,string cautare)
        {
            if(i==1)
                ListPreparate = searchaction.Alergen(cautare);
            if (i == 2)
                ListPreparate = searchaction.Nu_Alergen(cautare);
            if (i==3)
                ListPreparate = searchaction.Ingredient(cautare);
            if (i==4)
                ListPreparate = searchaction.Nu_Incredient(cautare);
            return ListPreparate;
        }
    }
}
