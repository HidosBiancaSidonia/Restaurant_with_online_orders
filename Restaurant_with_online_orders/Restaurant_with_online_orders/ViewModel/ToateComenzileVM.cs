using Restaurant_with_online_orders.Model.Actions;
using Restaurant_with_online_orders.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Restaurant_with_online_orders.ViewModel
{
    class ToateComenzileVM : BaseVM
    {
        ToateComenzileActions toatecomenzileActions;
        public ToateComenzileVM()
        {
            toatecomenzileActions = new ToateComenzileActions(this);
        }

        private string id;
        public string Id
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


        private int id_comanda;
        public int Id_Comanda
        {
            get
            {
                return id_comanda;
            }
            set
            {
                id_comanda = value;
                OnPropertyChanged("Id_Comanda");
            }
        }

        private double pret;
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

        private string stare;
        public string Stare
        {
            get
            {
                return stare;
            }
            set
            {
                stare = value;
                OnPropertyChanged("Stare");
            }
        }

        private string codComanda;
        public string Cod
        {
            get
            {
                return codComanda;
            }
            set
            {
                codComanda = value;
                OnPropertyChanged("Cod");
            }
        }

        string data_comenzii;
        public string DataComenzii
        {
            get
            {
                return data_comenzii;
            }
            set
            {
                data_comenzii = value;
                OnPropertyChanged("DataComenzii");
            }
        }

        List<string> produse = new List<string>();
        public List<string> Produse
        {
            get
            {
                return produse;
            }
            set
            {
                produse = value;
                OnPropertyChanged("Produse");
            }
        }

        List<string> listStari = new List<string>();
        public List<string> ListStari
        {
            get
            {
                return listStari;
            }
            set
            {
                listStari = value;
                OnPropertyChanged("ListStari");
            }
        }

        string ora_livrarii;
        public string OraLivrarii
        {
            get
            {
                return ora_livrarii;
            }
            set
            {
                ora_livrarii = value;
                OnPropertyChanged("OraLivrarii");
            }
        }

        ObservableCollection<ToateComenzileVM> listComenzi;
        public ObservableCollection<ToateComenzileVM> ListComenzi
        {
            get
            {
                return listComenzi;
            }
            set
            {
                listComenzi = value;
                OnPropertyChanged("ListComenzi");
            }
        }

        private int id_client;
        public int Id_Client
        {
            get
            {
                return id_client;
            }
            set
            {
                id_client = value;
                OnPropertyChanged("Id_Client");
            }
        }

        private string nume;
        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                nume = value;
                OnPropertyChanged("Nume");
            }
        }

        private string prenume;
        public string Prenume
        {
            get
            {
                return prenume;
            }
            set
            {
                prenume = value;
                OnPropertyChanged("Prenume");
            }
        }

        private string nr_telefon;
        public string Nr_Telefon
        {
            get
            {
                return nr_telefon;
            }
            set
            {
                nr_telefon = value;
                OnPropertyChanged("Nr_Telefon");
            }
        }

        private string adresa;
        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                adresa = value;
                OnPropertyChanged("Adresa");
            }
        }

        public ObservableCollection<ToateComenzileVM> Get()
        {
            ListComenzi = toatecomenzileActions.Get();
            return ListComenzi;
        }

        public ObservableCollection<ToateComenzileVM> GetActive()
        {
            ListComenzi = toatecomenzileActions.GetActive();
            return ListComenzi;
        }

        private ICommand modifyStare;
        public ICommand ModifyStare
        {
            get
            {
                if (modifyStare == null)
                    modifyStare = new RelayCommand(toatecomenzileActions.Modify);
                return modifyStare;
            }
        }
    }
}
