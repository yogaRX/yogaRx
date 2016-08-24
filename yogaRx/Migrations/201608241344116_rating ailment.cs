namespace yogaRx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ratingailment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ratings", "Ailment_AilmentId", c => c.Int());
            CreateIndex("dbo.Ratings", "Ailment_AilmentId");
            AddForeignKey("dbo.Ratings", "Ailment_AilmentId", "dbo.Ailments", "AilmentId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "Ailment_AilmentId", "dbo.Ailments");
            DropIndex("dbo.Ratings", new[] { "Ailment_AilmentId" });
            DropColumn("dbo.Ratings", "Ailment_AilmentId");
        }
    }
}
