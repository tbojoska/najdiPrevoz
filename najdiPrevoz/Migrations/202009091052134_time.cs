namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class time : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "TimeHourMin", c => c.String(nullable: false));
            DropColumn("dbo.Trips", "TimeHour");
            DropColumn("dbo.Trips", "TimeMinutes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "TimeMinutes", c => c.Int(nullable: false));
            AddColumn("dbo.Trips", "TimeHour", c => c.Int(nullable: false));
            DropColumn("dbo.Trips", "TimeHourMin");
        }
    }
}
