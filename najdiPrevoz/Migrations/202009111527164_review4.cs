namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class review4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "countRatings", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "countRatings");
        }
    }
}
