using System;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Npgsql;

namespace FluentSpecification.Integration.Tests.Data
{
    [UsedImplicitly]
    public class DatabaseFixture : IDisposable
    {
        private static readonly object LockObj = new object();

        public DatabaseFixture()
        {
            var provider = ConfigurationManager.AppSettings["Provider"];
            var connectionString = ConfigurationManager.ConnectionStrings[provider].ConnectionString;
            var builder = new DbContextOptionsBuilder<EfCoreDbContext>();

            // Check Provider and get ConnectionString
            if (provider == "SQLite")
            {
                Connection = new SQLiteConnection(connectionString);
                builder.UseSqlite(Connection);
                Connection.Open();
            }
            else if (provider == "MySQL")
            {
                Connection = new MySqlConnection(connectionString);
                builder.UseMySql(Connection);
            }
            else if (provider == "MSSQL")
            {
                Connection = new SqlConnection(connectionString);
                builder.UseSqlServer(Connection);
            }
            else if (provider == "PostgreSQL")
            {
                Connection = new NpgsqlConnection(connectionString);
                builder.UseNpgsql(Connection);
            }

            Options = builder.Options;
            lock (LockObj)
            {
                using (var context = new EfCoreDbContext(Options))
                {
                    if (context.Database.EnsureCreated())
                        SeedData(context);
                }
            }
        }

        public DbConnection Connection { get; }

        public DbContextOptions<EfCoreDbContext> Options { get; }

        public void Dispose()
        {
            if (Connection != null)
            {
                lock (LockObj)
                {
                    using (var context = new EfCoreDbContext(Options))
                    {
                        context.Database.EnsureDeleted();
                    }
                }

                Connection.Close();
                Connection.Dispose();
            }
        }

        private void SeedData(EfCoreDbContext context)
        {
            var data = new DataFixture();

            context.Events.AddRange(data.Events);
            context.CreditCards.AddRange(data.CreditCards);
            context.Items.AddRange(data.Items);
            context.Customers.AddRange(data.Customers);

            context.SaveChanges();
        }
    }
}