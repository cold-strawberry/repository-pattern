using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Premium.DatabaseAdapters.postgresql.models;

namespace Premium.DatabaseAdapters.PgSql
{
    public class PremiumDbContext : DbContext
    {
        public PremiumDbContext(DbContextOptions<PremiumDbContext> options) : base(options) { }

        public DbSet<Connection> Connections { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Connection>(entity =>
            {
                entity.HasKey(e => new { Id = e.Id, Location = e.Location })
                      .HasName("connection_location_pk");

            });
        }
    }
}