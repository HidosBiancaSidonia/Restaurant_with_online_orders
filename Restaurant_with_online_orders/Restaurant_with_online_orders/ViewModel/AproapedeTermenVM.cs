using Restaurant_with_online_orders.Model.Actions;
using Restaurant_with_online_orders.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_with_online_orders.ViewModel
{
    class AproapedeTermenVM : BaseVM
    {
        public AproapedeTermenActiond aproapeActions;

        public AproapedeTermenVM()
        {
            aproapeActions = new AproapedeTermenActiond(this);
        }

        private int id_preparat;
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

        private int cantitate_totala;
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

        ObservableCollection<AproapedeTermenVM> listPreparate;
        public ObservableCollection<AproapedeTermenVM> ListPreparate
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

        public ObservableCollection<AproapedeTermenVM> Get()
        {
            ListPreparate = aproapeActions.Get();
            return ListPreparate;
        }
    }
}
