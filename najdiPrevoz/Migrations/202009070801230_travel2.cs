namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class travel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "FreeSeats", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "FreeSeats");
        }
    }
}
