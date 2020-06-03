using Restaurant_with_online_orders.Model.Actions;
using Restaurant_with_online_orders.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Restaurant_with_online_orders.ViewModel
{
    class MenuVM : BaseVM
    {
        public PreparateActions preparateActions;

        public MenuVM()
        {
            preparateActions = new PreparateActions(this);
        }

        private int idClient;
        private int idPreparat;
        private int categorie;
        private string denumire;
        private double pret;
        private int cantitate;
        private int cantitateTotala;

        private string img;
        private List<string> alergeni;
        ObservableCollection<MenuVM> listPreparate;

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

        public int IdPreparat
        {
            get
            {
                return idPreparat;
            }
            set
            {
                idPreparat = value;
                OnPropertyChanged("IdPreparat");
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

        public int Categorie
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

        public int CantitateTotala
        {
            get
            {
                return cantitateTotala;
            }
            set
            {
                cantitateTotala = value;
                OnPropertyChanged("CantitateTotala");
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

        public List<string> Alergeni
        {
            get
            {
                return alergeni;
            }
            set
            {
                alergeni = value;
                OnPropertyChanged("Alergeni");
            }
        }

        public ObservableCollection<MenuVM> ListPreparate
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

        public ObservableCollection<MenuVM> GetVariabile(int cat,int ID)
        {
            categorie = cat;
            ListPreparate = preparateActions.AllPreparate(categorie,ID);
            return ListPreparate;
        }

        public ObservableCollection<MenuVM> GetMeniuri()
        {
            //ListPreparate = preparateActions.AllPreparate(categorie);
            return ListPreparate;
        }

        private ICommand detaliiCommand;
        public ICommand DetaliiCommand
        {
            get
            {
                if (detaliiCommand == null)
                    detaliiCommand = new RelayCommand(preparateActions.Detalii);
                return detaliiCommand;
            }
        }

        private ICommand adaugalacomandaCommand;
        public ICommand AdaugaLaComandaCommand
        {
            get
            {
                if (adaugalacomandaCommand == null)
                    adaugalacomandaCommand = new RelayCommand(preparateActions.AdaugaLaCom);
                return adaugalacomandaCommand;
            }
        }
    }
}
