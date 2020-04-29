using Finance.Core.Entities;
using Finance.Data.Migrations;
using System.Data.Entity;

namespace Finance.Data
{
    public class FinanceDbContext : DbContext
    {
        public FinanceDbContext() : base("financeDbContext")
        {

        }

        public static void Init()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<FinanceDbContext, Configuration>());
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<RecurringTransaction> RecurringTransactions { get; set; }
        public DbSet<RecurringEvent> RecurringEvents { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.UserId);

            modelBuilder.Entity<Transaction>()
                .HasKey(t => t.TranId)
                .Property(t => t.TranRecId).IsOptional();

            modelBuilder.Entity<Contact>()
                .HasKey(c => c.ContactId);

            modelBuilder.Entity<Event>()
                .HasKey(e => e.EventId)
                .Property(e => e.EventRecId).IsOptional();

            modelBuilder.Entity<RecurringTransaction>()
                .HasKey(rt => rt.TranRecId);

            modelBuilder.Entity<RecurringEvent>()
                .HasKey(re => re.EventRecId);

            modelBuilder.Entity<Transaction>()
                .HasRequired(t => t.Contact)
                .WithMany(c => c.Transactions)
                .HasForeignKey(t => t.ContactId);

            modelBuilder.Entity<Transaction>()
                .HasOptional(t => t.RecurringTransaction)
                .WithMany(rt => rt.Transactions)
                .HasForeignKey(t => t.TranRecId);

            modelBuilder.Entity<Event>()
                .HasOptional(t => t.Contact)
                .WithMany(c => c.Events)
                .HasForeignKey(t => t.ContactId);

            modelBuilder.Entity<Event>()
                .HasOptional(e => e.RecurringEvent)
                .WithMany(re => re.Events)
                .HasForeignKey(e => e.EventRecId);

            modelBuilder.Entity<Transaction>()
                .HasRequired(t => t.User)
                .WithMany(u => u.Transactions)
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<Event>()
                .HasRequired(t => t.User)
                .WithMany(u => u.Events)
                .HasForeignKey(t => t.UserId);
        }
    }
}
