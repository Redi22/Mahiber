namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventFin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MahiberEvents", "Fin", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MahiberEvents", "Fin");
        }
    }
}
