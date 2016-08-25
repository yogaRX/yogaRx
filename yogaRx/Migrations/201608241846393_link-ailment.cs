namespace yogaRx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class linkailment : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ratings", "Ailment_AilmentId", "dbo.Ailments");
            DropIndex("dbo.Ratings", new[] { "Ailment_AilmentId" });
            RenameColumn(table: "dbo.Ratings", name: "Ailment_AilmentId", newName: "AilmentId");
            AlterColumn("dbo.Ratings", "AilmentId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ratings", "AilmentId");
            AddForeignKey("dbo.Ratings", "AilmentId", "dbo.Ailments", "AilmentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "AilmentId", "dbo.Ailments");
            DropIndex("dbo.Ratings", new[] { "AilmentId" });
            AlterColumn("dbo.Ratings", "AilmentId", c => c.Int());
            RenameColumn(table: "dbo.Ratings", name: "AilmentId", newName: "Ailment_AilmentId");
            CreateIndex("dbo.Ratings", "Ailment_AilmentId");
            AddForeignKey("dbo.Ratings", "Ailment_AilmentId", "dbo.Ailments", "AilmentId");
        }
    }
}
