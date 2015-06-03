using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Warehouse.Model;
using Warehouse.View;

namespace Warehouse.ViewModel
{
    class LogInViewModel
    {
        public ICommand LogIn
        {
            get
            {
                return new DelegateCommand(logIn);
            }
        }
        public ICommand Exit
        {
            get
            {
                return new DelegateCommand(Application.Current.MainWindow.Close);
            }
        }

        private static List<User_Inf> getUsers()
        {

            var contex = new WarehouseEntities();
            var users = contex.User_Inf.ToList();
            return users;
        }

        private void logIn()
        {
            AdministratorWindow adm = new AdministratorWindow();
            //adm.Show();
            var users = getUsers();
            var user = users.SingleOrDefault(x => x.login == ((LogIn)Application.Current.MainWindow).txtLogIn.Text
                && x.password == ((LogIn)Application.Current.MainWindow).txtPass.Password);
            if (user != null)
            {
                MessageBox.Show("Логин:"+user.login + "\n" + user.Users.family + user.Users.name + user.Users.patronymic + "\n" + user.Users.Role.name);
                Application.Current.MainWindow.Close();
                adm.Show();
            }
            else
            {
                MessageBox.Show("Доступ запрещен!");
                //Application.Current.MainWindow.Close();    
            }
        }

    }
}
