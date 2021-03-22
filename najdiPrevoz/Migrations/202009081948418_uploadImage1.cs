namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uploadImage1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserPhoto", c => c.Binary());
            DropColumn("dbo.AspNetUsers", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "ImageUrl", c => c.String());
            DropColumn("dbo.AspNetUsers", "UserPhoto");
        }
    }
}
