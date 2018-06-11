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
        [Key]
        public int Id { get; set; }

        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }

        [Required]
        [MinLength(5,ErrorMessage ="Duzina mora biti izmedju 5-20 karaktera")]
        [MaxLength(20, ErrorMessage = "Duzina mora biti izmedju 5-20 karaktera")]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public string Telefon { get; set; }



    }
}