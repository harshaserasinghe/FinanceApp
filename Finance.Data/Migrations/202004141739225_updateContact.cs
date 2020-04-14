namespace Finance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "BusinessType", c => c.String());
            AddColumn("dbo.Contacts", "Address", c => c.String());
            AddColumn("dbo.Contacts", "PhoneNumber", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "PhoneNumber");
            DropColumn("dbo.Contacts", "Address");
            DropColumn("dbo.Contacts", "BusinessType");
        }
    }
}
