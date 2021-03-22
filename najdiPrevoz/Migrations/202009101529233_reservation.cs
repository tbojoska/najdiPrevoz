namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reservation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Creator", c => c.String());
            AddColumn("dbo.Reservations", "FromDestination", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "ToDestination", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "Time", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "TimeHourMin", c => c.String(nullable: false));
            AddColumn("dbo.Reservations", "Price", c => c.Int(nullable: false));
            DropColumn("dbo.Reservations", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Date", c => c.DateTime(nullable: false));
            DropColumn("dbo.Reservations", "Price");
            DropColumn("dbo.Reservations", "TimeHourMin");
            DropColumn("dbo.Reservations", "Time");
            DropColumn("dbo.Reservations", "ToDestination");
            DropColumn("dbo.Reservations", "FromDestination");
            DropColumn("dbo.Reservations", "Creator");
        }
    }
}
