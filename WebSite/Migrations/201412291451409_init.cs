namespace WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        CarId = c.Int(nullable: false, identity: true),
                        Year = c.Int(nullable: false),
                        Make = c.String(),
                        Model = c.String(),
                        Facility = c.String(),
                        SaleDate = c.String(),
                        Odometer = c.String(),
                        Title = c.String(),
                        EstRetailValue = c.String(),
                        TitleStateType = c.String(),
                        VIN = c.String(),
                        BodyStyle = c.String(),
                        Color = c.String(),
                        Drive = c.String(),
                        Cylinders = c.String(),
                        Fuel = c.String(),
                        Keys = c.String(),
                        SpecialNote = c.String(),
                        Images = c.String(),
                        VehicleType = c.String(),
                    })
                .PrimaryKey(t => t.CarId);
            
            CreateTable(
                "dbo.CarRequest",
                c => new
                    {
                        CarRequestId = c.Int(nullable: false, identity: true),
                        Comment = c.String(),
                        CarId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CarRequestId)
                .ForeignKey("dbo.Car", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.UserProfile", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CarId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.CarRequest", new[] { "UserId" });
            DropIndex("dbo.CarRequest", new[] { "CarId" });
            DropForeignKey("dbo.CarRequest", "UserId", "dbo.UserProfile");
            DropForeignKey("dbo.CarRequest", "CarId", "dbo.Car");
            DropTable("dbo.CarRequest");
            DropTable("dbo.Car");
            DropTable("dbo.UserProfile");
        }
    }
}
