namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tripss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trips", "Time", c => c.DateTime(nullable: false));
            DropColumn("dbo.Trips", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trips", "Date", c => c.String(nullable: false));
            AlterColumn("dbo.Trips", "Time", c => c.String(nullable: false));
        }
    }
}
