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
    class AngajatVM : BaseVM
    {
        public AngajatActions angajatActions;

        public AngajatVM()
        {
            angajatActions = new AngajatActions(this);
        }

        private int id_preparat;
        private string categorie;
        private string denumire;
        private double pret;
        private int cantitate_portie;
        private int cantitate_totala;

        private string img;
        private List<string> alergeni;
        private List<string> totialergenii;
        ObservableCollection<AngajatVM> listPreparate;

        public int IdPreparat
        {
            get
            {
                return id_preparat;
            }
            set
            {
                id_preparat = value;
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

        public int CantitatePortie
        {
            get
            {
                return cantitate_portie;
            }
            set
            {
                cantitate_portie = value;
                OnPropertyChanged("CantitatePortie");
            }
        }

        public int CantitateTotala
        {
            get
            {
                return cantitate_totala;
            }
            set
            {
                cantitate_totala = value;
                OnPropertyChanged("CantitateTotala");
            }
        }

        public string Fotografie
        {
            get
            {
                return @img;
            }
            set
            {
                img = value;
                OnPropertyChanged("Fotografie");
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

        public List<string> TotiAlergenii
        {
            get
            {
                return totialergenii;
            }
            set
            {
                totialergenii = value;
                OnPropertyChanged("TotiAlergenii");
            }
        }

        public ObservableCollection<AngajatVM> ListPreparate
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

        public ObservableCollection<AngajatVM> Preparate()
        {
            ListPreparate = angajatActions.Preparate();
            return ListPreparate;
        }

        private ICommand addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (addCommand == null)
                    addCommand = new RelayCommand(angajatActions.AddMethod);
                return addCommand;
            }
        }

        public List<string> allAlergeni()
        {
            TotiAlergenii = angajatActions.TotiAlergenii();
            return TotiAlergenii;
        }

        private ICommand deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (deleteCommand == null)
                    deleteCommand = new RelayCommand(angajatActions.DeleteMethod);
                return deleteCommand;
            }
        }

        string id;
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
        string pr;
        public string Pr
        {
            get
            {
                return pr;
            }
            set
            {
                pr = value;
                OnPropertyChanged("Pr");
            }
        }
        string cantitateP;
        public string CantitateP
        {
            get
            {
                return cantitateP;
            }
            set
            {
                cantitateP = value;
                OnPropertyChanged("CantitateP");
            }
        }
        string cantitateT;
        public string CantitateT
        {
            get
            {
                return cantitateT;
            }
            set
            {
                cantitateT = value;
                OnPropertyChanged("CantitateT");
            }
        }

        private ICommand modifyCommand;
        public ICommand ModifyCommand
        {
            get
            {
                if (modifyCommand == null)
                    modifyCommand = new RelayCommand(angajatActions.ModifyMethod);
                return modifyCommand;
            }
        }
    }
}
