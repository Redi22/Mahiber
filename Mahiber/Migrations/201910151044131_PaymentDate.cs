namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "PayDay", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "PayDay");
        }
    }
}
