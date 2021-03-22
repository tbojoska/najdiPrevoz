namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tripss5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "TimeHour", c => c.String(nullable: false));
            AddColumn("dbo.Trips", "TimeMinuter", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "TimeMinuter");
            DropColumn("dbo.Trips", "TimeHour");
        }
    }
}
