using Restaurant_with_online_orders.Model.Actions;
using Restaurant_with_online_orders.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Restaurant_with_online_orders.ViewModel
{
    class UserVM : BaseVM
    {
        UserActions userActions;

        public UserVM()
        {
            userActions = new UserActions(this);
        }

        int idUser;
        private string nume;
        private string prenume;
        private string email;
        private string parola;
        private int type;
        private string nr_telefon;
        private string adresa;
        private ObservableCollection<UserVM> userList;

        public int IdUser
        {
            get
            {
                return idUser;
            }
            set
            {
                idUser = value;
                OnPropertyChanged("IdUser");
            }
        }
        public string Nume
        {
            get
            {
                return nume;
            }
            set
            {
                nume = value;
                OnPropertyChanged("Nume");
            }
        }
        public string Prenume
        {
            get
            {
                return prenume;
            }
            set
            {
                prenume = value;
                OnPropertyChanged("Prenume");
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public string Parola
        {
            get
            {
                return parola;
            }
            set
            {
                parola = value;
                OnPropertyChanged("Parola");
            }
        }
        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                OnPropertyChanged("Type");
            }
        }
        public string Nr_telefon
        {
            get
            {
                return nr_telefon;
            }
            set
            {
                nr_telefon = value;
                OnPropertyChanged("Nr_telefon");
            }
        }
        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                adresa = value;
                OnPropertyChanged("Adresa");
            }
        }

        public ObservableCollection<UserVM> UserList
        {
            get
            {
                return userList;
            }
            set
            {
                userList = value;
                OnPropertyChanged("UserList");
            }
        }

        private ICommand addClient;
        public ICommand AddClient
        {
            get
            {
                if (addClient == null)
                    addClient = new RelayCommand(userActions.AddMethod);
                return addClient;
            }
        }

        private ICommand logInCommand;
        public ICommand LogInCommand
        {
            get
            {
                if (logInCommand == null)
                    logInCommand = new RelayCommand(userActions.LogInMethod);
                return logInCommand;
            }
        }
    }
}
