namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class r : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Trips", "TimeHourMin", c => c.String());
            AlterColumn("dbo.Trips", "AutoDescr", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Trips", "AutoDescr", c => c.String(nullable: false));
            AlterColumn("dbo.Trips", "TimeHourMin", c => c.String(nullable: false));
        }
    }
}
