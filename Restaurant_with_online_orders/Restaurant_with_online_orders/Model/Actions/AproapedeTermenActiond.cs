using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_with_online_orders.Model.Actions
{
    class AproapedeTermenActiond
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private AproapedeTermenVM aproapeContext;

        public AproapedeTermenActiond(AproapedeTermenVM aproapeVM)
        {
            this.aproapeContext = aproapeVM;
        }

        public ObservableCollection<AproapedeTermenVM> Get()
        {
            ObservableCollection<AproapedeTermenVM> result = new ObservableCollection<AproapedeTermenVM>();
            List<Preparat> preparate = restaurant.Preparats.ToList();

            foreach(var preparat in preparate)
            {
                if(preparat.cantitatea_totala<=250)
                {
                    result.Add(new AproapedeTermenVM()
                    {
                        IdPreparat = preparat.idPreparat,
                        Denumire = preparat.denumire,
                        CantitateTotala = (int)preparat.cantitatea_totala
                    });
                }
            }
            return result;
        }
    }
}
