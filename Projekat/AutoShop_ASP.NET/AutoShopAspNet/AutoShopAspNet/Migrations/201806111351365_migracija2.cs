namespace AutoShopAspNet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracija2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Korisnik",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Ime = c.String(),
                    Prezime = c.String(),
                    Username = c.String(),
                    Password = c.String(),
                    Telefon = c.String(),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {

        }
    }
}
