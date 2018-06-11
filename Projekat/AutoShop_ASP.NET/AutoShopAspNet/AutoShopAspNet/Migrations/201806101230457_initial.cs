namespace AutoShopAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Automobil",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Marka = c.String(),
                        Model = c.String(),
                        Boja = c.String(),
                        Cijena = c.String(),
                        Godiste = c.String(),
                        Korisnik_KorisnikId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Korisnik", t => t.Korisnik_KorisnikId)
                .Index(t => t.Korisnik_KorisnikId);
            
            CreateTable(
                "dbo.Korisnik",
                c => new
                    {
                        KorisnikId = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Telefon = c.String(),
                        IdBankovniRacun_ID = c.Int(),
                    })
                .PrimaryKey(t => t.KorisnikId)
                .ForeignKey("dbo.BankovniRacun", t => t.IdBankovniRacun_ID)
                .Index(t => t.IdBankovniRacun_ID);
            
            CreateTable(
                "dbo.BankovniRacun",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Stanje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Korisnik", "IdBankovniRacun_ID", "dbo.BankovniRacun");
            DropForeignKey("dbo.Automobil", "Korisnik_KorisnikId", "dbo.Korisnik");
            DropIndex("dbo.Korisnik", new[] { "IdBankovniRacun_ID" });
            DropIndex("dbo.Automobil", new[] { "Korisnik_KorisnikId" });
            DropTable("dbo.BankovniRacun");
            DropTable("dbo.Korisnik");
            DropTable("dbo.Automobil");
        }
    }
}
