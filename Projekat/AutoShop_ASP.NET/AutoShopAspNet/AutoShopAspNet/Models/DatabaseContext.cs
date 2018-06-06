using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AutoShopAspNet.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(): base("AzureConnection")
        {

        }

        //dodavanje klasa iz modela kako bi bile upisane u bazu
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<AutoSalon> AutoSalon { get; set; }
        public DbSet<Automobil> Automobil { get; set; }
        public DbSet<BankovniRacun> BankovniRacun { get; set; }

        //funkcija koja sluzi da bi se ukinulo automatsko dodavanje mnozine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove < PluralizingTableNameConvention>();
        }

    }
}