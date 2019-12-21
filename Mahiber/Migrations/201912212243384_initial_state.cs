namespace Mahiber.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial_state : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        EdirName = c.String(),
                        Capital = c.Double(nullable: false),
                        Description = c.String(),
                        MonthlyPayment = c.Double(nullable: false),
                        PaymentFin = c.Double(nullable: false),
                        EventFin = c.Double(nullable: false),
                        FirstFin = c.Double(nullable: false),
                        SecondFin = c.Double(nullable: false),
                        LastFin = c.Double(nullable: false),
                        WithPay = c.Boolean(nullable: false),
                        PayDay = c.DateTime(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Attendances",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        EventId = c.Long(nullable: false),
                        MemberId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MahiberEvents", t => t.EventId, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.EventId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.MahiberEvents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Time = c.DateTime(nullable: false),
                        Place = c.String(),
                        Fin = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        SpouseName = c.String(),
                        Gender = c.String(),
                        MariageStatus = c.Boolean(nullable: false),
                        SubCity = c.String(),
                        Woreda = c.Long(nullable: false),
                        Kebele = c.Long(nullable: false),
                        PhoneNumber = c.Long(nullable: false),
                        HouseNummber = c.String(),
                        PayStatus = c.Boolean(nullable: false),
                        AttendStatus = c.Boolean(nullable: false),
                        Debit = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        MemberId = c.Long(nullable: false),
                        Amount = c.Double(nullable: false),
                        Type = c.String(),
                        PaidDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        EventPrivilage = c.Boolean(nullable: false),
                        MemberPrivilage = c.Boolean(nullable: false),
                        PaymentPrivilage = c.Boolean(nullable: false),
                        RulePrivilage = c.Boolean(nullable: false),
                        SuperAdminPrivilage = c.Boolean(nullable: false),
                        RoleCreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rules",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        FirstFin = c.Double(nullable: false),
                        SecondFin = c.Double(nullable: false),
                        LastFin = c.Double(nullable: false),
                        RegisteredDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Violations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RuleId = c.Long(nullable: false),
                        MemberId = c.Long(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Members", t => t.MemberId, cascadeDelete: true)
                .ForeignKey("dbo.Rules", t => t.RuleId, cascadeDelete: true)
                .Index(t => t.RuleId)
                .Index(t => t.MemberId);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        RoleId = c.Long(nullable: false),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserAccounts", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Violations", "RuleId", "dbo.Rules");
            DropForeignKey("dbo.Violations", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Payments", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Attendances", "MemberId", "dbo.Members");
            DropForeignKey("dbo.Attendances", "EventId", "dbo.MahiberEvents");
            DropIndex("dbo.UserAccounts", new[] { "RoleId" });
            DropIndex("dbo.Violations", new[] { "MemberId" });
            DropIndex("dbo.Violations", new[] { "RuleId" });
            DropIndex("dbo.Payments", new[] { "MemberId" });
            DropIndex("dbo.Attendances", new[] { "MemberId" });
            DropIndex("dbo.Attendances", new[] { "EventId" });
            DropTable("dbo.UserAccounts");
            DropTable("dbo.Violations");
            DropTable("dbo.Rules");
            DropTable("dbo.Roles");
            DropTable("dbo.Payments");
            DropTable("dbo.Members");
            DropTable("dbo.MahiberEvents");
            DropTable("dbo.Attendances");
            DropTable("dbo.Abouts");
        }
    }
}
