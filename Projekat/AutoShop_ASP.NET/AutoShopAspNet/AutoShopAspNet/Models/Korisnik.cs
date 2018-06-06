using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoShopAspNet.Models
{
    public class Korisnik
    {
        public int korisnikId { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string telefon { get; set; }
        public BankovniRacun idBankovniRacun { get; set; }


        //dio u kojem se definisu veze sa ostalim klasama
        public virtual ICollection<Automobil> Automobil { get; set; }

    }
}