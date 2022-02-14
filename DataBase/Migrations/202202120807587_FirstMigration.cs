namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 16),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        SecondName = c.String(nullable: false, maxLength: 20),
                        MiddleName = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 16),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Login);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Login = c.String(nullable: false, maxLength: 16),
                        Address_City = c.String(maxLength: 20),
                        Address_Street = c.String(maxLength: 25),
                        Address_House = c.String(maxLength: 6),
                        Address_Flat = c.Int(nullable: false),
                        TariffId = c.Int(nullable: false),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentTraffic = c.Double(nullable: false),
                        TariffActivationDate = c.DateTime(nullable: false),
                        LastPaymentDate = c.DateTime(),
                        AutoAdditionTraffic = c.Boolean(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 20),
                        SecondName = c.String(nullable: false, maxLength: 20),
                        MiddleName = c.String(nullable: false, maxLength: 25),
                        Password = c.String(nullable: false, maxLength: 16),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Login)
                .ForeignKey("dbo.Tariffs", t => t.TariffId, cascadeDelete: true)
                .Index(t => t.TariffId);
            
            CreateTable(
                "dbo.ReportMonths",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientLogin = c.String(nullable: false, maxLength: 16),
                        TariffName = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        UsedTraffic = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientLogin, cascadeDelete: true)
                .Index(t => t.ClientLogin);
            
            CreateTable(
                "dbo.Tariffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        MonthlyPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyTraffic = c.Double(nullable: false),
                        SpeedLimit = c.Double(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "TariffId", "dbo.Tariffs");
            DropForeignKey("dbo.ReportMonths", "ClientLogin", "dbo.Clients");
            DropIndex("dbo.ReportMonths", new[] { "ClientLogin" });
            DropIndex("dbo.Clients", new[] { "TariffId" });
            DropTable("dbo.Tariffs");
            DropTable("dbo.ReportMonths");
            DropTable("dbo.Clients");
            DropTable("dbo.Admins");
        }
    }
}
