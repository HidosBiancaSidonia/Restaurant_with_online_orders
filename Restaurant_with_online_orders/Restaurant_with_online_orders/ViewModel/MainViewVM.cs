using Restaurant_with_online_orders.Utilities;
using Restaurant_with_online_orders.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Restaurant_with_online_orders.ViewModel
{
    class MainViewVM
    {
        private ICommand openWindowCommand;
        public ICommand OpenWindowCommand
        {
            get
            {
                if (openWindowCommand == null)
                    openWindowCommand = new RelayCommand(OpenWindow);

                return openWindowCommand;
            }
        }

        public void OpenWindow(object obj)
        {
            string nr = obj as string;
            switch (nr)
            {
                case "1":
                    Meniu menu = new Meniu();
                    menu.ShowDialog();

                    break;
                case "2":
                    Search search = new Search();
                    search.ShowDialog();
                    break;
                case "3":
                    
                    LogIn logIn = new LogIn();
                    logIn.ShowDialog();
                    
                    break;
                case "4":
                    NewUser newUser = new NewUser();
                    newUser.ShowDialog();
                    break;
            }
        }
    }
}
