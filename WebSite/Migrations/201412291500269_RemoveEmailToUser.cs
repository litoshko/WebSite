namespace WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveEmailToUser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserProfile", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserProfile", "Email", c => c.String());
        }
    }
}
