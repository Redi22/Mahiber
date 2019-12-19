namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WithPay : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "WithPay", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "WithPay");
        }
    }
}
