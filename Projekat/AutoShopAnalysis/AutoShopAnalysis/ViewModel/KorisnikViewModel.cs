using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AutoShopAnalysis.ViewModel
{
    public class KorisnikViewModel: INotifyPropertyChanged
    {
        string ime;
        public string Ime { get { return ime; } set { ime = value; OnPropertyChanged("Ime"); } }
        string prezime;
        public string Prezime { get { return prezime; } set { prezime = value; OnPropertyChanged("Prezime"); } }
        string username;
        public string Username { get { return username; } set { username = value; OnPropertyChanged("Username"); } }
        string password;
        public string Password { get { return password; } set { password = value; OnPropertyChanged("Password"); } }
        string email;
        public string Email { get { return email; } set { email = value; OnPropertyChanged("Email"); } }
        string telefon;
        public string Telefon { get { return telefon; } set { telefon = value; OnPropertyChanged("Telefon"); } }



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
