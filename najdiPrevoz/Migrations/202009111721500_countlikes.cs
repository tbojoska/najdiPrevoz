namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countlikes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "countLikes", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "countLikes");
        }
    }
}
