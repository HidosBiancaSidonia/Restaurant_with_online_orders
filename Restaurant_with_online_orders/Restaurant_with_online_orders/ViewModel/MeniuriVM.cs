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
    class MeniuriVM : BaseVM
    {
        public MeniuriActions meniuriActions;

         public MeniuriVM()
         {
            meniuriActions = new MeniuriActions(this);

         }

        private int idClient;
        private int idMeniu;
        private string denumireMeniu;
        private string imgMeniu;
        private double pretMeniu;
        private List<string> continut = new List<string>();
        private List<string> gramaj = new List<string>();
        private List<int> cantitateTotala = new List<int>();
        private int cantitateMeniu;

        ObservableCollection<MeniuriVM> listMeniuri;

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

        public int IdMeniu
        {
            get
            {
                return idMeniu;
            }
            set
            {
                idMeniu = value;
                OnPropertyChanged("IdMeniu");
            }
        }

        public string DenumireMeniu
        {
            get
            {
                return denumireMeniu;
            }
            set
            {
                denumireMeniu = value;
                OnPropertyChanged("DenumireMeniu");
            }
        }

        public string ImgMeniu
        {
            get
            {
                return @imgMeniu;
            }
            set
            {
                imgMeniu = value;
                OnPropertyChanged("ImgMeniu");
            }
        }

        public int CantitateMeniu
        {
            get
            {
                return cantitateMeniu;
            }
            set
            {
                cantitateMeniu = value;
                OnPropertyChanged("CantitateMeniu");
            }
        }

        public double PretMeniu
        {
            get
            {
                return pretMeniu;
            }
            set
            {
                pretMeniu = value;
                OnPropertyChanged("PretMeniu");
            }
        }

        public ObservableCollection<MeniuriVM> ListMeniuri
        {
            get
            {
                return listMeniuri;
            }
            set
            {
                listMeniuri = value;
                OnPropertyChanged("ListMeniuri");
            }
        }

        public List<string> Continut
        {
            get
            {
                return continut;
            }
            set
            {
                continut = value;
                OnPropertyChanged("Continut");
            }
        }

        public List<string> Gramaj
        {
            get
            {
                return gramaj;
            }
            set
            {
                gramaj = value;
                OnPropertyChanged("Gramaj");
            }
        }

        public List<int> CantitateTotala
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

        private ICommand detaliiPreparatCommand;
        public ICommand DetaliiPreparatCommand
        {
            get
            {
                if (detaliiPreparatCommand == null)
                    detaliiPreparatCommand = new RelayCommand(meniuriActions.Detalii);
                return detaliiPreparatCommand;
            }
        }

        public ObservableCollection<MeniuriVM> GetVariabile(int id)
        {
            ListMeniuri = meniuriActions.AllMeniuri(id);
            return ListMeniuri;
        }

        private ICommand adaugalacomandaCommand;
        public ICommand AdaugaLaComandaCommand
        {
            get
            {
                if (adaugalacomandaCommand == null)
                    adaugalacomandaCommand = new RelayCommand(meniuriActions.AdaugaLaCom);
                return adaugalacomandaCommand;
            }
        }
    }
}
