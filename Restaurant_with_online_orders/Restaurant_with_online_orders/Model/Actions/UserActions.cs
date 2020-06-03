using Restaurant_with_online_orders.View;
using Restaurant_with_online_orders.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Restaurant_with_online_orders.Model.Actions
{
    class UserActions
    {
        RestaurantEntities restaurant = new RestaurantEntities();
        private UserVM userContext;

        public UserActions(UserVM userVM)
        {
            this.userContext = userVM;
        }

        public void AddMethod(object obj)
        {
            UserVM userVM = obj as UserVM;
            if (userVM != null)
            {
                var current = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
               
                    if (String.IsNullOrEmpty(userVM.Nume))
                    {
                        MessageBox.Show("Va rugam completati toate campurile!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                    else
                    {
                        restaurant.AddClient(userVM.Nume, userVM.Prenume, userVM.Nr_telefon, userVM.Adresa, userVM.Email, userVM.Parola.ToString()
                                               , userVM.Type = 1);
                        restaurant.SaveChanges();
                        userContext.UserList = AllUsers();
                        MessageBox.Show("Crearea contului s-a realizat cu succes!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                        LogIn logIn = new LogIn();
                        logIn.Show();
                        current.Close();
                    }
                
                
            }
        }

        public void LogInMethod(object obj)
        {
            UserVM userVM = obj as UserVM;
            var current = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);
            if (userVM != null)
            {
                if (String.IsNullOrEmpty(userVM.Email) && String.IsNullOrEmpty(userVM.Parola))
                {
                    MessageBox.Show("Va rugam completati toate campurile!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
                else
                {
                    if (HasUser(userVM.Email, userVM.Parola) == false)
                        MessageBox.Show("Ati gresit adresa de email sau parola!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    else 
                    {
                        userVM.Type = (int)restaurant.GetUserType(userVM.Email).ToList().ElementAt(0);
                        userVM.IdUser = (int)restaurant.GetUserId(userVM.Email).ToList().ElementAt(0);
                        if (userVM.Type == 1)
                        {
                            MainWindow main = new MainWindow(userVM.IdUser,userVM.Email);
                            main.ShowDialog();
                            current.Close();
                        }
                        else
                        {
                            Angajat angajat = new Angajat();
                            angajat.ShowDialog();
                            current.Close();
                        }
                    }
                }
            }
        }

        public bool HasUser(string user, string pass)
        {
            return restaurant.Cont_utilizator.Where(u => u.email == user && u.parola == pass).Count() == 1;
        }

        public ObservableCollection<UserVM> AllUsers()
        {
            List<Cont_utilizator> users = restaurant.Cont_utilizator.ToList();
            ObservableCollection<UserVM> result = new ObservableCollection<UserVM>();
            foreach (Cont_utilizator user in users)
            {
                result.Add(new UserVM()
                {
                    IdUser = user.idUser,
                    Nume = user.nume,
                    Prenume = user.prenume,
                    Email = user.adresa,
                    Parola = user.parola,
                    Adresa = user.adresa,
                    Nr_telefon = user.nr_tel,
                    Type = 1
                });
            }
            return result;
        }
    }
}
