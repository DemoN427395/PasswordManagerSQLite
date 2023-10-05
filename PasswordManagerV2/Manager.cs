using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace PasswordManagerV2
{
    public class Manager : INotifyPropertyChanged
    {
        private string service;

        private string login;

        private string password;



        public int Id { get; set; }



        public string Service

        {

            get { return service; }

            set

            {

                service = value;

                OnPropertyChanged("Service");

            }

        }

        public string Login

        {

            get { return login; }

            set

            {

                login = value;

                OnPropertyChanged("Login");

            }

        }

        public string Password

        {

            get { return password; }

            set

            {

                password = value;

                OnPropertyChanged("Password");

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")

        {

            if (PropertyChanged != null)

                PropertyChanged(this, new PropertyChangedEventArgs(prop));

        }
    }
}
