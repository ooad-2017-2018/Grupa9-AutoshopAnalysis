using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShopAnalysis.Model
{
    class Autosalon
    {
        string naziv;
        string username;
        string password;
        string adresa;
        string telefon;
        BankovniRacun racun;

        public string Naziv
        {
            get => naziv;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Obavezan unos!");
                naziv = value;
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

        public string Adresa
        {
            get => adresa;
            set
            {
                if (value.Length == 0)
                    throw new Exception("Obavezan unos!");
                if (!char.IsUpper(value[0]))
                    throw new Exception("Prvo mora biti veliko!");
                if (value.Substring(value.Length - 3, 3).Any(c => !char.IsNumber(c)))
                    throw new Exception("Adresa mora sadrzavati i broj");
                adresa = value;
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
    }
}
