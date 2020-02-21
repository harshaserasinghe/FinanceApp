namespace Finance.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                {
                    ContactId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    IsActive = c.Boolean(nullable: false, defaultValue: true),
                })
                .PrimaryKey(t => t.ContactId);

            CreateTable(
                "dbo.Transactions",
                c => new
                {
                    TranId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    TranType = c.Int(nullable: false),
                    TranDate = c.DateTime(nullable: false),
                    Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    IsActive = c.Boolean(nullable: false, defaultValue: true),
                    IsRecurring = c.Boolean(nullable: false, defaultValue: false),
                    ContactId = c.Int(nullable: false),
                    TranRecId = c.Int(),
                })
                .PrimaryKey(t => t.TranId)
                .ForeignKey("dbo.Contacts", t => t.ContactId, cascadeDelete: true)
                .ForeignKey("dbo.RecurringTransactions", t => t.TranRecId)
                .Index(t => t.ContactId)
                .Index(t => t.TranRecId);

            CreateTable(
                "dbo.RecurringTransactions",
                c => new
                {
                    TranRecId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    IsActive = c.Boolean(nullable: false, defaultValue: true),
                    Frequency = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TranRecId);

            CreateTable(
                "dbo.Events",
                c => new
                {
                    EventId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    Description = c.String(),
                    EventDate = c.DateTime(nullable: false),
                    IsActive = c.Boolean(nullable: false, defaultValue: true),
                    IsRecurring = c.Boolean(nullable: false, defaultValue: false),
                    EventRecId = c.Int(),
                })
                .PrimaryKey(t => t.EventId)
                .ForeignKey("dbo.RecurringEvents", t => t.EventRecId)
                .Index(t => t.EventRecId);

            CreateTable(
                "dbo.RecurringEvents",
                c => new
                {
                    EventRecId = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                    IsActive = c.Boolean(nullable: false, defaultValue: true),
                    Frequency = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.EventRecId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Events", "EventRecId", "dbo.RecurringEvents");
            DropForeignKey("dbo.Transactions", "TranRecId", "dbo.RecurringTransactions");
            DropForeignKey("dbo.Transactions", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Events", new[] { "EventRecId" });
            DropIndex("dbo.Transactions", new[] { "TranRecId" });
            DropIndex("dbo.Transactions", new[] { "ContactId" });
            DropTable("dbo.RecurringEvents");
            DropTable("dbo.Events");
            DropTable("dbo.RecurringTransactions");
            DropTable("dbo.Transactions");
            DropTable("dbo.Contacts");
        }
    }
}
