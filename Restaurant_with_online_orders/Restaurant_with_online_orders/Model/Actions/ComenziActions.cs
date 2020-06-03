using Restaurant_with_online_orders.View;
using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Restaurant_with_online_orders.Model.Actions
{
    class ComenziActions
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private ComenziVM comenziContext;
        private PreparateActions prepAction=new PreparateActions();
        private MeniuriActions menAction=new MeniuriActions();
        public ComenziActions(ComenziVM comenziVM)
        {
            this.comenziContext = comenziVM;
        }

        public void CosCumparaturi(object obj)
        {
            
            if (File.ReadLines(@"..\..\..\Comanda.txt").Any(line => line.Contains(",")))
            {
                Cos cos = new Cos();
                cos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nu ati adaugat nimic la comanda!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

        }

        public ObservableCollection<ComenziVM> GetCos()
        {
            ObservableCollection<ComenziVM> result = new ObservableCollection<ComenziVM>();
            double pretT = 0;
            string[] lines = File.ReadAllLines(@"..\..\..\Comanda.txt");
            foreach (var it in lines)
            {
                if (it != "")
                {
                    string[] words = it.Split(',');
                    pretT += Double.Parse(words[3]);
                    result.Add(new ComenziVM()
                    {
                        IdClient = Int32.Parse(words[0]),
                        Id = Int32.Parse(words[1]),
                        Denumire = words[2],
                        Pret = Double.Parse(words[3]),
                        Cantitate = Int32.Parse(words[4]),
                        PretTotal = pretT
                    });
                }
            }

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"..\..\PretTotal.txt", @"..\..\PretTotal.txt"), true))
            {
                outputFile.WriteLine(pretT);
            }

            return result;
        }

        public void GetPretCuDiscount()
        {
            string[] lines = File.ReadAllLines(@"..\..\..\PretTotal.txt");
            if(Double.Parse(lines[0])>=200)
            {
                if (Double.Parse(lines[0]) - (Double.Parse(lines[0]) * 10 / 100) < 80)
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"..\..\PretCuDiscount.txt", @"..\..\PretCuDiscount.txt"), true))
                    {
                        outputFile.WriteLine(Double.Parse(lines[0]) - (Double.Parse(lines[0]) * 10 / 100)+15);
                    }
                }
                else 
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"..\..\PretCuDiscount.txt", @"..\..\PretCuDiscount.txt"), true))
                    {
                        outputFile.WriteLine(Double.Parse(lines[0]) - (Double.Parse(lines[0]) * 10 / 100));
                    }
                }
            }
            else
            {
                if(Double.Parse(lines[0])<80)
                { 
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"..\..\PretCuDiscount.txt", @"..\..\PretCuDiscount.txt"), true))
                    {
                        outputFile.WriteLine(Double.Parse(lines[0])+15);
                    } 
                }
                else
                {
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"..\..\PretCuDiscount.txt", @"..\..\PretCuDiscount.txt"), true))
                    {
                        outputFile.WriteLine(Double.Parse(lines[0]) );
                    }
                }
            }
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }


        public void Comanda(object obj)
        {
            
            string[] lines = File.ReadAllLines(@"..\..\..\Comanda.txt");
            string[] lines1 = File.ReadAllLines(@"..\..\..\PretCuDiscount.txt");
            string str = RandomString(5, true);

            foreach (var it in lines)
            {
                if (it != "")
                {
                    string[] words = it.Split(',');
                    restaurant.AddComanda(Int32.Parse(words[0]), 1, Double.Parse(lines1[0]),DateTime.Now.Date,str);
                }
                break;
            }

            List<Comanda> comenzi = restaurant.Comandas.ToList();
            List<int> id_prep = new List<int>();
            List<int> id = new List<int>();
            int id_comanda=0;
            foreach(var comanda in comenzi)
            {
                id.Add(comanda.id);
            }

            id_comanda = id.Max();

            foreach (var it in lines)
            {
                if (it != "")
                {
                    string[] words = it.Split(',');
                    if(Int32.Parse(words[5])==1)
                    {
                        restaurant.AddPreparatForComands(Int32.Parse(words[1]), id_comanda);
                        restaurant.ModifyCantitatePreparat(Int32.Parse(words[1]), Int32.Parse(words[4]));
                    }
                    else if(Int32.Parse(words[5]) == 2)
                    {
                        restaurant.AddMeniuForComands(Int32.Parse(words[1]), id_comanda);
                        foreach(var i in restaurant.GetIdPreparatFromPM(Int32.Parse(words[1])).ToList())
                        {
                            int cantitate = Int32.Parse(restaurant.GetCantitate(i).ToString());
                            restaurant.ModifyCantitatePreparat((int)i, cantitate);
                        }
                    }
                }
            }
           
            MessageBox.Show("Comanda dumneavoastra s-a realizat cu succes!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            if (File.Exists(@"..\..\..\Comanda.txt"))
                File.Delete(@"..\..\..\Comanda.txt");
        }
    }
}
