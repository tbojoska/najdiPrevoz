namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class review5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reviews", "sumRatings", c => c.Single(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reviews", "sumRatings", c => c.Int(nullable: false));
        }
    }
}
