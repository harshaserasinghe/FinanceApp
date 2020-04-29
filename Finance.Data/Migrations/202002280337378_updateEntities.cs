namespace Finance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateEntities : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Transactions", "Description", c => c.String());
            DropColumn("dbo.RecurringTransactions", "Name");
            DropColumn("dbo.RecurringEvents", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RecurringEvents", "Name", c => c.String());
            AddColumn("dbo.RecurringTransactions", "Name", c => c.String());
            DropColumn("dbo.Transactions", "Description");
        }
    }
}
