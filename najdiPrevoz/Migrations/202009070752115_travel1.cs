namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class travel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "Price");
        }
    }
}
