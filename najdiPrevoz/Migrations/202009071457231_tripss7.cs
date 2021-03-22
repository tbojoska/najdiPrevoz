namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tripss7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "TimeMinutes", c => c.String(nullable: false));
            DropColumn("dbo.Trips", "TimeMinuter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "TimeMinuter", c => c.String(nullable: false));
            DropColumn("dbo.Trips", "TimeMinutes");
        }
    }
}
