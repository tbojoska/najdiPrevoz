namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trips51 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "Date", c => c.String(nullable: false));
            AlterColumn("dbo.Trips", "Time", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trips", "Time", c => c.DateTime(nullable: false));
            DropColumn("dbo.Trips", "Date");
        }
    }
}
