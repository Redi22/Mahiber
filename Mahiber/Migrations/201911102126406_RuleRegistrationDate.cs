namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RuleRegistrationDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rules", "RegisteredDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rules", "RegisteredDate");
        }
    }
}
