namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class paystatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "PayStatus", c => c.Boolean(nullable: false));
            DropColumn("dbo.Members", "MotherName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "MotherName", c => c.String());
            DropColumn("dbo.Members", "PayStatus");
        }
    }
}
