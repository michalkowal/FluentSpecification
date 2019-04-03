using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Data.Entity;
using JetBrains.Annotations;

namespace FluentSpecification.Integration.Tests.Data
{
    internal sealed class EfDbContext : DbContext
    {
        public EfDbContext()
            : base("SQLite")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public EfDbContext(DbConnection connection)
            : base(connection, false)
        {
            Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = true;
        }

        [UsedImplicitly] public DbSet<Event> Events { get; set; }

        [UsedImplicitly] public DbSet<Customer> Customers { get; set; }

        [UsedImplicitly] public DbSet<Item> Items { get; set; }

        [UsedImplicitly] public DbSet<CreditCard> CreditCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasKey(e => e.Id)
                .Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<CreditCard>()
                .HasKey(e => e.CustomerId)
                .Property(e => e.CustomerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Item>()
                .HasKey(e => e.ItemId)
                .Property(e => e.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            modelBuilder.Entity<Customer>()
                .HasKey(e => e.CustomerId)
                .Property(e => e.CustomerId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.CreditCard)
                .WithRequired(e => e.Customer);
            modelBuilder.Entity<Customer>()
                .HasOptional(e => e.Caretaker)
                .WithMany()
                .HasForeignKey(e => e.CaretakerId);
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Items)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.CustomerId);

            base.OnModelCreating(modelBuilder);
        }
    }
}