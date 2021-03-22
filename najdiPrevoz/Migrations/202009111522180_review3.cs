namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class review3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "rating", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "rating");
        }
    }
}
