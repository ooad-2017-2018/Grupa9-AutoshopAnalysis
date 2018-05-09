using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShopAnalysis.Model
{
    class Automobil
    {
        string proizvodjac;
        string model;
        string stanje;
        int godiste;
        int kilometraza;
        string gorivo;
        double kubikaza;
        int konjskihSnaga;
        string pogon;
        string boja;
        string ocarinjen;
        string servisnaKnjiga;
        string turbo;
        int garancija;
        double cijena;
        string opis;
        bool prodan;

        public string Proizvodjac { get => proizvodjac; set => proizvodjac = value; }

        public string Model { get => model; set => model = value; }

        public string Stanje { get => stanje; set => stanje = value; }

        public int Godiste
        {
            get => godiste;
            set
            {
                if (value < 1990 || value > 2018)
                    throw new Exception("Pogresan unos");
                godiste = value;
            }
        }

        public int Kilometraza
        {
            get => kilometraza;
            set
            {
                if (value <= 0) throw new Exception("Pogresan unos");
                kilometraza = value;
            }
        }

        public string Gorivo { get => gorivo; set => gorivo = value; }

        public double Kubikaza
        {
            get => kubikaza;
            set
            {
                if (value <= 0) throw new Exception("Pogresan unos");
                kubikaza = value;
            }
        }

        public int KonjskihSnaga
        {
            get => konjskihSnaga;
            set
            {
                if (value <= 0) throw new Exception("Pogresan unos");
                konjskihSnaga = value;
            }
        }

        public string Pogon { get => pogon; set => pogon = value; }

        public string Boja { get => boja; set => boja = value; }

        public string Ocarinjen { get => ocarinjen; set => ocarinjen = value; }

        public string ServisnaKnjiga { get => servisnaKnjiga; set => servisnaKnjiga = value; }

        public string Turbo { get => turbo; set => turbo = value; }

        public int Garancija
        {
            get => garancija;
            set
            {
                if (value < 0) throw new Exception("Pogresan unos");
                garancija = value;
            }
        }

        public double Cijena
        {
            get => cijena;
            set
            {
                if (value <= 0) throw new Exception("Pogresan unos");
                cijena = value;
            }
        }

        public string Opis { get => opis; set => opis = value; }

        public bool Prodan { get => prodan; set => prodan = value; }
    }
}
