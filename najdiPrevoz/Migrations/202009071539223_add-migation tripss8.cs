namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigationtripss8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trips", "TimeHour", c => c.Int(nullable: false));
            AlterColumn("dbo.Trips", "TimeMinutes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trips", "TimeMinutes", c => c.String());
            AlterColumn("dbo.Trips", "TimeHour", c => c.String(nullable: false));
        }
    }
}
