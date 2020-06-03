using Restaurant_with_online_orders.Model.Actions;
using Restaurant_with_online_orders.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restaurant_with_online_orders.ViewModel
{
    
    class ComenzileMeleVM : BaseVM
    {
        ComenzileMeleActions comenziMeleActions;
        public ComenzileMeleVM()
        { 
            comenziMeleActions = new ComenzileMeleActions(this); 
        }

        private int idClient;
        public int IdClient
        {
            get
            {
                return idClient;
            }
            set
            {
                idClient = value;
                OnPropertyChanged("IdClient");
            }
        }

        private int id;
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

        string data_comenzii ;
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

        string ora_livrarii ;
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

        ObservableCollection<ComenzileMeleVM> listComenzi;
        public ObservableCollection<ComenzileMeleVM> ListComenzi
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

        public ObservableCollection<ComenzileMeleVM> GetComenzi(int id)
        {
            ListComenzi = comenziMeleActions.Get(id);
            return ListComenzi;
        }

        public ObservableCollection<ComenzileMeleVM> GetComenziActive(int id)
        {
            ListComenzi = comenziMeleActions.GetActive(id);
            return ListComenzi;
        }

        private ICommand anuleazaCommand;
        public ICommand AnuleazaCommand
        {
            get
            {
                if (anuleazaCommand == null)
                    anuleazaCommand = new RelayCommand(comenziMeleActions.Anuleaza);
                return anuleazaCommand;
            }
        }
    }
}
