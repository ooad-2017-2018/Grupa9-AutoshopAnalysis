using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace App9.Model
{
    public class Korisnik
    {
        public string id
        {
            get;
            set;
        }
        public string ime
        { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

    }
}
