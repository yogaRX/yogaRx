namespace yogaRx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class replacedphoto : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Poses", "Photo1");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Poses", "Photo1", c => c.String());
        }
    }
}
