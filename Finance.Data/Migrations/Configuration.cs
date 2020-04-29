namespace Finance.Data.Migrations
{
    using Finance.Core.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<FinanceDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinanceDbContext context)
        {
            context.Contacts.AddOrUpdate(
                c => c.Name,
                new Contact
                {
                    Name = "Keells",
                    BusinessType = "Supermarket",
                    Address = "Kottawa",
                    PhoneNumber = "0112223344"
                },
                new Contact
                {
                    Name = "Tiqri",
                    BusinessType = "Work",
                    Address = "Colombo",
                    PhoneNumber = "0112334455"
                },
                new Contact
                {
                    Name = "Commercial Bank",
                    BusinessType = "Bank",
                    Address = "Kottawa",
                    PhoneNumber = "0112445566"
                }, new Contact
                {
                    Name = "Sri Lanka Insurance",
                    BusinessType = "Insurance",
                    Address = "Colombo",
                    PhoneNumber = "0112556677"
                },
                new Contact
                {
                    Name = "Odel",
                    BusinessType = "Fashion",
                    Address = "Colombo",
                    PhoneNumber = "0112667788"
                }
                );
        }
    }
}
