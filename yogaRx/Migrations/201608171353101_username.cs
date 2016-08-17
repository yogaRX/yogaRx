namespace yogaRx.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class username : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "UserHandle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "UserHandle");
        }
    }
}
