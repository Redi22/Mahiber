namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PayCodeRemoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Payments", "PaymentCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Payments", "PaymentCode", c => c.Long(nullable: false));
        }
    }
}
