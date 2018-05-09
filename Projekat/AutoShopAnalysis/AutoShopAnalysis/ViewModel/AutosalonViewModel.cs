using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AutoShopAnalysis.ViewModel
{
    public class AutosalonViewModel: INotifyPropertyChanged
    {
        string naziv;
        public string Naziv { get { return naziv; } set { naziv = value; OnPropertyChanged("Naziv"); } }
        string username;
        public string Username { get { return username; } set { username = value; OnPropertyChanged("Username"); } }
        string password;
        public string Password { get { return password; } set { password = value; OnPropertyChanged("Password"); } }
        string adresa;
        public string Adresa { get { return adresa; } set { adresa = value; OnPropertyChanged("Adresa"); } }
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
