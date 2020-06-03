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
    class SearchActions
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private SearchVM searchContext;

        public SearchActions(SearchVM searchVM)
        {
            this.searchContext = searchVM;
        }

        List<int> idPreparat = new List<int>();
        List<int> idMeniu = new List<int>();
        List<string> denumire_alergeni = new List<string>();
        List<string> denumire_alergeni_meniu = new List<string>();

        public ObservableCollection<SearchVM> Alergen(string cautare)
        {
            ObservableCollection<SearchVM> result = new ObservableCollection<SearchVM>();

            idPreparat.Clear();
            idMeniu.Clear();

            List<Preparat_Alergen> alergeni_preparat = restaurant.Preparat_Alergen.ToList();
            List<Alergen> alergeni = restaurant.Alergens.ToList();
            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();
            List<Meniu_Preparat> men_prep = restaurant.Meniu_Preparat.ToList();
            int id_alergen = -1;

            foreach (var alg in alergeni)
            {
                if (alg.denumire_alergen.Equals(cautare))
                    id_alergen = alg.id_alergen;

            }
            if (id_alergen == (-1))
            {
                MessageBox.Show("Acest alergen nu exista in lista noastra!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                return result;
            }

            foreach (var alg in alergeni_preparat)
            {
                if (alg.id_alergen == id_alergen)
                {
                    idPreparat.Add(alg.id_preparat);
                }
            }

            foreach (var id_prep in idPreparat)
            {
                foreach (var prep in preparate)
                {
                    if (id_prep == prep.idPreparat)
                    {
                        denumire_alergeni = restaurant.GetDenumireAlergen(prep.idPreparat).ToList();
                        result.Add(new SearchVM()
                        {
                            Id = prep.idPreparat,
                            Categorie = restaurant.GetCategorie(prep.id_categorie).ElementAt(0).ToString().ToUpper(),
                            Denumire = prep.denumire,
                            Pret = prep.pret,
                            Cantitate = (int)prep.cantitate_per_portie,
                            Img = restaurant.ShowPictures(prep.idPreparat).ElementAt(0).ToString(),
                            ListAlergeni = restaurant.GetDenumireAlergen(prep.idPreparat).ToList()
                        
                        });
                    }
                    
                }
                foreach (var m_p in men_prep)
                {
                    if (id_prep == m_p.id_preparat )
                    {
                        if (idMeniu.Contains(m_p.id_meinu) != true)
                            idMeniu.Add(m_p.id_meinu);
                    }
                    
                }
            }

            int cantitate_meniu=0;

            foreach (var id_Meniu in idMeniu)
            {
                foreach (var meniu in meniuri)
                {
                    if (meniu.id_meniu == id_Meniu)
                    {
                        double pret = Double.Parse(restaurant.GetPretMeniu(meniu.id_meniu).ElementAt(0).ToString());
                        foreach(var init in restaurant.GetCantitateMeniu(meniu.id_meniu).ToList())
                        {
                            cantitate_meniu += (int)init - 80;
                        }

                        foreach(var init in restaurant.GetAlergeniMeniu(meniu.id_meniu).ToList())
                        {
                            if (init.Contains("nu contine alergeni") != true)
                                denumire_alergeni_meniu.Add(init);

                        }

                        result.Add(new SearchVM()
                        {
                            Id = meniu.id_meniu,
                            Categorie = restaurant.GetCategorie(meniu.id_categorie).ElementAt(0).ToString().ToUpper(),
                            Denumire = meniu.denumire_meniu,
                            Pret = pret-(pret * 15 / 100),
                            Cantitate = cantitate_meniu,
                            Img = meniu.fotografie,
                            ListAlergeni= denumire_alergeni_meniu.Distinct().ToList()
                        });
                    }
                }
            }
                searchContext.ListPreparate = result;
                return result;
        }

        List<int> idPreparatFaraAlergen = new List<int>();

        public ObservableCollection<SearchVM> Nu_Alergen(string cautare)
        {
            ObservableCollection<SearchVM> result = new ObservableCollection<SearchVM>();
            idPreparat.Clear();
            idMeniu.Clear();
            bool ok=false ;

            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu_Preparat> men_prep = restaurant.Meniu_Preparat.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();

            List<Alergen> alergeni = restaurant.Alergens.ToList();

            foreach(var alergen in alergeni)
            {
                if (alergen.denumire_alergen.Equals(cautare))
                    ok = true;
            }
            if(ok==false)
            {
                MessageBox.Show("Acest alergen nu exista in lista noastra!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

                return result;
            }

            foreach (var init in restaurant.GetIDPreparatFromAlergen(cautare))
            { 
                idPreparat.Add((int)init);
            }

            idPreparat = idPreparat.Distinct().ToList();

            foreach (var preparat in preparate)
            {
                ok = false;
                foreach(var init in idPreparat)
                {
                    if (preparat.idPreparat == init)
                    {
                        ok = true;
                        break;
                    }
                    
                }

                if(ok==false)
                {
                    idPreparatFaraAlergen.Add(preparat.idPreparat); //id-il acelor preparate care nu contin alergenul
                    denumire_alergeni = restaurant.GetDenumireAlergen(preparat.idPreparat).ToList();
                    result.Add(new SearchVM()
                    {
                        Id = preparat.idPreparat,
                        Categorie = restaurant.GetCategorie(preparat.id_categorie).ElementAt(0).ToString().ToUpper(),
                        Denumire = preparat.denumire,
                        Pret = preparat.pret,
                        Cantitate = (int)preparat.cantitate_per_portie,
                        Img = restaurant.ShowPictures(preparat.idPreparat).ElementAt(0).ToString(),
                        ListAlergeni = restaurant.GetDenumireAlergen(preparat.idPreparat).ToList()
                    });
                }
            }

            
           

            foreach (var m_p in men_prep)
            {
                ok = false;
                foreach (var i in restaurant.GetIDPreparat(m_p.id_meinu))
                {
                    if (idPreparatFaraAlergen.Contains((int)i)!=true)
                    {
                        ok = true;
                        break;
                    }
                }

                if (ok == false)
                {
                    if (idMeniu.Contains(m_p.id_meinu) != true)
                        idMeniu.Add(m_p.id_meinu);
                    
                }
            }

            int cantitate_meniu = 0;

            foreach (var id_Meniu in idMeniu)
            {
                foreach (var meniu in meniuri)
                {
                    if (meniu.id_meniu == id_Meniu)
                    {
                        double pret = Double.Parse(restaurant.GetPretMeniu(meniu.id_meniu).ElementAt(0).ToString());
                        foreach (var init in restaurant.GetCantitateMeniu(meniu.id_meniu).ToList())
                        {
                            cantitate_meniu += (int)init - 80;
                        }

                        foreach (var init in restaurant.GetAlergeniMeniu(meniu.id_meniu).ToList())
                        {
                            if (init.Contains("nu contine alergeni") != true)
                                denumire_alergeni_meniu.Add(init);

                        }

                        result.Add(new SearchVM()
                        {
                            Id = meniu.id_meniu,
                            Categorie = restaurant.GetCategorie(meniu.id_categorie).ElementAt(0).ToString().ToUpper(),
                            Denumire = meniu.denumire_meniu,
                            Pret = pret - (pret * 15 / 100),
                            Cantitate = cantitate_meniu,
                            Img = meniu.fotografie,
                            ListAlergeni = denumire_alergeni_meniu.Distinct().ToList()
                        });
                    }
                }
            }

            searchContext.ListPreparate = result;
            return result;
        }

        public ObservableCollection<SearchVM> Ingredient(string cautare)
        {
            ObservableCollection<SearchVM> result = new ObservableCollection<SearchVM>();
            idPreparat.Clear();
            idMeniu.Clear();

            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu_Preparat> men_prep = restaurant.Meniu_Preparat.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();

            foreach (Preparat preparat in preparate)
            {
                if(preparat.denumire.ToUpper().Contains(cautare.ToUpper()))
                {
                    denumire_alergeni = restaurant.GetDenumireAlergen(preparat.idPreparat).ToList();
                    result.Add(new SearchVM()
                    {
                        Id = preparat.idPreparat,
                        Categorie = restaurant.GetCategorie(preparat.id_categorie).ElementAt(0).ToString().ToUpper(),
                        Denumire = preparat.denumire,
                        Pret = preparat.pret,
                        Cantitate = (int)preparat.cantitate_per_portie,
                        Img = restaurant.ShowPictures(preparat.idPreparat).ElementAt(0).ToString(),
                        ListAlergeni = restaurant.GetDenumireAlergen(preparat.idPreparat).ToList()

                    });
                    foreach (var m_p in men_prep)
                    {
                        if (preparat.idPreparat == m_p.id_preparat)
                        {
                            if (idMeniu.Contains(m_p.id_meinu) != true)
                                idMeniu.Add(m_p.id_meinu);
                        }

                    }
                }
            }

            int cantitate_meniu = 0;

            foreach (var id_Meniu in idMeniu)
            {
                foreach (var meniu in meniuri)
                {
                    if (meniu.id_meniu == id_Meniu)
                    {
                        double pret = Double.Parse(restaurant.GetPretMeniu(meniu.id_meniu).ElementAt(0).ToString());
                        foreach (var init in restaurant.GetCantitateMeniu(meniu.id_meniu).ToList())
                        {
                            cantitate_meniu += (int)init - 80;
                        }

                        foreach (var init in restaurant.GetAlergeniMeniu(meniu.id_meniu).ToList())
                        {
                            if (init.Contains("nu contine alergeni") != true)
                                denumire_alergeni_meniu.Add(init);

                        }

                        result.Add(new SearchVM()
                        {
                            Id = meniu.id_meniu,
                            Categorie = restaurant.GetCategorie(meniu.id_categorie).ElementAt(0).ToString().ToUpper(),
                            Denumire = meniu.denumire_meniu,
                            Pret = pret - (pret * 15 / 100),
                            Cantitate = cantitate_meniu,
                            Img = meniu.fotografie,
                            ListAlergeni = denumire_alergeni_meniu.Distinct().ToList()
                        });
                    }
                }
            }
            searchContext.ListPreparate = result;
            return result;
        }

        public ObservableCollection<SearchVM> Nu_Incredient(string cautare)
        {
            ObservableCollection<SearchVM> result = new ObservableCollection<SearchVM>();
            idPreparat.Clear();
            idMeniu.Clear();
            bool ok;
            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu_Preparat> men_prep = restaurant.Meniu_Preparat.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();

            foreach (Preparat preparat in preparate)
            {
                if (preparat.denumire.ToUpper().Contains(cautare.ToUpper())!=true)
                {
                    idPreparat.Add(preparat.idPreparat); //id-urile preparatelor care nu contin cuvantul
                    denumire_alergeni = restaurant.GetDenumireAlergen(preparat.idPreparat).ToList();
                    result.Add(new SearchVM()
                    {
                        Id = preparat.idPreparat,
                        Categorie = restaurant.GetCategorie(preparat.id_categorie).ElementAt(0).ToString().ToUpper(),
                        Denumire = preparat.denumire,
                        Pret = preparat.pret,
                        Cantitate = (int)preparat.cantitate_per_portie,
                        Img = restaurant.ShowPictures(preparat.idPreparat).ElementAt(0).ToString(),
                        ListAlergeni = restaurant.GetDenumireAlergen(preparat.idPreparat).ToList()

                    });
                }
            }


            foreach (var m_p in men_prep)
            {
                ok = false;
                foreach (var i in restaurant.GetIDPreparat(m_p.id_meinu))
                {
                    if (idPreparat.Contains((int)i) != true)
                    {
                        ok = true;
                        break;
                    }
                }

                if (ok == false)
                {
                    if (idMeniu.Contains(m_p.id_meinu) != true)
                        idMeniu.Add(m_p.id_meinu);

                }
            }

            int cantitate_meniu = 0;

            foreach (var id_Meniu in idMeniu)
            {
                foreach (var meniu in meniuri)
                {
                    if (meniu.id_meniu == id_Meniu)
                    {
                        double pret = Double.Parse(restaurant.GetPretMeniu(meniu.id_meniu).ElementAt(0).ToString());
                        foreach (var init in restaurant.GetCantitateMeniu(meniu.id_meniu).ToList())
                        {
                            cantitate_meniu += (int)init - 80;
                        }

                        foreach (var init in restaurant.GetAlergeniMeniu(meniu.id_meniu).ToList())
                        {
                            if (init.Contains("nu contine alergeni") != true)
                                denumire_alergeni_meniu.Add(init);

                        }

                        result.Add(new SearchVM()
                        {
                            Id = meniu.id_meniu,
                            Categorie = restaurant.GetCategorie(meniu.id_categorie).ElementAt(0).ToString().ToUpper(),
                            Denumire = meniu.denumire_meniu,
                            Pret = pret - (pret * 15 / 100),
                            Cantitate = cantitate_meniu,
                            Img = meniu.fotografie,
                            ListAlergeni = denumire_alergeni_meniu.Distinct().ToList()
                        });
                    }
                }
            }

            searchContext.ListPreparate = result;
            return result;
        }
    }
}
