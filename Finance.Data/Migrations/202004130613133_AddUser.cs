﻿namespace Finance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.Contacts", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Transactions", "UserId", c => c.Int(nullable: false));
            AddColumn("dbo.Events", "UserId", c => c.Int(nullable: false));
            CreateIndex("dbo.Contacts", "UserId");
            CreateIndex("dbo.Transactions", "UserId");
            CreateIndex("dbo.Events", "UserId");
            AddForeignKey("dbo.Events", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            AddForeignKey("dbo.Transactions", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
            AddForeignKey("dbo.Contacts", "UserId", "dbo.Users", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contacts", "UserId", "dbo.Users");
            DropForeignKey("dbo.Transactions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Events", "UserId", "dbo.Users");
            DropIndex("dbo.Events", new[] { "UserId" });
            DropIndex("dbo.Transactions", new[] { "UserId" });
            DropIndex("dbo.Contacts", new[] { "UserId" });
            DropColumn("dbo.Events", "UserId");
            DropColumn("dbo.Transactions", "UserId");
            DropColumn("dbo.Contacts", "UserId");
            DropTable("dbo.Users");
        }
    }
}
