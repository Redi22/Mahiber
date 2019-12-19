namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DefaultsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "FirstFin", c => c.Double(nullable: false));
            AddColumn("dbo.Abouts", "SecondFin", c => c.Double(nullable: false));
            AddColumn("dbo.Abouts", "LastFin", c => c.Double(nullable: false));
            DropColumn("dbo.Abouts", "ViolationPayment");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "ViolationPayment", c => c.Double(nullable: false));
            DropColumn("dbo.Abouts", "LastFin");
            DropColumn("dbo.Abouts", "SecondFin");
            DropColumn("dbo.Abouts", "FirstFin");
        }
    }
}
