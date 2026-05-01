using LicenseHub.Models;
using Microsoft.EntityFrameworkCore;

namespace LicenseHub.DB
{
    public class AppDbContext : DbContext
    {
        public DbSet<License> Licenses { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string folder = Path.Combine(appDataPath, "LicenseHub");
            Directory.CreateDirectory(folder);
            string dbPath = Path.Combine(folder, "licensehub.db");

            optionsBuilder.UseSqlite($"Data Source={dbPath};Foreign Keys=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<License>(entity =>
            {
                entity.Property(e => e.Title)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(e => e.Key)
                      .IsRequired()
                      .HasMaxLength(255);

                entity.HasIndex(e => new { e.Key, e.SupplierId })
                      .IsUnique();

                entity.Property(e => e.Type)
                      .IsRequired()
                      .HasConversion<string>();

                entity.HasIndex(e => e.Type);

                entity.Property(e => e.Cost)
                      .IsRequired();

                entity.Property(e => e.ExpirationDate)
                      .IsRequired();

                entity.HasOne(e => e.Owner)
                      .WithMany(o => o.Licenses)
                      .HasForeignKey(e => e.OwnerId)
                      .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.Supplier)
                      .WithMany(s => s.Licenses)
                      .HasForeignKey(e => e.SupplierId)
                      .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.Property(e => e.FirstName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.LastName)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.Email)
                      .IsRequired()
                      .HasMaxLength(255);

                entity.HasIndex(e => e.Email)
                      .IsUnique();

                entity.HasOne(e => e.Department)
                      .WithMany(d => d.Owners)
                      .HasForeignKey(e => e.DepartmentId)
                      .OnDelete(DeleteBehavior.SetNull);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(e => e.ContactEmail)
                      .IsRequired()
                      .HasMaxLength(255);

                entity.HasIndex(e => e.ContactEmail)
                      .IsUnique();

                entity.Property(e => e.ContactPhone)
                      .IsRequired()
                      .HasMaxLength(17);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name)
                      .IsRequired()
                      .HasMaxLength(255);

                entity.HasIndex(e => e.Name)
                      .IsUnique();
            });
        }
    }
}
