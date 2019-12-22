namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class date_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "RegisteredDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "RegisteredDate");
        }
    }
}
