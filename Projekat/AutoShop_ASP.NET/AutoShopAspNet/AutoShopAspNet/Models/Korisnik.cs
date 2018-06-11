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

        [ScaffoldColumn(false)]
        public int KorisnikId { get; set; }

        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }

        [Required]
        [Range(5,15,ErrorMessage ="Duzina username-a mora biti izmedju 5-15 karaktera")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Telefon { get; set; }



    }
}