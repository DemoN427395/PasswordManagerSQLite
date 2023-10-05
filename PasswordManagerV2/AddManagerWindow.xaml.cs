using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace PasswordManagerV2
{
    /// <summary>
    /// Логика взаимодействия для AddManagerWindow.xaml
    /// </summary>
    public partial class AddManagerWindow : Window
    {
        
        public Manager Manager { get; private set; }
        public AddManagerWindow(Manager m)
        {
            InitializeComponent();
            Manager = m;
            this.DataContext = Manager;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
