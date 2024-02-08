using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PasswordManagerV2
{
    public partial class MainWindow : Window
    {
        AppContext db;
        public MainWindow()
        {
            InitializeComponent();

            db = new AppContext();

            db.Managers.Load();

            this.DataContext = db.Managers.Local.ToBindingList();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddManagerWindow managerWindow = new AddManagerWindow(new Manager());

            if (managerWindow.ShowDialog() == true)
            {

                Manager manager = managerWindow.Manager;

                db.Managers.Add(manager);

                db.SaveChanges();

            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (passwordsList.SelectedItem == null) return;

            Manager manager = passwordsList.SelectedItem as Manager;
            AddManagerWindow managerWindow = new AddManagerWindow(new Manager

            {

                Id = manager.Id,

                Service = manager.Service,

                Login = manager.Login,

                Password = manager.Password

            });



            if (managerWindow.ShowDialog() == true)

            {


                manager = db.Managers.Find(managerWindow.Manager.Id);

                if (manager != null)

                {

                    manager.Service = managerWindow.Manager.Service;

                    manager.Login = managerWindow.Manager.Login;

                    manager.Password = managerWindow.Manager.Password;

                    db.Entry(manager).State = EntityState.Modified;

                    db.SaveChanges();

                }

            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (passwordsList.SelectedItem == null) return;

            Manager manager = passwordsList.SelectedItem as Manager;

            db.Managers.Remove(manager);

            db.SaveChanges();
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            if (passwordsList.SelectedItem == null) return; 
            Manager manager = passwordsList.SelectedItem as Manager; 
            string output = manager.Password; 
            System.Windows.Clipboard.SetText(output);
        }
    }
}
