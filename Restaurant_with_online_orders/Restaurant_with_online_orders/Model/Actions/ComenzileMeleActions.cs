using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Restaurant_with_online_orders.Model.Actions
{
    class ComenzileMeleActions
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private ComenzileMeleVM comenziContext;

        public ComenzileMeleActions(ComenzileMeleVM comenzilemeleVM)
        {
            this.comenziContext = comenzilemeleVM;
        }

        public ObservableCollection<ComenzileMeleVM> Get(int id)
        {
            ObservableCollection<ComenzileMeleVM> result = new ObservableCollection<ComenzileMeleVM>();

            List<Comanda> comenzi = restaurant.Comandas.ToList();
            List<Item> items = restaurant.Items.ToList();
            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();
            List<int> id_produseP = new List<int>();
            List<int> id_produseM = new List<int>();
            List<string> produse = new List<string>();
            

            foreach (var comanda in comenzi)
            {
                string ora = "-";
                if (comanda.id_utilizator == id)
                {

                    if (comanda.ora_livrare != null)
                    {
                        ora = DateTime.Parse(comanda.ora_livrare.ToString()).ToShortTimeString();
                    }


                    foreach (var item in items)
                    {
                        if (item.id_comanda == comanda.id)
                        {
                            if (item.id_meniu == null)
                            {
                                id_produseP.Add((int)item.id_preparat);
                            }
                            else if (item.id_preparat == null)
                            {
                                id_produseM.Add((int)item.id_meniu);
                            }
                        }
                    }

                    
                    foreach (var i in id_produseP)
                    {
                        foreach (var preparat in preparate)
                        {
                            if (preparat.idPreparat == i)
                            {
                                produse.Add(preparat.denumire);
                            }
                        }
                    }

                    foreach (var i in id_produseM)
                    {
                        foreach (var meniu in meniuri)
                        {
                            if (meniu.id_meniu == i)
                            {
                                produse.Add(meniu.denumire_meniu);
                            }
                        }
                    }

                    result.Add(new ComenzileMeleVM()
                    {
                        Id = comanda.id,
                        IdClient = id,
                        Stare = restaurant.GetStare(comanda.id_stare_comanda).ElementAt(0).ToString(),
                        Pret = comanda.pret,
                        DataComenzii = DateTime.Parse(comanda.data_comanda.ToString()).ToShortDateString(),
                        OraLivrarii = ora,
                        Cod = comanda.cod_comanda,
                        Produse = produse.ToList()
                    });
                  

                    id_produseP.Clear();
                    id_produseM.Clear();
                    produse.Clear();
                }

            }

            return result;
        }

        public ObservableCollection<ComenzileMeleVM> GetActive(int id)
        {
            ObservableCollection<ComenzileMeleVM> result = new ObservableCollection<ComenzileMeleVM>();
            List<Comanda> comenzi = restaurant.Comandas.ToList();
            List<Item> items = restaurant.Items.ToList();
            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();
            List<int> id_produseP = new List<int>();
            List<int> id_produseM = new List<int>();
            List<string> produse = new List<string>();
            foreach (var comanda in comenzi)
            {
                
                if ((comanda.id_stare_comanda!=4) && (comanda.id_stare_comanda != 5))
                {
                    if (comanda.id_utilizator == id)
                    {
                        foreach (var item in items)
                        {
                            if (item.id_comanda == comanda.id)
                            {
                                if (item.id_meniu == null)
                                {
                                    id_produseP.Add((int)item.id_preparat);
                                }
                                else if (item.id_preparat == null)
                                {
                                    id_produseM.Add((int)item.id_meniu);
                                }
                            }
                        }

                        foreach (var i in id_produseP)
                        {
                            foreach (var preparat in preparate)
                            {
                                if (preparat.idPreparat == i)
                                {
                                    produse.Add(preparat.denumire);
                                }
                            }
                        }

                        foreach (var i in id_produseM)
                        {
                            foreach (var meniu in meniuri)
                            {
                                if (meniu.id_meniu == i)
                                {
                                    produse.Add(meniu.denumire_meniu);
                                }
                            }
                        }

                        result.Add(new ComenzileMeleVM()
                        {
                            Id = comanda.id,
                            IdClient = id,
                            Stare = restaurant.GetStare(comanda.id_stare_comanda).ElementAt(0).ToString(),
                            Pret = comanda.pret,
                            DataComenzii = DateTime.Parse(comanda.data_comanda.ToString()).ToShortDateString(),
                            Cod = comanda.cod_comanda,
                            Produse = produse.ToList()
                        });
                        id_produseP.Clear();
                        id_produseM.Clear();
                        produse.Clear();

                    }
                    
                }
                
            }
            return result;
        }

        public void Anuleaza(object obj)
        {
            ComenzileMeleVM comenzileMeleVM = obj as ComenzileMeleVM;

            List<Item> items = restaurant.Items.ToList();
            List<Meniu_Preparat> meniuri_preparate = restaurant.Meniu_Preparat.ToList();
            List<int> id_produseP = new List<int>();
            List<int> id_produseM = new List<int>();

            if (comenzileMeleVM == null)
                MessageBox.Show("Va rugam selectati o comanda!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                restaurant.ModifyStareFaraOra(5, comenzileMeleVM.Id);
                foreach(var item in items)
                {
                    if(item.id_comanda== comenzileMeleVM.Id)
                    {
                        if (item.id_preparat != null)
                            id_produseP.Add((int)item.id_preparat);
                        else if (item.id_meniu != null)
                            id_produseM.Add((int)item.id_meniu);
                    }
                }

                foreach(var produs in id_produseP)
                {
                    restaurant.ModifyCantitateLaAnulare(produs);
                }

                id_produseP.Clear();

                foreach (var id_m in id_produseM)
                { 
                    foreach (var mp in meniuri_preparate)
                    {
                        if (mp.id_meinu == id_m)
                            id_produseP.Add(mp.id_preparat);
                    }
                }

                foreach (var produs in id_produseP)
                {
                    restaurant.ModifyCantitateLaAnulare(produs);
                }

                MessageBox.Show("Comanda a fost anulata cu succes!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
