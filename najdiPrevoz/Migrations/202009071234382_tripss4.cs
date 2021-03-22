namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tripss4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "AutoDescr", c => c.String(nullable: false));
            AddColumn("dbo.Trips", "Img", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trips", "Img");
            DropColumn("dbo.Trips", "AutoDescr");
        }
    }
}
