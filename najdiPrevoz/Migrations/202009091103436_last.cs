namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class last : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trips", "TimeHourMin", c => c.String(nullable: false));
            AlterColumn("dbo.Trips", "AutoDescr", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trips", "AutoDescr", c => c.String());
            AlterColumn("dbo.Trips", "TimeHourMin", c => c.String());
        }
    }
}
