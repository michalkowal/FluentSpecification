using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace FluentSpecification.Integration.Tests.Data
{
    public sealed class EfCoreDbContext : DbContext
    {
        public EfCoreDbContext()
        {
        }

        public EfCoreDbContext(DbContextOptions<EfCoreDbContext> options)
            : base(options)
        {
        }

        [UsedImplicitly] public DbSet<Event> Events { get; set; }

        [UsedImplicitly] public DbSet<Customer> Customers { get; set; }

        [UsedImplicitly] public DbSet<Item> Items { get; set; }

        [UsedImplicitly] public DbSet<CreditCard> CreditCards { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasKey(e => e.Id);
            modelBuilder.Entity<Event>()
                .Property(e => e.Id)
                .ValueGeneratedNever();
            modelBuilder.Entity<Event>();

            modelBuilder.Entity<CreditCard>()
                .HasKey(e => e.CustomerId);
            modelBuilder.Entity<CreditCard>()
                .Property(e => e.CustomerId)
                .ValueGeneratedNever();

            modelBuilder.Entity<Item>()
                .HasKey(e => e.ItemId);
            modelBuilder.Entity<Item>()
                .Property(e => e.ItemId)
                .ValueGeneratedNever();

            modelBuilder.Entity<Customer>()
                .HasKey(e => e.CustomerId);
            modelBuilder.Entity<Customer>()
                .Property(e => e.CustomerId)
                .ValueGeneratedNever();
            modelBuilder.Entity<Customer>()
                .HasOne(e => e.CreditCard)
                .WithOne(e => e.Customer)
                .HasForeignKey<CreditCard>(e => e.CustomerId);
            modelBuilder.Entity<Customer>()
                .HasOne(e => e.Caretaker)
                .WithMany()
                .HasForeignKey(e => e.CaretakerId)
                .IsRequired(false);
            modelBuilder.Entity<Customer>()
                .HasMany(e => e.Items)
                .WithOne(e => e.Customer)
                .HasForeignKey(e => e.CustomerId)
                .IsRequired();

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) optionsBuilder.UseSqlite("DataSource=:memory:");

            base.OnConfiguring(optionsBuilder);
        }
    }
}