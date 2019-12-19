namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class typeDeleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Payments", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "Type", c => c.String());
        }
    }
}
