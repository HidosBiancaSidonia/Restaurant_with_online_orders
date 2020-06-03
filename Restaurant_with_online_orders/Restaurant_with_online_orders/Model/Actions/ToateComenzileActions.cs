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
    class ToateComenzileActions
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private ToateComenzileVM toateComenzileContext;

        public ToateComenzileActions(ToateComenzileVM toateComenzileVM)
        {
            this.toateComenzileContext = toateComenzileVM;
        }

        public ObservableCollection<ToateComenzileVM> Get()
        {
            ObservableCollection<ToateComenzileVM> result = new ObservableCollection<ToateComenzileVM>();
            List<Item> items = restaurant.Items.ToList();
            List<int> id_produseP = new List<int>();
            List<int> id_produseM = new List<int>();
            List<string> produse = new List<string>();
            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();
            List<Cont_utilizator> utilizatori = restaurant.Cont_utilizator.ToList();

            foreach (var i in restaurant.ComenzileDescrescator().ToList())
            {
                id_produseP.Clear();
                id_produseM.Clear();
                produse.Clear();
                string ora = "-";
                if (i.ora_livrare != null)
                {
                    ora = DateTime.Parse(i.ora_livrare.ToString()).ToShortTimeString();
                }

                foreach (var item in items)
                {
                    if (item.id_comanda == i.id)
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


                foreach (var j in id_produseP)
                {
                    foreach (var preparat in preparate)
                    {
                        if (preparat.idPreparat == j)
                        {
                            produse.Add(preparat.denumire);
                        }
                    }
                }

                foreach (var j in id_produseM)
                {
                    foreach (var meniu in meniuri)
                    {
                        if (meniu.id_meniu == j)
                        {
                            produse.Add(meniu.denumire_meniu);
                        }
                    }
                }

                result.Add(new ToateComenzileVM()
                {
                    Id_Comanda = i.id,
                    DataComenzii = DateTime.Parse(i.data_comanda.ToString()).ToShortDateString(),
                    OraLivrarii = ora,
                    Stare = restaurant.GetStare(i.id_stare_comanda).ElementAt(0).ToString(),
                    Cod = i.cod_comanda,
                    Pret = i.pret,
                    Produse = produse.ToList(),
                    Id_Client = i.id_utilizator,
                    Nume = restaurant.GetNume(i.id_utilizator).ElementAt(0).ToString(),
                    Prenume = restaurant.GetPrenume(i.id_utilizator).ElementAt(0).ToString(),
                    Adresa = restaurant.GetAdresa(i.id_utilizator).ElementAt(0).ToString(),
                    Nr_Telefon = restaurant.GetTelefon(i.id_utilizator).ElementAt(0).ToString()

                });
                id_produseP.Clear();
                id_produseM.Clear();
                produse.Clear();
            }

            return result;
        }

        public ObservableCollection<ToateComenzileVM> GetActive()
        {
            ObservableCollection<ToateComenzileVM> result = new ObservableCollection<ToateComenzileVM>();
            List<Item> items = restaurant.Items.ToList();
            List<int> id_produseP = new List<int>();
            List<int> id_produseM = new List<int>();
            List<string> produse = new List<string>();
            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();
            List<Cont_utilizator> utilizatori = restaurant.Cont_utilizator.ToList();


            foreach (var i in restaurant.ComenzileDescrescator().ToList())
            {
                if ((i.id_stare_comanda != 4) && (i.id_stare_comanda != 5))
                {
                    id_produseP.Clear();
                    id_produseM.Clear();
                    produse.Clear();

                    foreach (var item in items)
                    {
                        if (item.id_comanda == i.id)
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


                    foreach (var j in id_produseP)
                    {
                        foreach (var preparat in preparate)
                        {
                            if (preparat.idPreparat == j)
                            {
                                produse.Add(preparat.denumire);
                            }
                        }
                    }

                    foreach (var j in id_produseM)
                    {
                        foreach (var meniu in meniuri)
                        {
                            if (meniu.id_meniu == j)
                            {
                                produse.Add(meniu.denumire_meniu);
                            }
                        }
                    }

                    result.Add(new ToateComenzileVM()
                    {
                        Id_Comanda = i.id,
                        DataComenzii = DateTime.Parse(i.data_comanda.ToString()).ToShortDateString(),
                        Stare = restaurant.GetStare(i.id_stare_comanda).ElementAt(0).ToString(),
                        Cod = i.cod_comanda,
                        Pret = i.pret,
                        Produse = produse.ToList(),
                        Id_Client = i.id_utilizator,
                        Nume = restaurant.GetNume(i.id_utilizator).ElementAt(0).ToString(),
                        Prenume = restaurant.GetPrenume(i.id_utilizator).ElementAt(0).ToString(),
                        Adresa = restaurant.GetAdresa(i.id_utilizator).ElementAt(0).ToString(),
                        Nr_Telefon = restaurant.GetTelefon(i.id_utilizator).ElementAt(0).ToString()

                    });
                    id_produseP.Clear();
                    id_produseM.Clear();
                    produse.Clear();
                }
            }
            return result;
        }

        public void Modify(object obj)
        {
            ToateComenzileVM toateVM = obj as ToateComenzileVM;

            List<Stare_Comanda> stari = restaurant.Stare_Comanda.ToList();
            int id_stare = 0;

            if (toateVM != null)
            {
                foreach(Stare_Comanda stare in stari)
                {
                    if (toateVM.Stare == stare.denumire_stare)
                    {
                        id_stare = stare.id_stare;
                    }
                }
                if (id_stare == 4)
                { restaurant.ModifyStare(id_stare, Int32.Parse(toateVM.Id), DateTime.Now.ToUniversalTime()); }
                else
                {
                    restaurant.ModifyStareFaraOra(id_stare, Int32.Parse(toateVM.Id));
                }

                MessageBox.Show("Modificarea s-a realizat cu succes!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Nu ati selectat o comanda sau o stare!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
