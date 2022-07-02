using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(connectionString: "FileName=" + System.Environment.CurrentDirectory + "\\Database.db",
                sqliteOptionsAction: op =>
                {
                    op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName
                        );
                });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Configuration>().ToTable("Configurations");
            modelBuilder.Entity<Configuration>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Type>().ToTable("Types");
            modelBuilder.Entity<Type>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Detail>().ToTable("Details");
            modelBuilder.Entity<Detail>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(e => e.Name).IsUnique();
            });
            modelBuilder.Entity<Movement>().ToTable("Movements");
            modelBuilder.Entity<Movement>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Configuration> Configurations { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Movement> Movements { get; set; }
    }
}
