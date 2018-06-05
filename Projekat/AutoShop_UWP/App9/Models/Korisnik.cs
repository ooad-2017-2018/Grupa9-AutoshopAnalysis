using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace App9.Model
{
    public class Korisnik: INotifyPropertyChanged
    {
        string ime;
        string prezime;
        string username;
        string password;
        string email;
        string telefon;
        BankovniRacun racun;

        public string Ime
        {
            get => ime;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Obavezan unos!");
                if (value.Any(c => !char.IsLetter(c)))
                    throw new Exception("Ime moze sadrzavati samo slova!");
                if (value.Substring(1, value.Length - 1).Any(c => char.IsUpper(c)))
                    throw new Exception("Samo prvo slovo imena moze biti veliko!");
                if (!char.IsUpper(value[0]))
                    throw new Exception("Prvo slovo imena mora biti veliko!");
                ime = value;
            }
        }

        public string Prezime
        {
            get => prezime;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Obavezan unos!");
                if (value.Any(c => !char.IsLetter(c)))
                    throw new Exception("Prezime moze sadrzavati samo slova!");
                if (value.Substring(1, value.Length - 1).Any(c => char.IsUpper(c)))
                    throw new Exception("Samo prvo slovo prezimena moze biti veliko!");
                if (!char.IsUpper(value[0]))
                    throw new Exception("Prvo slovo prezimena mora biti veliko!");
                prezime = value;
            }
        }

        public string Username
        {
            get => username;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Obavezan unos!");
                username = value;
            }
        }

        public string Password
        {
            get => password;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Obavezan unos!");
                password = value;
            }
        }

        public string Email
        {
            get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !System.Text.RegularExpressions.Regex.IsMatch(value, @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"))
                    throw new Exception("Pogresan unos!");
                email = value;
            }
        }

        public string Telefon
        {
            get => telefon;
            set
            {
                if (value.Length != 9)
                    throw new Exception("Pogresan unos");
                if (value.Substring(0, 3) != "033" || value.Substring(0, 3) != "061" || value.Substring(0, 3) != "062" || value.Substring(0, 3) != "063")
                    throw new Exception("Pogresan unos");
                if (value.Any(c => !char.IsNumber(c)))
                    throw new Exception("Pogresan unos");
                telefon = value;
            }
        }

        public BankovniRacun Racun { get => racun; set => racun = value; }

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
