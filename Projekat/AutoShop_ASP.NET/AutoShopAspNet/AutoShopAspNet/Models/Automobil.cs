using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AutoShopAspNet.Models
{
    public class Automobil
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Required]
        public String Marka { get; set; }

        [Required]
        public String Model { get; set; }

        [Required]
        public String Boja { get; set; }

        [Required]
        public Int32 Cijena { get; set; }

        [Required]
        [Range(1995,2018, ErrorMessage ="Godiste mora biti izmedju 1995-2018")]
        public Int32 Godiste { get; set; }
        
    }
}