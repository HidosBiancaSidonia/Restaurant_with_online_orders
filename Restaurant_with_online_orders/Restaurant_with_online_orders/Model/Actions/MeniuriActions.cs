using Restaurant_with_online_orders.ViewModel;
using Restaurant_with_online_orders.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Objects;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;

namespace Restaurant_with_online_orders.Model.Actions
{
    class MeniuriActions
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private MeniuriVM meniuriContext;

        public MeniuriActions(MeniuriVM meniuriVM)
        {
            this.meniuriContext = meniuriVM;
        }
        public MeniuriActions()
        { }

        private List<string> nume_preparate = new List<string>();
      

        public ObservableCollection<MeniuriVM> AllMeniuri(int id)
        {
            List<Meniu> meniuri = restaurant.Menius.ToList();
            List<Preparat> preparate = restaurant.Preparats.ToList();
            ObservableCollection<MeniuriVM> result = new ObservableCollection<MeniuriVM>();
            foreach (Meniu meniu in meniuri)
            {
                double pret = 0;
                int cantitate = 0;
                foreach (var i in restaurant.GetIDPreparat(meniu.id_meniu).ToList())
                {
                    foreach (Preparat prep in preparate)
                    {
                        if (i == prep.idPreparat)
                        {
                            pret += prep.pret;
                            cantitate += (int)prep.cantitate_per_portie;
                        }
                    }
                }
                Double discount = pret - (pret * 15 / 100);
                int cant = cantitate - (cantitate * 20 / 100);

                result.Add(new MeniuriVM()
                {
                    IdClient=id,
                    IdMeniu = meniu.id_meniu,
                    DenumireMeniu = meniu.denumire_meniu,
                    ImgMeniu = meniu.fotografie,
                    PretMeniu = discount,
                    CantitateMeniu = cant,
                    //Continut = nume_preparate
                });
                
            }
            meniuriContext.ListMeniuri = result;
            return result;
        }

        List<string> cantitateM = new List<string>();
        List<int> cantitateT = new List<int>();

        public void Detalii(object obj)
        {
            MeniuriVM meniuriVM = obj as MeniuriVM;
            
            List<Preparat> preparate = restaurant.Preparats.ToList();
            if (meniuriVM == null)
                MessageBox.Show("Va rugam selectati un preparat!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                nume_preparate.Clear();
                cantitateM.Clear();
                foreach (var i in restaurant.GetIDPreparat(meniuriVM.IdMeniu).ToList())
                {
                    foreach (Preparat prep in preparate)
                    {
                        if (i == prep.idPreparat)

                        {
                            nume_preparate.Add(prep.denumire);
                            cantitateM.Add(((int)prep.cantitate_per_portie - 80).ToString()+" gr");
                            cantitateT.Add((int)prep.cantitatea_totala);
                        }
                    }
                }
                meniuriVM.Continut = nume_preparate;
                meniuriVM.Gramaj = cantitateM;
                meniuriVM.CantitateTotala = cantitateT;
            }
        }

        public List<object> item = new List<object>();
        public void AdaugaLaCom(object obj)
        {
            MeniuriVM meniuriVM = obj as MeniuriVM;
            int ok = 0;
            if (meniuriVM == null)
                MessageBox.Show("Va rugam selectati un preparat!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            else
            {
                foreach (var i in meniuriVM.CantitateTotala)
                {
                    if (i <= 0)
                        ok = 1;
                }
                if (ok == 0)
                {
                    Double pret = (Double)restaurant.GetPretFromPreparat(meniuriVM.IdMeniu).ElementAt(0);
                    int cantitate = (int)restaurant.GetCantitateFromPreparat(meniuriVM.IdMeniu).ElementAt(0);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"..\..\Comanda.txt", @"..\..\Comanda.txt"), true))
                    {
                        outputFile.WriteLine(meniuriVM.IdClient + "," + meniuriVM.IdMeniu + "," + meniuriVM.DenumireMeniu + "," + (pret - (pret * 15 / 100))+ "," + (cantitate - (cantitate * 20 / 100)) + ","+ 2);
                    }
                    MessageBox.Show("Ati adaugat preparatul cu succes la comanda!", "Warning", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Momentan acest meniu nu se mai gaseste la noi!\nNe vom aproviziona cat de curand posibil!\nMultumim pentru neintelegeri!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
