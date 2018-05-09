using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AutoShopAnalysis.ViewModel
{
    public class AutomobilViewModel:INotifyPropertyChanged
    {
        string proizvodjac;
        public string Proizvodjac { get { return proizvodjac; } set { proizvodjac = value; OnPropertyChanged("Proizvodjac"); } }
        string model;
        public string Model { get { return model; } set { model = value; OnPropertyChanged("Model"); } }
        string stanje;
        public string Stanje { get { return stanje; } set { stanje = value; OnPropertyChanged("Stanje"); } }
        int godiste;
        public int Godiste { get { return godiste; } set { godiste = value; OnPropertyChanged("Godiste"); } }
        int kilometraza;
        public int Kilometraza { get { return kilometraza; } set { kilometraza = value; OnPropertyChanged("Kilometraza"); } }
        string gorivo;
        public string Gorivo { get { return gorivo; } set { gorivo = value; OnPropertyChanged("Gorivo"); } }
        double kubikaza;
        public double Kubikaza { get { return kubikaza; } set { kubikaza = value; OnPropertyChanged("Kubikaza"); } }
        int konjskihSnaga;
        public int KonjskihSnaga { get { return konjskihSnaga; } set { konjskihSnaga = value; OnPropertyChanged("KonjskihSnaga"); } }
        string pogon;
        public string Pogon { get { return pogon; } set { pogon = value; OnPropertyChanged("Pogon"); } }
        string boja;
        public string Boja { get { return boja; } set { boja = value; OnPropertyChanged("Boja"); } }
        string ocarinjen;
        public string Ocarinjen { get { return ocarinjen; } set { ocarinjen = value; OnPropertyChanged("Ocarinjen"); } }
        string servisnaKnjiga;
        public string ServirnaKnjiga { get { return servisnaKnjiga; } set { servisnaKnjiga = value; OnPropertyChanged("ServisnaKnjiga"); } }
        string turbo;
        public string Turbo { get { return turbo; } set { turbo = value; OnPropertyChanged("Turbo"); } }
        int garancija;
        public int Garancija { get { return garancija; } set { garancija = value; OnPropertyChanged("Garancija"); } }
        double cijena;
        public double Cijena { get { return cijena; } set { cijena = value; OnPropertyChanged("Cijena"); } }
        string opis;
        public string Opis { get { return opis; } set { opis = value; OnPropertyChanged("Opis"); } }
        bool prodan;
        public bool Prodan { get { return prodan; } set { prodan = value; OnPropertyChanged("Prodan"); } }


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
