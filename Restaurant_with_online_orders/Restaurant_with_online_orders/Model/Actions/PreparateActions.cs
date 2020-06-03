using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Restaurant_with_online_orders.Model.Actions
{
    class PreparateActions
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private MenuVM menuContext;

        public PreparateActions(MenuVM menuVM)
        {
            this.menuContext = menuVM;
        }
        public PreparateActions() { }

        private List<string> nume_alergeni = new List<string>();

        public void Detalii(object obj)
        {
            MenuVM menuVM = obj as MenuVM;
            
            List<Alergen> alergeni = restaurant.Alergens.ToList();
            if (menuVM == null)
                MessageBox.Show("Va rugam selectati un preparat!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                nume_alergeni.Clear();
                foreach (var i in restaurant.ShowAlergeni(menuVM.IdPreparat).ToList())
                {
                    foreach (Alergen alg in alergeni)
                    {
                        if (i == alg.id_alergen)

                        {
                            nume_alergeni.Add(alg.denumire_alergen);
                        }
                    }
                }
                menuVM.Alergeni = nume_alergeni;
            }
        }

        public ObservableCollection<MenuVM> AllPreparate(int cat,int id)
        {
            List<Preparat> preparate = restaurant.Preparats.ToList();
            ObservableCollection<MenuVM> result = new ObservableCollection<MenuVM>();
            foreach (Preparat preparat in preparate)
            {

                if (preparat.id_categorie == cat)
                {
                    result.Add(new MenuVM()
                    {
                        IdClient=id,
                        IdPreparat = preparat.idPreparat,
                        Denumire = preparat.denumire,
                        Pret = preparat.pret,
                        Img = restaurant.ShowPictures(preparat.idPreparat).ElementAt(0).ToString(),
                        Cantitate = (int)preparat.cantitate_per_portie,
                        CantitateTotala=(int)preparat.cantitatea_totala
                    });
                }
            }
            menuContext.ListPreparate = result;
            return result;
        }

        public void AdaugaLaCom(object obj)
        {
            MenuVM menuVM = obj as MenuVM;
            if (menuVM == null)
                MessageBox.Show("Va rugam selectati un preparat!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                if (menuVM.CantitateTotala  >= menuVM.Cantitate)
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"..\..\Comanda.txt", @"..\..\Comanda.txt"), true))
                    {
                        outputFile.WriteLine(menuVM.IdClient + "," + menuVM.IdPreparat + "," + menuVM.Denumire + "," + menuVM.Pret + "," + menuVM.Cantitate+","+1);
                    }
                    MessageBox.Show("Ati adaugat preparatul cu succes la comanda!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Momentan acest preparat nu se mai gaseste la noi!\nNe vom aproviziona cat de curand posibil!\nMultumim pentru neintelegeri!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
        
}
