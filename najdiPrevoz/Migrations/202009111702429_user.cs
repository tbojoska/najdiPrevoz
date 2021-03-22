namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class user : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Trips", "UserRating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "UserRating", c => c.Int(nullable: false));
        }
    }
}
