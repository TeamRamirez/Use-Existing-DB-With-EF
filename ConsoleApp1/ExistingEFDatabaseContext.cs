using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ConsoleApp1
{
    public partial class ExistingEFDatabaseContext : DbContext
    {
        public ExistingEFDatabaseContext()
        {
        }

        public ExistingEFDatabaseContext(DbContextOptions<ExistingEFDatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite(@"Data Source=C:\Projects\ConsoleApp_UseExistingDBWithEF\ConsoleApp1\ConsoleApp1\ExistingEFDatabase.db");
            }
        }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.BlogId).ValueGeneratedNever();

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL");
            });
        }*/
    }
}
