namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trips5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "Capacity", c => c.Int(nullable: false));
            DropColumn("dbo.Trips", "NoFree");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "NoFree", c => c.Int(nullable: false));
            DropColumn("dbo.Trips", "Capacity");
        }
    }
}
