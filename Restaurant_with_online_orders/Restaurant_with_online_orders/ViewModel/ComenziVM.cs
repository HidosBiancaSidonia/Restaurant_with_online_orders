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
    class ComenziVM :BaseVM
    {
        ComenziActions comenziActions;
        public ComenziVM()
        {
            comenziActions= new ComenziActions(this);
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

        private string denumire;
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

        private double pretTotal;
        public double PretTotal
        {
            get
            {
                return pretTotal;
            }
            set
            {
                pretTotal = value;
                OnPropertyChanged("PretTotal");
            }
        }

        private int cantitate;
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

        ObservableCollection<ComenziVM> listCos;
        public ObservableCollection<ComenziVM> ListCos
        {
            get
            {
                return listCos;
            }
            set
            {
                listCos = value;
                OnPropertyChanged("ListCos");
            }
        }

        public ObservableCollection<ComenziVM> Get()
        {
            ListCos = comenziActions.GetCos();
            return ListCos;
        }

        private ICommand catreComandaCommand;
        public ICommand CatreComandaCommand
        {
            get
            {
                if (catreComandaCommand == null)
                    catreComandaCommand = new RelayCommand(comenziActions.CosCumparaturi);
                return catreComandaCommand;
            }
        }

        public void GetPretCuDiscount()
        {
            comenziActions.GetPretCuDiscount();
        }

        private ICommand comandaCommand;
        public ICommand ComandaCommand
        {
            get
            {
                if (comandaCommand == null)
                    comandaCommand = new RelayCommand(comenziActions.Comanda);
                return comandaCommand;
            }
        }
    }
}
