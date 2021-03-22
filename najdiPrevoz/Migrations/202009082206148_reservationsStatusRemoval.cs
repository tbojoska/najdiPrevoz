namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reservationsStatusRemoval : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Status", c => c.String());
        }
    }
}
