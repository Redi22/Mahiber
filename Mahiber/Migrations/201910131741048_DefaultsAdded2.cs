namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefaultsAdded2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abouts", "EventFin");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "EventFin", c => c.Double(nullable: false));
        }
    }
}
