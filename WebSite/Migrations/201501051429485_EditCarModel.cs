namespace WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EditCarModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Car", "SaleDate");
            DropColumn("dbo.Car", "EstRetailValue");
            DropColumn("dbo.Car", "Keys");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Car", "Keys", c => c.String());
            AddColumn("dbo.Car", "EstRetailValue", c => c.String());
            AddColumn("dbo.Car", "SaleDate", c => c.String());
        }
    }
}
