namespace yogaRx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bodyparts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ailments", "BodyPartID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ailments", "BodyPartID");
        }
    }
}
