namespace yogaRx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedphoto : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Poses", "Photo1", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Poses", "Photo1");
        }
    }
}
