using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoShopAspNet.Models
{
    public class Korisnik
    {
        public int ID { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string telefon { get; set; }
        //racun

    }
}