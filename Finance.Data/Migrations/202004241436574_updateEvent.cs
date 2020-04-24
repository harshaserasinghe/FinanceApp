namespace Finance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEvent : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "EventType", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "EventStartDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "EventStartTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "EventEndDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "EventEndTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Events", "ContactId", c => c.Int());
            CreateIndex("dbo.Events", "ContactId");
            AddForeignKey("dbo.Events", "ContactId", "dbo.Contacts", "ContactId");
            DropColumn("dbo.Events", "EventDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Events", "EventDate", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.Events", "ContactId", "dbo.Contacts");
            DropIndex("dbo.Events", new[] { "ContactId" });
            DropColumn("dbo.Events", "ContactId");
            DropColumn("dbo.Events", "EventEndTime");
            DropColumn("dbo.Events", "EventEndDate");
            DropColumn("dbo.Events", "EventStartTime");
            DropColumn("dbo.Events", "EventStartDate");
            DropColumn("dbo.Events", "EventType");
        }
    }
}
