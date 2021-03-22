namespace najdiPrevoz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class likes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trips", "UserRating", c => c.Int(nullable: false));
            DropTable("dbo.Reviews");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        creatorId = c.Long(nullable: false),
                        Creator = c.String(),
                        rating = c.Single(nullable: false),
                        countRatings = c.Int(nullable: false),
                        sumRatings = c.Single(nullable: false),
                        avgRating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Trips", "UserRating");
        }
    }
}
