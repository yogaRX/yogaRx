namespace yogaRx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poseid : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ratings", "Pose_PoseId", "dbo.Poses");
            DropIndex("dbo.Ratings", new[] { "Pose_PoseId" });
            RenameColumn(table: "dbo.Ratings", name: "Pose_PoseId", newName: "PoseId");
            AlterColumn("dbo.Ratings", "PoseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Ratings", "PoseId");
            AddForeignKey("dbo.Ratings", "PoseId", "dbo.Poses", "PoseId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ratings", "PoseId", "dbo.Poses");
            DropIndex("dbo.Ratings", new[] { "PoseId" });
            AlterColumn("dbo.Ratings", "PoseId", c => c.Int());
            RenameColumn(table: "dbo.Ratings", name: "PoseId", newName: "Pose_PoseId");
            CreateIndex("dbo.Ratings", "Pose_PoseId");
            AddForeignKey("dbo.Ratings", "Pose_PoseId", "dbo.Poses", "PoseId");
        }
    }
}
