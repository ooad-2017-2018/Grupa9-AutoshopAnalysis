using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoShopAspNet.Models
{
    public class Automobil
    {
        public int automobilId { get; set; }
        public string proizvodjac { get; set; }
        public string model { get; set; }
        public string stanje { get; set; }
        public int godiste { get; set; }
        public double kilometraza { get; set; }
        public string gorivo { get; set; }
        public double kubikaza { get; set; }
        public double konjskihSnaga { get; set; }
        public string pogon { get; set; }
        public string boja { get; set; }
        public bool ocarinjen { get; set; }
        public bool servisnaKnjiga { get; set; }
        public bool turbo { get; set; }
        public double garancije { get; set; }
        public double cijena { get; set; }
        public string opis { get; set; }
        public bool prodan { get; set; }

}
}