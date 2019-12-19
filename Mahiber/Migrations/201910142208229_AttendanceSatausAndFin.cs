namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttendanceSatausAndFin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "PaymentFin", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "PaymentFin");
        }
    }
}
