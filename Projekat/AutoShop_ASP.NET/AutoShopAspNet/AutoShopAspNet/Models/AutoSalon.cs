using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutoShopAspNet.Models
{
    public class AutoSalon
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Adresa { get; set; }
        public string Telefon { get; set; }


        //dio u kojem se definisu veze sa ostalim klasama
        public ICollection<Automobil> Automobil { get; set; }

    }
}