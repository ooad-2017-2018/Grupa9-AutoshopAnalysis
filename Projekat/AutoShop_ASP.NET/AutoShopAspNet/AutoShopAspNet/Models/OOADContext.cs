using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//neophodno uključiti kako bi se koristili DbContext i DbSet
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AutoShopAspNet.Models;

namespace OOADAspNetMVCEFAzure.Models
{
    public class OOADContext : DbContext
    {
        public OOADContext() : base("AzureConnection") //AzureConnection je naziv connection stringa u Web.config-u
 {
        }
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka
        public DbSet<Automobil> Automobil { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<AutoSalon> AutoSalon { get; set; }


        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}