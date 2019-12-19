namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventTime : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MahiberEvents", "Time", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MahiberEvents", "Time");
        }
    }
}
