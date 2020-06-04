using Restaurant_with_online_orders.ViewModel;
using Restaurant_with_online_orders.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;

namespace Restaurant_with_online_orders.Model.Actions
{
    class AngajatActions
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private AngajatVM angajatContext;

        public AngajatActions(AngajatVM angajatVM)
        {
            this.angajatContext = angajatVM;
        }

        List<int> idPreparat = new List<int>();
        List<int> idMeniu = new List<int>();
        List<string> denumire_alergeni = new List<string>();
        List<string> denumire_alergeni_meniu = new List<string>();
        public ObservableCollection<AngajatVM> Preparate()
        {
            string cautare = "bananeeeee";
            ObservableCollection<AngajatVM> result = new ObservableCollection<AngajatVM>();
            idPreparat.Clear();
            idMeniu.Clear();
            bool ok;
            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Meniu_Preparat> men_prep = restaurant.Meniu_Preparat.ToList();
            List<Meniu> meniuri = restaurant.Menius.ToList();

            foreach (Preparat preparat in preparate)
            {
                if (preparat.denumire.ToUpper().Contains(cautare.ToUpper()) != true)
                {
                    idPreparat.Add(preparat.idPreparat); //id-urile preparatelor care nu contin cuvantul
                    denumire_alergeni = restaurant.GetDenumireAlergen(preparat.idPreparat).ToList();
                    result.Add(new AngajatVM()
                    {
                        IdPreparat = preparat.idPreparat,
                        Categorie = restaurant.GetCategorie(preparat.id_categorie).ElementAt(0).ToString().ToUpper(),
                        Denumire = preparat.denumire,
                        Pret = preparat.pret,
                        CantitatePortie = (int)preparat.cantitate_per_portie,
                        CantitateTotala= (int)preparat.cantitatea_totala,
                        Fotografie = restaurant.ShowPictures(preparat.idPreparat).ElementAt(0).ToString(),
                        Alergeni = restaurant.GetDenumireAlergen(preparat.idPreparat).ToList()

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

                        result.Add(new AngajatVM()
                        {
                            IdPreparat = meniu.id_meniu,
                            Categorie = restaurant.GetCategorie(meniu.id_categorie).ElementAt(0).ToString().ToUpper(),
                            Denumire = meniu.denumire_meniu,
                            Pret = pret - (pret * 15 / 100),
                            CantitatePortie = cantitate_meniu,
                            Fotografie = meniu.fotografie,
                            Alergeni = denumire_alergeni_meniu.Distinct().ToList()
                        });
                    }
                }
            }
            return result;
        }

        public void AddMethod(object obj)
        {
            AngajatVM angajatVM = obj as AngajatVM;
            List<string> alg = new List<string>();
            List<Categorie_preparat> categorii = restaurant.Categorie_preparat.ToList();
            List<Preparat> preparate = restaurant.Preparats.ToList();
            List<Alergen> alergeni = restaurant.Alergens.ToList();

            if (angajatVM != null)
            {
                foreach(var alergen in angajatVM.Alergeni)
                {
                    if (alergen != "")
                        alg.Add(alergen);
                }
                if(alg.Count()!=0 )
                {
                    int id_categorie = 0;
                    foreach (var categorie in categorii)
                    {
                        if (angajatVM.Categorie.ToLower() == categorie.tip_preparat)
                            id_categorie = categorie.id;
                    }

                    if (id_categorie != 0)
                    {
                        


                        if (Double.Parse(angajatVM.Pr.ToString()) >= 0)
                        {
                            if (Int32.Parse(angajatVM.CantitateP) >= 0 && Int32.Parse(angajatVM.CantitateP) >= 0)
                            {
                                restaurant.AddPreparat(angajatVM.Denumire, id_categorie, Double.Parse(angajatVM.Pr), Int32.Parse(angajatVM.CantitateP), Int32.Parse(angajatVM.CantitateT));
                                int id_preparat = 0;
                                List<Preparat> preparatele = restaurant.Preparats.ToList();
                                foreach (var preparat in preparatele)
                                {
                                    id_preparat = preparat.idPreparat;
                                }

                                foreach (var aleg in angajatVM.Alergeni)
                                {
                                    foreach (var alergen in alergeni)
                                    {
                                        if (aleg == alergen.denumire_alergen)
                                        {

                                            restaurant.AddPreparat_Alergen(id_preparat, alergen.id_alergen);
                                        }
                                    }
                                }
                                restaurant.AddFotografie(id_preparat, angajatVM.Fotografie);
                                MessageBox.Show("Ati adaugat cu succes produsul!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                            }
                            else
                            {
                                MessageBox.Show("Va rugam sa bagati cantitati valide nenegative!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Va rugam sa bagati un pret valid!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Aceasta categorie nu exista, va rugam introduceti o categorie valida!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Va rugam selectati daca contine sau nu alergeni preparatul!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Va rugam introduceti date in toate casutele!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }

        public List<string> TotiAlergenii()
        {
            List<string> alg=new List<string>();
            List<Alergen> alergeni = restaurant.Alergens.ToList();
            foreach(var alergen in alergeni)
            {
                alg.Add(alergen.denumire_alergen);
            }
            return alg;
        }

        public void DeleteMethod(object obj)
        {
            AngajatVM angajatVM = obj as AngajatVM;
            List<Meniu_Preparat> meniu_preparate = restaurant.Meniu_Preparat.ToList();
            List<int> id = new List<int>();

            if (angajatVM != null)
            {
                if (angajatVM.Categorie.ToLower() == "meniu")
                {
                    restaurant.DeleteMeniu_Preparat(angajatVM.IdPreparat);
                    restaurant.DeleteMeniu(angajatVM.IdPreparat);
                }
                else
                {
                    foreach (var mp in meniu_preparate)
                    {
                        if (mp.id_preparat == angajatVM.IdPreparat)
                            id.Add(mp.id_meinu);
                    }
                    restaurant.DeleteFotografie(angajatVM.IdPreparat);
                    restaurant.DeletePreparat_Alergen(angajatVM.IdPreparat);
                    restaurant.DeletePreparatMeniu(angajatVM.IdPreparat);
                    restaurant.DeletePreparat(angajatVM.IdPreparat);
                    foreach (var i in id)
                    {
                        restaurant.DeleteMeniu(i);
                    }

                }
                MessageBox.Show("Stergerea s-a realizat cu succes!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Va rugam selectati un preparat pentru a-l sterge!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }

        public void ModifyMethod(object obj)
        {
            AngajatVM angajatVM = obj as AngajatVM;
            if (angajatVM != null)
            {
                List<Categorie_preparat> categorii = restaurant.Categorie_preparat.ToList();
                List<Alergen> alergeni = restaurant.Alergens.ToList();
                List<int> id_alg = new List<int>();
                int id_categorie = 0;
                foreach (var categorie in categorii)
                {
                    if (angajatVM.Categorie.ToLower() == categorie.tip_preparat)
                        id_categorie = categorie.id;
                }

                if (id_categorie != 0)
                {

                    if (Double.Parse(angajatVM.Pr) >= 0 && Int32.Parse(angajatVM.CantitateP) >= 0 && Int32.Parse(angajatVM.CantitateT) >= 0)
                    {
                        if (angajatVM.Categorie == "meniu")
                        {
                            restaurant.ModifyMeniu(Int32.Parse(angajatVM.Id), angajatVM.Denumire, angajatVM.Fotografie, id_categorie);
                        }
                        else
                        {
                            restaurant.ModifyPreparat(Int32.Parse(angajatVM.Id), angajatVM.Denumire, Double.Parse(angajatVM.Pr)
                                , Int32.Parse(angajatVM.CantitateP), Int32.Parse(angajatVM.CantitateT), id_categorie);
                            restaurant.ModifyFotografie(Int32.Parse(angajatVM.Id), angajatVM.Fotografie);
                            if (angajatVM.Alergeni.Count() != 0)
                            {
                                restaurant.DeletePreparat_Alergen(Int32.Parse(angajatVM.Id));

                                foreach (var alg in angajatVM.Alergeni)
                                {
                                    foreach (var alergen in alergeni)
                                    {
                                        if (alg == alergen.denumire_alergen)
                                        {

                                            restaurant.AddPreparat_Alergen(Int32.Parse(angajatVM.Id), alergen.id_alergen);
                                        }
                                    }
                                }
                            }

                        }
                        MessageBox.Show("Modificarea s-a realizat cu succes!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    else
                    MessageBox.Show("Pretul sau cantitatile preparatului nu pot fi negative!\nVa rugam introduceti pret sau cantitati valide!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    MessageBox.Show("Aceasta categorie nu exista!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Va rugam selectati un preparat pentru a-l modifica!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);

            }
        }
    }
}
